using System.Collections.Generic;

namespace CompositePattern
{
    public interface IParty
    {
        IList<IParty> Members { get; set; }
        void ShowSalary();
    }
}