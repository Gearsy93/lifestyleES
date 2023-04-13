using System.Security.Permissions;

namespace LifestyleQualityES.Model
{
    internal class LogicalInferenceMechanism
    {
        public WorkingMemory _workingMemory;
        public formConsult formConsult;
        public Variable goalVariable;
        public LogicalInferenceMechanism(WorkingMemory workingMemory, formConsult formConsult, KnowledgeBase knowledge)
        {
            _workingMemory = workingMemory;
            this.formConsult = formConsult;
        }

        public bool DeduceVariable(Variable variable)
        {
            foreach (Rule rule in _workingMemory.UnusedRules.ToArray())
            {
                if (rule.Conclusion.Variable == variable)
                {
                    bool result = rule.Premise.FactOperator == FactOperator.Disjunction ? CheckOrPremise(rule) : result = CheckAndPremise(rule);

                    if (result)
                    {
                        _workingMemory.AddUsedRule(rule);
                        _workingMemory.AddConclusionFact(rule.Conclusion);
                        if (variable == goalVariable)
                        {
                            formConsult.deduceStopped = true;
                        }
                        return true;
                    }
                }
            }
            if (variable.GetType() == typeof(DeducibleAskedVariable))
            {
                SingleFact singleFact = CallForm(variable);
                return true;
            }
            if (variable == goalVariable)
            {
                formConsult.deduceStopped = true;
            }
            return false;
        }

        private bool CheckOrPremise(Rule rule)
        {
            foreach (Fact premiseFact in rule.Premise.Facts)
            {
                if (premiseFact.GetType() == typeof(SingleFact))
                {
                    foreach (SingleFact memoryFact in _workingMemory.DeducedFacts)
                    {
                        if (memoryFact.Variable == ((SingleFact)premiseFact).Variable)
                        {
                            return CheckSingleFact((SingleFact)premiseFact);
                        }
                    }
                }
                else 
                {
                    int variableCount = 0;
                    foreach (Variable variable in ((AdditiveFact)premiseFact).Variables)
                    {
                        foreach (SingleFact memoryFact in _workingMemory.DeducedFacts)
                        {
                            if (memoryFact.Variable == variable)
                            {
                                variableCount++;
                                break;
                            }
                        }
                    }
                    if (variableCount == ((AdditiveFact)premiseFact).Variables.Count)
                    {
                        return CheckAdditiveFact((AdditiveFact)premiseFact);
                    }
                }
            }

            foreach (Fact fact in rule.Premise.Facts)
            {
                if (fact.GetType() == typeof(SingleFact))
                {
                    if (CheckSingleFact((SingleFact)fact)) return true;
                }
                else
                {
                    if (CheckAdditiveFact((AdditiveFact)fact)) return true;
                }
            }
            return false;
        }

        private bool CheckAndPremise(Rule rule)
        {
            foreach (Fact fact in rule.Premise.Facts)
            {
                if (fact.GetType() == typeof(SingleFact))
                {
                    if (!CheckSingleFact((SingleFact)fact)) return false;
                }
                else
                {
                    if (!CheckAdditiveFact((AdditiveFact)fact)) return false;
                }
            }
            return true;
        }

        private bool CheckSingleFact(SingleFact checkingFact)
        {

            foreach (SingleFact fact in _workingMemory.DeducedFacts)
            {
                if (fact.Variable == checkingFact.Variable)
                {
                    if (fact.Value == checkingFact.Value)
                    {
                        return true;
                    }
                    else return false;
                }
            }
            // if (checkingFact.Variable.GetType() == typeof(AskedVariable) || checkingFact.Variable.GetType() == typeof(DeducibleAskedVariable))
            if (checkingFact.Variable.GetType() == typeof(AskedVariable))
            {
                return checkingFact.Value == CallForm(checkingFact.Variable).Value;
            }
            else
            {
                if (DeduceVariable(checkingFact.Variable))
                {
                    foreach (SingleFact fact in _workingMemory.DeducedFacts)
                    {
                        if (fact.Variable == checkingFact.Variable)
                        {
                            if (fact.Value == checkingFact.Value)
                            {
                                return true;
                            }
                            else return false;
                        }
                    }
                }
                return false;
            }

        }

        private bool CheckAdditiveFact(AdditiveFact additiveFact)
        {
            double result = 0.0;
            foreach (Variable variable in additiveFact.Variables)
            {
                bool found = false;
                foreach (SingleFact singleFact in _workingMemory.DeducedFacts)
                {
                    if (singleFact.Variable == variable) 
                    {
                        found = true;
                        result += ((NumericDomainValue)singleFact.Value).GetDoubleValue();
                        break;
                    }
                }
                if (!found)
                {
                    if (variable.GetType() == typeof(AskedVariable))
                    {
                        var callresult = CallForm(variable);
                        result += ((NumericDomainValue)callresult.Value).GetDoubleValue();
                    }
                    else
                    {
                        if (DeduceVariable(variable))
                        {
                            foreach (SingleFact singleFact in _workingMemory.DeducedFacts)
                            {
                                if (singleFact.Variable == variable)
                                {
                                    result += ((NumericDomainValue)singleFact.Value).GetDoubleValue();
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            return double.Parse(additiveFact.Value.Value) == result;
        }

        private SingleFact CallForm(Variable variable)
        {
            formConsult.shellAnswers.Add(((AskedVariable)variable).Question);
            formConsult.answers.Clear();
            foreach (DomainValue domainValue in variable.Domain.Values)
            {
                formConsult.answers.Add(domainValue.Value);
            }
            formConsult.autoEvent.WaitOne();
            SingleFact currentFact = new SingleFact(variable, variable.Domain.GetValueByString(formConsult.selectedAnswer));
            _workingMemory.AddConclusionFact(currentFact);
            return currentFact;
        }
    }
}
