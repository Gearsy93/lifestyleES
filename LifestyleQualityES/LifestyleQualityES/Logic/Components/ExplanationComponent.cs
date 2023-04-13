using System.Collections.Generic;
using System.Windows.Forms;

namespace LifestyleQualityES.Model
{
    internal class ExplanationComponent
    {
        public Variable goalVariable;
        public string goalName;
        public WorkingMemory workingMemory;
        public TreeNode treeNode;

        public ExplanationComponent(WorkingMemory memory)
        {
            this.workingMemory = memory;
        }

        public void CreateTree(Variable inputGoalVariable)
        {
            this.goalVariable = inputGoalVariable;
            this.goalName = inputGoalVariable.Name;
            this.treeNode = BuildTree(inputGoalVariable);
        }

        public TreeNode BuildTree(Variable currentGoalVariable)
        {
            TreeNode currentNode = new TreeNode();
            foreach (SingleFact fact in workingMemory.DeducedFacts)
            {
                if (fact.Variable == currentGoalVariable)
                {
                    string displayValue = fact.Value.Value;
                    if (fact.Value.GetType() == typeof(NumericDomainValue))
                    {
                        if (((NumericDomainValue)fact.Value).GetDoubleValue() == 1)
                        {
                            displayValue = "Да";
                        }
                        else if (((NumericDomainValue)fact.Value).GetDoubleValue() == 2)
                        {
                            displayValue = "Нет";
                        }
                    }
                    currentNode.Text = currentGoalVariable.Name == goalName ? "Цель: " + currentGoalVariable.Name + " = " + displayValue : "Подцель: " + currentGoalVariable.Name + " = " + displayValue;
                    break;
                }
            }
            foreach (Rule rule in workingMemory.UsedRules)
            {
                if (rule.Conclusion.Variable == currentGoalVariable) 
                {
                    // Правило, по которому выводится текущая переменная
                    currentNode.Nodes.Add("[" + rule.Name + "]: " + rule.Explanation);

                    // Добавляем вложенные правила/подцели/запрошенные переменные
                    if (rule.Premise.FactOperator == FactOperator.Disjunction)
                    {
                        foreach (TreeNode treeNode in CheckOrPremise(rule))
                        {
                            currentNode.Nodes.Add(treeNode);
                        }
                    }
                    else
                    {
                        foreach(TreeNode treeNode in CheckAndPremise(rule))
                        {
                            currentNode.Nodes.Add(treeNode);
                        }
                    }
                    break;
                }
            }

            if (currentNode.Nodes.Count == 0 && currentGoalVariable == this.goalVariable)
            {
                if (currentGoalVariable.GetType() == typeof(DeducibleAskedVariable))
                {
                    foreach (SingleFact fact in workingMemory.DeducedFacts)
                    {
                        if (fact.Variable == currentGoalVariable)
                        {
                            currentNode.Nodes.Add(new TreeNode("Цель: " + fact.PremiseToString() + " (запрошено)"));
                            break;
                        }
                    }
                }
            }

            return currentNode;
        }

        public List<TreeNode> CheckOrPremise(Rule rule)
        {
            List<TreeNode> treeNodes = new List<TreeNode>();
            // Ищем переменную правила в списке выведенных фактов 
            foreach (Fact fact in rule.Premise.Facts)
            {
                if (fact.GetType() == typeof(SingleFact))
                {
                    treeNodes = CheckSingleFact((SingleFact)fact);
                }
                else
                {
                    treeNodes = CheckAdditiveFact((AdditiveFact)fact);
                }
                if (treeNodes.Count > 0) return treeNodes;
            }
            return treeNodes;
        }

        // Необходимо проверить каждый факт, поэтому тут будет список
        public List<TreeNode> CheckAndPremise(Rule rule)
        {
            List<TreeNode> treeNodes = new List<TreeNode>();

            foreach (Fact fact in rule.Premise.Facts)
            {
                List<TreeNode> currentNodes;
                if (fact.GetType() == typeof(SingleFact))
                {
                    currentNodes = CheckSingleFact((SingleFact)fact);
                }
                else
                {
                    currentNodes = CheckAdditiveFact((AdditiveFact)fact);
                }

                if (currentNodes.Count < 0)
                {
                    return new List<TreeNode>();
                }
                else
                {
                    foreach (TreeNode node in currentNodes) 
                    {
                        treeNodes.Add(node);
                    }
                }
            }

            return treeNodes;
        }

        public List<TreeNode> CheckSingleFact(SingleFact singleFact)
        {
            List<TreeNode> treeNodes = new List<TreeNode>();

            foreach (SingleFact memoryFact in workingMemory.DeducedFacts)
            {
                if (memoryFact.Variable == singleFact.Variable)
                {
                    // Точно была запрошена
                    if (singleFact.Variable.GetType() == typeof(AskedVariable))
                    {
                        treeNodes.Add(new TreeNode("Подцель: " + singleFact.PremiseToString() + " (запрошено)"));
                    }
                    // Точно была выведена
                    else if (singleFact.Variable.GetType() == typeof(DeducibleVariable))
                    {
                        treeNodes.Add(BuildTree(singleFact.Variable));
                        return treeNodes;
                    }
                    // Нужно определить способ вывода
                    else
                    {
                        foreach (Rule rule in workingMemory.UsedRules)
                        {
                            // Была выведена
                            if (rule.Conclusion.Variable == singleFact.Variable)
                            {
                                treeNodes.Add(BuildTree(singleFact.Variable));
                                return treeNodes;
                            }
                        }
                        // Не найдена в правилах, значит была запрошена
                        treeNodes.Add(new TreeNode("Подцель: " + singleFact.PremiseToString() + " (запрошено)"));
                        return treeNodes;
                    }
                }
            }
            return treeNodes;
        }

        public List<TreeNode> CheckAdditiveFact(AdditiveFact additiveFact)
        {
            List<TreeNode> treeNodes = new List<TreeNode>();
            double result = 0.0;
            foreach (Variable variable in additiveFact.Variables)
            {
                foreach (SingleFact memoryFact in workingMemory.DeducedFacts)
                {
                    if (memoryFact.Variable == variable)
                    {
                        result += ((NumericDomainValue)memoryFact.Value).GetDoubleValue();
                        // Точно была запрошена
                        if (variable.GetType() == typeof(AskedVariable))
                        {
                            treeNodes.Add(new TreeNode("Подцель: " + memoryFact.PremiseToString() + " (запрошено)"));
                        }
                        // Точно была выведена
                        else if (variable.GetType() == typeof(DeducibleVariable))
                        {
                            treeNodes.Add(BuildTree(variable));
                        }
                        // Нужно определить способ вывода
                        else
                        {
                            foreach (Rule rule in workingMemory.UsedRules)
                            {
                                // Была выведена
                                if (rule.Conclusion.Variable == variable)
                                {
                                    treeNodes.Add(BuildTree(variable));
                                }
                            }
                            // Не найдена в правилах, значит была запрошена
                            treeNodes.Add(new TreeNode("Подцель: " + memoryFact.PremiseToString() + " (запрошено)"));
                        }
                    }
                }
            }

            // Соответствует факту правила
            if (double.Parse(additiveFact.Value.Value) == result)
            {
                return treeNodes;
            }
            else
            {
                return new List<TreeNode>();
            }
        }
    }
}
