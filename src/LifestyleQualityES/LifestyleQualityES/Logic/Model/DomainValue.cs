using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace LifestyleQualityES.Model
{
    [KnownType(typeof(NumericDomainValue))]
    [DataContract]
    internal class DomainValue
    {
        [DataMember]
        protected string _value;

        public string Value
        {
            get { return _value; }
            set
            {
                if (value == null)
                {
                    throw new NullDomainName("Domain value was null");
                }
                else
                {
                    this._value = value;
                }
            }
        }

        [DataMember]
        private Domain _domain;

        public Domain Domain
        {
            get { return this._domain; }
            set
            {
                if (value == null)
                {
                    throw new NullDomainValue("DomainValue Domain was null");
                }
                else this._domain = value;
            }
        }

        public DomainValue(string value, Domain domain)
        {
            this.Value = value;
            this.Domain = domain;
        }
    }
}
