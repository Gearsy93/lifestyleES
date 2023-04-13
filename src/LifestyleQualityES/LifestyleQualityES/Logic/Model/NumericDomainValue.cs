using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace LifestyleQualityES.Model
{
    [ServiceContract]
    interface INumericValue
    {
        [OperationContract]
        double GetDoubleValue();
    }

    [DataContract]
    internal class NumericDomainValue : DomainValue, INumericValue
    {
        public double GetDoubleValue()
        {
            if (_value == null)
            {
                throw new NullNumericDomainValue("Numeric domain value was null");
            }
            else
            {
                try
                {
                    return Convert.ToDouble(_value);
                }
                catch(Exception e)
                {
                    if (e.GetType() == typeof(FormatException))
                    {
                        throw new NotNumericConvertable("Expected numeric value for numeric domain");
                    }
                    else
                    {
                        throw new Exception("Unknown error");
                    }      
                }
            }
        }

        public NumericDomainValue(string value, Domain domain) : base(value, domain) { }
    }
}
