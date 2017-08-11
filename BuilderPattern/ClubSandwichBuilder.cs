using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class ClubSandwichBuilder : SandwichBuilder
    {
        public override void AddCondiments()
        {
            sandwich.HasCatchup = false;
            sandwich.HasMayo = true;
            sandwich.HasMustard = false;
        }

        public override void ApplyMeatAndCheese()
        {
            sandwich.MeatType = MeatType.Turkey;
            sandwich.CheeseType = CheeseType.Cheddar;
        }

        public override void ApplyVegetable()
        {
            sandwich.Vegetables = new List<string>()
            {
                "Onion", "Tomato"
            };
        }

        public override void PrepareBread()
        {
            sandwich.BreadType = BreadType.Wheat;
        }
    }
}
