using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public abstract class SandwichBuilder
    {
        protected Sandwich sandwich;
        public Sandwich GetSandwich()
        {
            return sandwich;
        }
        public void CreateNewSandwich()
        {
            sandwich = new Sandwich();
        }
        public abstract void AddCondiments();
        public abstract void ApplyMeatAndCheese();
        public abstract void ApplyVegetable();
        public abstract void PrepareBread();
    }
}
