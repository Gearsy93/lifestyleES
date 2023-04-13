using System;
using System.Runtime.Serialization;

namespace LifestyleQualityES.Model
{

    [DataContract]
    public abstract class AbstractException : Exception
    {
        [DataMember]
        public string Value;

        public void GetExceptionClass(string value)
        {
            this.Value = value == null ? this.GetType().Name : value;
        }
    }

    public class NullDomainValue : AbstractException
    {
        public NullDomainValue(string value)
        {
            GetExceptionClass(value);
        }
    }

    public class NullDomainName : AbstractException
    {
        public NullDomainName(string value)
        {
            GetExceptionClass(value);
        }
    }

    public class NullDomainValueName : AbstractException
    {
        public NullDomainValueName(string value)
        {
            GetExceptionClass(value);
        }
    }

    public class NullDomainValueList : AbstractException
    {
        public NullDomainValueList(string value)
        {
            GetExceptionClass(value);
        }
    }

    public class NullNumericDomainValue : AbstractException
    {
        public NullNumericDomainValue(string value)
        {
            GetExceptionClass(value);
        }
    }

    public class NotNumericConvertable : AbstractException
    {
        public NotNumericConvertable(string value)
        {
            GetExceptionClass(value);
        }
    }

    public class NullVariableName : AbstractException
    {
        public NullVariableName(string value)
        {
            GetExceptionClass(value);
        }
    }

    public class NullDomain : AbstractException
    {
        public NullDomain(string value)
        {
            GetExceptionClass(value);
        }
    }

    public class NullDomainValuesList : AbstractException
    {
        public NullDomainValuesList(string value)
        {
            GetExceptionClass(value);
        }
    }

    
    public class NullDomainList : AbstractException
    {
        public NullDomainList(string value)
        {
            GetExceptionClass(value);
        }
    }

    
    public class NullVariableList : AbstractException
    {
        public NullVariableList(string value)
        {
            GetExceptionClass(value);
        }
    }

    
    public class NullFactVariable : AbstractException
    {
        public NullFactVariable(string value)
        {
            GetExceptionClass(value);
        }
    }

    
    public class NullFactValue : AbstractException
    {
        public NullFactValue(string value)
        {
            GetExceptionClass(value);
        }
    }

    
    public class FactDomainMistype : AbstractException
    {
        public FactDomainMistype(string value)
        {
            GetExceptionClass(value);
        }
    }

    
    public class AdditiveVarialbeNotNumeric : AbstractException
    {
        public AdditiveVarialbeNotNumeric(string value)
        {
            GetExceptionClass(value);
        }
    }

    
    public class NullVariable : AbstractException
    {
        public NullVariable(string value)
        {
            GetExceptionClass(value);
        }
    }

    
    public class DublicatedItem : AbstractException
    {
        public DublicatedItem(string value)
        {
            GetExceptionClass(value);
        }
    }

    
    public class NullFactList : AbstractException
    {
        public NullFactList(string value)
        {
            GetExceptionClass(value);
        }
    }

    
    public class NullFact : AbstractException
    {
        public NullFact(string value)
        {
            GetExceptionClass(value);
        }
    }

    
    public class EmptyAssignedFact : AbstractException
    {
        public EmptyAssignedFact(string value)
        {
            GetExceptionClass(value);
        }
    }

    
    public class NullRuleName : AbstractException
    {
        public NullRuleName(string value)
        {
            GetExceptionClass(value);
        }
    }

    
    public class NullExplanation : AbstractException
    {
        public NullExplanation(string value)
        {
            GetExceptionClass(value);
        }
    }

    
    public class NullPremise : AbstractException
    {
        public NullPremise(string value)
        {
            GetExceptionClass(value);
        }
    }

    
    public class NullConclusion : AbstractException
    {
        public NullConclusion(string value)
        {
            GetExceptionClass(value);
        }
    }

    
    public class NullRuleList : AbstractException
    {
        public NullRuleList(string value)
        {
            GetExceptionClass(value);
        }
    }

    
    public class NullVariableQuesion : AbstractException
    {
        public NullVariableQuesion(string value)
        {
            GetExceptionClass(value);
        }
    }

    public class DomainOutOfValue : AbstractException
    {
        public DomainOutOfValue(string value)
        {
            GetExceptionClass(value);
        }
    }

    
    public class NullIsNumeric : AbstractException
    {
        public NullIsNumeric(string value)
        {
            GetExceptionClass(value);
        }
    }

    
    public class UnableCastToNumericDomain : AbstractException
    {
        public UnableCastToNumericDomain(string value)
        {
            GetExceptionClass(value);
        }
    }

    
    public class AddingNonNumericValue : AbstractException
    {
        public AddingNonNumericValue(string value)
        {
            GetExceptionClass(value);
        }
    }
}
