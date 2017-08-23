using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class MySandwichBuilder : SandwichBuilder
    {
        public override void AddCondiments()
        {
            sandwich.HasCatchup = true;
            sandwich.HasMayo = false;
            sandwich.HasMustard = true;
        }

        public override void ApplyVegetable()
        {
            sandwich.Vegetables = new List<string>()
            {
                "Tomato", "Lettuce"
            };
        }

        public override void ApplyMeatAndCheese()
        {
            sandwich.MeatType = MeatType.Sausage;
            sandwich.CheeseType = CheeseType.Swiss;
        }

        public override void PrepareBread()
        {
            sandwich.BreadType = BreadType.White;
        }
    }
}
