using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Data;

namespace LifestyleQualityES.Model
{
    [DataContract]
    internal class KnowledgeBase
    {
        [DataMember]
        private List<Domain> _domains;
        public List<Domain> Domains
        {
            get { return _domains; }
            set
            {
                if (value == null)
                {
                    throw new NullDomainList("List of domains was null");
                }
                _domains = value;
            }
        }

        [DataMember]
        private List<Variable> _variables;
        public List<Variable> Variables
        {
            get { return _variables; }
            set 
            {
                if (value == null)
                {
                    throw new NullVariableList("List of variables was null");
                }
                _variables = value;
            }
        }

        [DataMember]
        private List<Rule> _rules;
        public List<Rule> Rules
        {
            get { return _rules; }
            set
            {
                if (value == null)
                {
                    throw new NullRuleList("List of rules was null");
                }
                _rules = value;
            }
        }

        public KnowledgeBase(List<Domain> domains, List<Variable> variables, List<Rule> rules)
        {
            Domains = domains;
            Variables = variables;
            Rules = rules;
        }

        public KnowledgeBase()
        {
            Domains = new List<Domain>();
            Variables = new List<Variable>();
            Rules = new List<Rule>();
        }

        public Domain GetDomainByName(string name)
        {
            foreach (Domain domain in Domains)
            {
                if (domain.Name == name) return domain;
            }
            return null;
        }
    }
}
