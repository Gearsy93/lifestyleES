using System.Runtime.Serialization;

namespace LifestyleQualityES.Model
{
    [KnownType(typeof(AskedVariable))]
    [KnownType(typeof(DeducibleVariable))]
    [KnownType(typeof(DeducibleAskedVariable))]
    [DataContract]
    abstract class Variable
    {
        [DataMember]
        private string _name;
        public string Name 
        { 
            get { return _name; } 
            set
            {
                if (value == null)
                {
                    throw new NullVariableName("Varialbe name was null");
                }
                else
                {
                    this._name = value;
                }
            }
        }

        [DataMember]
        private Domain _domain;
        public Domain Domain
        {
            get { return _domain; }
            set 
            {
                if (value == null)
                {
                    throw new NullDomain("Variable domain was null");
                }
                else
                {
                    this._domain = value;
                }
            }
        }

        public Variable(string name, Domain domain)
        {
            this.Name = name;
            this.Domain = domain;
        }
    }
}
