using System;
using System.Collections.Generic;

namespace CompositePattern
{
    public class Group : IParty
    {
        public string Name { get; set; }
        public IList<IParty> Members { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Group()
        {

        }
        public void ShowSalary()
        {
            throw new NotImplementedException();
        }
    }
}