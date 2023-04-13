using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace LifestyleQualityES.Model
{
    [DataContract]
    internal class Rule
    {
        [DataMember]
        private string _name;
        public string Name
        {
            get { return this._name; }
            set
            {
                if (value == null)
                {
                    throw new NullRuleName("Rule name was null");
                }
                else
                {
                    this._name = value;
                }
            }
        }

        [DataMember]
        private string _explanation;
        public string Explanation
        {
            get { return this._explanation; }
            set
            {
                if (value == null)
                {
                    throw new NullExplanation("Explanation was null");
                }
                else
                {
                    this._explanation = value;
                }
            }
        }

        [DataMember]
        private Premise _premise;
        public Premise Premise
        {
            get { return this._premise; }
            set
            {
                if (value == null)
                {
                    throw new NullPremise("Premise was null");
                }
                _premise = value;
            }
        }

        [DataMember]
        private SingleFact _conclusion;
        public SingleFact Conclusion
        {
            get { return this._conclusion; }
            set
            {
                if (value == null)
                {
                    throw new NullConclusion("Conclusion was null");
                }
                _conclusion = value;
            }
        }

        public Rule(string name, Premise premise, SingleFact conclusion)
        {
            Name = name;
            Premise = premise;
            Conclusion = conclusion;
        }

        public Rule(string name, string explanation, Premise premise, SingleFact conclusion)
        {
            Name = name;
            Explanation = explanation;
            Premise = premise;
            Conclusion = conclusion;
        }

        public string GenerateExplanation()
        {
            string explanation = "Если ";
            foreach (Fact fact in Premise.Facts)
            {
                explanation += fact.PremiseToString();
                if (Premise.FactOperator == FactOperator.Сonjunction)
                {
                    explanation += " И ";
                }
                else
                {
                    explanation += " ИЛИ ";

                }
            }

            if (Premise.FactOperator == FactOperator.Сonjunction)
            {
                explanation = explanation.Substring(0, explanation.Length - 3);
            }
            else
            {
                explanation = explanation.Substring(0, explanation.Length - 5);

            }
            explanation += ", ТО " + Conclusion.Variable.Name + " = " + Conclusion.Value.Value;
            return explanation;
        }

    }
}
