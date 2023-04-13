using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifestyleQualityES.Model
{
    internal class WorkingMemory
    {
        private List<SingleFact> _deducedFacts;
        public List<SingleFact> DeducedFacts
        {
            get { return _deducedFacts; }
        }

        private List<Rule> _usedRules;

        public List<Rule> UsedRules
        {
            get { return _usedRules; }
        }
        private List<Rule> _unusedRules;
        public List<Rule> UnusedRules
        {
            get { return _unusedRules; }
        }

        public WorkingMemory(KnowledgeBase _knowledgeBase)
        {
            _deducedFacts = new List<SingleFact>();
            _usedRules = new List<Rule>();
            _unusedRules = new List<Rule>();
            foreach (Rule rule in _knowledgeBase.Rules)
            {
                _unusedRules.Add(rule);
            }
        }

        public void AddConclusionFact(SingleFact fact)
        {
            _deducedFacts.Add(fact);
        }

        public void AddUsedRule(Rule rule)
        {
            _unusedRules.Remove(rule);
            _usedRules.Add(rule);
        }
    }
}
