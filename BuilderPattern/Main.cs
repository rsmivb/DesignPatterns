using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Main
    {
        public void Run()
        {
            var sandwichMaker = new SandwichMaker(new MySandwichBuilder());
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
