using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LifestyleQualityES.Model
{
    internal class KnowledgeAcquisitionComponent
    {
        public enum Operation : byte
        {
            Add,
            Update
        }

        public enum VarType : byte
        {
            Asked,
            Deducible,
            DeducibleAsked
        }

        public KnowledgeBase _knowledgeBase;

        public KnowledgeAcquisitionComponent(ref KnowledgeBase knowledgeBase)
        {
            _knowledgeBase = knowledgeBase;
        }

        #region Domain

        public bool DomainContains(string name)
        {
            return _knowledgeBase.Domains.Any(x => x.Name == name);
        }

        public void AddDomain(string name, List<string> values, bool isNumeric)
        {
            Domain domain = new Domain(name, isNumeric);
            if (isNumeric)
            {
                foreach (string value in values)
                {
                    domain.AddDomainValue(new NumericDomainValue(value, domain));
            }
            }
            else
            {
                foreach (string value in values)
                {
                    domain.AddDomainValue(new DomainValue(value, domain));
                }
            }
            _knowledgeBase.Domains.Add(domain);
        }

        public void UpdateDomain(int index, string name, List<string> values, bool isNumeric) 
        {
            _knowledgeBase.Domains[index].Name = name;
            if (_knowledgeBase.Domains[index].IsNumeric == isNumeric)
            {
                List<string> currentValues = _knowledgeBase.Domains[index].Values.Select(x => x.Value).ToList();
                List<string> toDelete = currentValues.Except(values).ToList();
                List<string> toAdd = values.Except(currentValues).ToList();

                foreach (string value in toDelete)
                {
                    _knowledgeBase.Domains[index].RemoveDomainValue(_knowledgeBase.Domains[index].GetValueByString(value));
                }

                if (isNumeric)
                {
                    foreach (string value in toAdd)
                    {
                        _knowledgeBase.Domains[index].AddDomainValue(new NumericDomainValue(value, _knowledgeBase.Domains[index]));
                    }
                }
                else
                {
                    foreach (string value in toAdd)
                    {
                        _knowledgeBase.Domains[index].AddDomainValue(new DomainValue(value, _knowledgeBase.Domains[index]));
                    }
                }
                List<DomainValue> sortedValues = new List<DomainValue>();
                foreach (string value in values)
                {
                    sortedValues.Add(_knowledgeBase.Domains[index].GetValueByString(value));
                }
                _knowledgeBase.Domains[index].Values = sortedValues;
            }
            else
            {
                _knowledgeBase.Domains[index].Values.Clear();
                _knowledgeBase.Domains[index].IsNumeric = isNumeric;
                if (isNumeric)
                {

                    foreach (string value in values)
                    {
                        _knowledgeBase.Domains[index].AddDomainValue(new NumericDomainValue(value, _knowledgeBase.Domains[index]));
                    }
                }
                else 
                {
                    foreach (string value in values)
                    {
                        _knowledgeBase.Domains[index].AddDomainValue(new DomainValue(value, _knowledgeBase.Domains[index]));
                    }
                }
                List<DomainValue> sortedValues = new List<DomainValue>();
                foreach (string value in values)
                {
                    sortedValues.Add(_knowledgeBase.Domains[index].GetValueByString(value));
                }
                _knowledgeBase.Domains[index].Values = sortedValues;
            }
        }

        public void DeleteDomain(int index)
        {
            foreach(Variable variable in _knowledgeBase.Variables)
            {
                if (variable.Domain == _knowledgeBase.Domains[index])
                {
                    MessageBox.Show("Некоторые переменные имеют этот домен");
                    return;
                }
            }
            _knowledgeBase.Domains.RemoveAt(index);
        }

        #endregion

        #region Variable

        public Variable GetVariableByName(string name)
        {
            foreach (Variable variable in _knowledgeBase.Variables)
            {
                if (variable.Name == name) return variable;
            }
            return null;
        }

        public bool VariableContains(string name)
        {
            return _knowledgeBase.Variables.Any(x => x.Name == name);
        }

        public void AddVariable(string name, Domain domain, VarType varType, string quesionText)
        {
            Variable variable;
            if (varType == VarType.Asked)
            {
                variable = new AskedVariable(name, domain, quesionText);
            }
            else if (varType == VarType.Deducible)
            {
                variable = new DeducibleVariable(name, domain);
            }
            else 
            {
                variable = new DeducibleAskedVariable(name, domain, quesionText);
                
            }
            _knowledgeBase.Variables.Add(variable);

        }

        public void UpdateVariable(int index, string name, Domain domain, VarType varType, string quesionText)
        {
            Type type;
            switch(varType)
            {
                case VarType.Asked:
                    type = typeof(AskedVariable);
                    break;
                case VarType.Deducible:
                    type = typeof(DeducibleVariable);
                    break;
                case VarType.DeducibleAsked:
                    type = typeof(DeducibleAskedVariable);
                    break;
                default:
                    type = typeof(DeducibleAskedVariable);
                    break;
            }
            if (_knowledgeBase.Variables[index].GetType() == type)
            {
                _knowledgeBase.Variables[index].Name = name;
                _knowledgeBase.Variables[index].Domain = domain;

                if (_knowledgeBase.Variables[index].GetType() == typeof(AskedVariable))
                {
                    ((AskedVariable)_knowledgeBase.Variables[index]).Question = quesionText;
                }
                else if (_knowledgeBase.Variables[index].GetType() == typeof(DeducibleAskedVariable))
                {
                    ((DeducibleAskedVariable)_knowledgeBase.Variables[index]).Question = quesionText;
                }
            }
            else
            {
                Variable variable;
                if (type == typeof(AskedVariable))
                {
                    variable = new AskedVariable(name, domain, quesionText);
                    
                }
                else if (type == typeof(DeducibleVariable))
                {
                     variable = new DeducibleVariable(name, domain);
                }
                else
                {
                    variable = new DeducibleAskedVariable(name, domain, quesionText);
                }
                _knowledgeBase.Variables.RemoveAt(index);
                _knowledgeBase.Variables.Insert(index, variable);
            }
            
        }

        public void DeleteVariable(int index)
        {
            _knowledgeBase.Variables.RemoveAt(index);
        }

        #endregion

        #region Rule

        public void AddRule(List<Fact> facts, bool isConjuction, string ruleName, SingleFact conclusion, string explanation)
        {
            Premise premise = new Premise(facts, isConjuction ? FactOperator.Сonjunction : FactOperator.Disjunction);
            Rule rule = new Rule(ruleName, explanation, premise, conclusion);
            rule.Explanation = rule.Explanation == "" ? rule.GenerateExplanation() : rule.Explanation;
            _knowledgeBase.Rules.Add(rule);
        }

        public void UpdateRule(List<Fact> facts, bool isConjuction, string ruleName, SingleFact conclusion, string explanation, int index)
        {
            _knowledgeBase.Rules[index].Premise.Facts = facts;
            _knowledgeBase.Rules[index].Premise.FactOperator = isConjuction ? FactOperator.Сonjunction : FactOperator.Disjunction;
            _knowledgeBase.Rules[index].Name = ruleName;
            _knowledgeBase.Rules[index].Conclusion = conclusion;
            _knowledgeBase.Rules[index].Explanation = explanation;
            _knowledgeBase.Rules[index].Explanation = _knowledgeBase.Rules[index].Explanation == "" ? _knowledgeBase.Rules[index].GenerateExplanation() : _knowledgeBase.Rules[index].Explanation;
        }

        public void DeleteRule(int index)
        {
            _knowledgeBase.Rules.RemoveAt(index);
        }
        #endregion
    }
}
