using System;
using System.Collections.Generic;

namespace CompositePattern
{
    public class Employee : IParty
    {
        public string Name { get; set; }
        public IList<IParty> Members { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void ShowSalary()
        {
            throw new NotImplementedException();
        }
    }
}