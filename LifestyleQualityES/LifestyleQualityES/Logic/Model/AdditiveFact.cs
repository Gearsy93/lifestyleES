using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace LifestyleQualityES.Model
{
    [DataContract]
    internal class AdditiveFact : Fact
    {
        [DataMember]
        private List<Variable> _variables;
        public List<Variable> Variables
        {
            get { return _variables; }
            set
            {
                if (value == null)
                {
                    throw new NullVariableList("Variable list of additive fact is null");
                }
                if (Value != null && value.Count == 0)
                {
                    throw new EmptyAssignedFact("List of variables in assigned fact can't be empty");
                }
                foreach (Variable v in value) 
                {
                    if (v.Domain.IsNumeric == false)
                    {
                        throw new AdditiveVarialbeNotNumeric("Fact additive variable is not numeric");
                    }
                }
                _variables = value;
            }
        }

        [DataMember]
        private NumericDomainValue _value;
        public NumericDomainValue Value
        {
            get { return _value; }
            set
            {
                if (value == null)
                {
                    throw new NullFactValue("Fact Value was null");
                }
                else if (Variables != null && Variables.Count != 0)
                {
                    if (value.Domain.IsNumeric == false)
                    {
                        throw new FactDomainMistype("Domain of additive variable must be numeric");
                    }
                    else
                    {
                        _value = value;
                    }
                }
                else
                {
                    throw new NullVariableList("Can't assign to null or empty variable list");
                }
            }
        }

        public void AddVariable(Variable variable)
        {
            if (variable.Domain.GetType() != typeof(NumericDomainValue))
            {
                throw new AdditiveVarialbeNotNumeric("Fact additive variable is not numeric");
            }
            if (Variables.Contains(variable))
            {
                throw new DublicatedItem("Variable already exists in fact variables list");
            }
            Variables.Add(variable);
        }

        public bool RemoveVariable(Variable variable)
        {
            return Variables.Remove(variable);
        }

        public AdditiveFact(List<Variable> variables, NumericDomainValue value)
        {
            Variables = variables;
            Value = value;
        }

        public AdditiveFact(List<Variable> variables)
        {
            Variables = variables;
            Value = null;
        }

        public AdditiveFact()
        {
            Variables = new List<Variable>();
            Value = null;
        }

        public bool ifDefined()
        {
            return (Value != null);
        }

        public DomainValue GetValue()
        {
            return Value ?? null;
        }

        public string PremiseToString()
        {
            string s = "";
            foreach (var variable in Variables) 
            {
                s += variable.Name + " + ";
            }
            if (Variables.Count > 0)
            {
                s = s.Substring(0, s.Length - 3);
            }
            s += " = " + Value.Value;
            return s;
        }
    }
}
