using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LifestyleQualityES.Model
{
    [DataContract]
    internal class SingleFact : Fact
    {
        [DataMember]
        private Variable _variable;
        public Variable Variable
        {
            get { return _variable; }
            set
            {
                if (value == null)
                {
                    throw new NullFactVariable("Fact variable was null");
                }
                else if (Value != null)
                {
                    if (Value.Domain != Variable.Domain)
                    {
                        throw new FactDomainMistype("Variable and value domains don't match");
                    }
                    else
                    {
                        _variable = value;
                    }
                }
                else
                {
                    _variable = value;
                }
            }
        }

        [DataMember]
        private DomainValue _value;
        public DomainValue Value
        {
            get { return _value; }
            set
            {
                if (value == null)
                {
                    throw new NullFactValue("Fact Value was null");
                }
                else if (Variable != null)
                {
                    if (value.Domain != Variable.Domain)
                    {
                        throw new FactDomainMistype("Variable and value domains don't match");
                    }
                    else
                    {
                        _value = value;
                    }
                }
                else
                {
                    throw new NullVariable("Can't assigne null variable");
                }
            }
        }

        public SingleFact(Variable variable, DomainValue value)
        {
            this.Variable = variable;
            this.Value = value;
        }

        public SingleFact(Variable variable)
        {
            this.Variable = variable;
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
            return Variable.Name + " = " + Value.Value.ToString();
        }
    }
}
