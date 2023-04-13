using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace LifestyleQualityES.Model
{
    [ServiceContract]
    interface Fact
    {
        [OperationContract]
        bool ifDefined();

        [OperationContract]
        DomainValue GetValue();

        [OperationContract]
        string PremiseToString();
    }
}
