using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LifestyleQualityES.Model
{
    
    [DataContract]
    internal class Domain
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
                    throw new NullDomainValueName("Domain name was null");
                }
                else
                {
                    this._name = value;
                }
            }
        }
        [DataMember]
        private List<DomainValue> _values;

        public List<DomainValue> Values
        {
            get { return _values; }
            set
            {
                if (value == null)
                {
                    throw new NullDomainValuesList("List of domain values was null");
                }
                else
                {
                    this._values = value;
                }
            }
        }
        [DataMember]
        private bool _isNumeric;
        public bool IsNumeric
        {
            get { return _isNumeric; }
            set
            {
                if (value == true)
                {
                    foreach (var domainValue in Values)
                    {
                        if (domainValue.GetType() != typeof(NumericDomainValue))
                        {
                            throw new UnableCastToNumericDomain("Domain contains non-numeric values");
                        }
                    }
                }
                this._isNumeric = value;
            }
        }

        public Domain(string name, bool isNumeric)
        {
            this.Name = name;
            this.Values = new List<DomainValue>();
            this.IsNumeric = isNumeric;
        }
        
        public void AddDomainValue(DomainValue domainValue)
        {
            if (IsNumeric)
            {
                if (domainValue.GetType() != typeof(NumericDomainValue))
                {
                    throw new AddingNonNumericValue("This domain contains only numeric values");
                }
            }
            this._values.Add(domainValue); 
        }

        public bool RemoveDomainValue(DomainValue domainValue)
        {
            return this._values.Remove(domainValue);
        }

        public DomainValue GetValueByString(string value)
        {
            foreach (DomainValue domainValue in this.Values) 
            {
                if (domainValue.Value == value)
                {
                    return domainValue;
                }
            }
            throw new DomainOutOfValue("Домен не содержит данное значение");

        }
    }
}
