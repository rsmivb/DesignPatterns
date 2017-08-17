using System;
using System.Collections.Generic;

namespace CompositePattern
{
    internal class Group : IParty
    {
        public string Name { get; set; }
        public IList<IParty> Members { get; set; }
        public int Gold {
            get
            {
                int totalGold = 0;
                foreach (var member in Members)
                {
                    totalGold += member.Gold;
                }
                return totalGold;
            }
            set
            {
                var eachSplit = value / Members.Count;
                var leftOver = value % Members.Count;
                foreach (var member in Members)
                {
                    member.Gold += eachSplit + leftOver;
                    leftOver = 0;
                }
            } }

        public Group()
        {
            Members = new List<IParty>();
        }
        public void Stats()
        {
            foreach (var member in Members)
            {
                member.Stats();
            }
        }
    }
}