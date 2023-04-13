using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace LifestyleQualityES.Model
{
    [DataContract]
    internal class DeducibleAskedVariable : AskedVariable
    {
        public DeducibleAskedVariable(string name, Domain domain, string question) : base(name, domain, question)
        {
        }
    }
}
