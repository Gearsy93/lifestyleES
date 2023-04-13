using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace LifestyleQualityES.Model
{
    [DataContract]
    enum FactOperator : byte
    {
        [EnumMember]
        Сonjunction,
        [EnumMember]
        Disjunction
    }

    [KnownType(typeof(SingleFact))]
    [KnownType(typeof(AdditiveFact))]
    [DataContract]
    internal class Premise
    {
        [DataMember]
        private List<Fact> _facts;
        public List<Fact> Facts 
        { 
            get { return _facts; }
            set
            {
                if (value == null)
                {
                    throw new NullFactList("List of facts was null");
                }
                _facts = value;
            }
        }

        public void AddFact(Fact fact)
        {
            if (fact == null)
            {
                throw new NullFact("Fact was null");
            }
            Facts.Add(fact);
        }

        public bool RemoveFact(Fact fact)
        {
            return Facts.Remove(fact);
        }

        [DataMember]
        private FactOperator _factOperator;
        public FactOperator FactOperator
        {
            get { return _factOperator; }
            set { _factOperator = value; }
        }

        public Premise(List<Fact> facts, FactOperator factOperator)
        {
            Facts = facts;
            FactOperator = factOperator;
        }

        public Premise(FactOperator factOperator)
        {
            FactOperator = factOperator;
            Facts = new List<Fact>();
        }
    }
}
