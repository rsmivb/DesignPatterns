using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class BuilderPatternClient
    {
        public static void Main()
        {
            var sandwichMaker = new SandwichMaker(new MySandiwchBuilder());
            sandwichMaker.BuildSandwich();
            var sandwich = sandwichMaker.GetSandwich();
            sandwich.Display();

            var sandwichMaker1 = new SandwichMaker(new ClubSandwichBuilder());
            sandwichMaker1.BuildSandwich();
            var sandwich2 = sandwichMaker1.GetSandwich();
            sandwich2.Display();
        }
    }
}
