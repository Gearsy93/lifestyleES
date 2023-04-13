using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace LifestyleQualityES.Model
{
    [DataContract]
    internal class AskedVariable : Variable
    {
        [DataMember]
        private string _question;
        public string Question
        {
            get { return _question; }
            set
            {
                if (value == null)
                {
                    throw new NullVariableQuesion("Varialbe quesion was null");
                }
                else
                {
                    this._question = value;
                }
            }
        }

        public AskedVariable(string name, Domain domain, string question) : base(name, domain)
        {
            Question = question;
        }
    }
}
