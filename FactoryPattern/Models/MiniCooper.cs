using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class MiniCooper : IAuto
    {
        public string Name { get; private set; }

        public MiniCooper()
        {
            Name = "MiniCooper";
        }
        public void TurnOff()
        {
            Console.WriteLine($"{Name} is turning On...");
        }

        public void TurnOn()
        {
            Console.WriteLine($"{Name} is turn off.");
        }
    }
}
