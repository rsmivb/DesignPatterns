using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class SandwichMaker
    {
        private readonly SandwichBuilder builder;
        public SandwichMaker(SandwichBuilder builder)
        {
            this.builder = builder;
        }

        public void BuildSandwich()
        {
            builder.CreateNewSandwich();
            builder.AddCondiments();
            builder.ApplyMeatAndCheese();
            builder.ApplyVegetable();
            builder.PrepareBread();
        }

        public Sandwich GetSandwich()
        {
            return builder.GetSandwich();
        }
    }
}
