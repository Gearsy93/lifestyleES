using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace LifestyleQualityES.Model
{
    [DataContract]
    internal class DeducibleVariable : Variable
    {
        public DeducibleVariable(string name, Domain domain) : base(name, domain) { }
    }
}
