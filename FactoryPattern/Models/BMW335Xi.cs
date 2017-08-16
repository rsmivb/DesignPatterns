using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class BMW335Xi : IAuto
    {
        public string Name { get; private set; }

        public BMW335Xi()
        {
            Name = "BMW 335Xi";
        }

        public void TurnOff()
        {
            Console.WriteLine($"{Name} is turning On...");
        }

        public void TurnOn()
        {
            Console.WriteLine($"{Name} is turning On...");
        }
    }
}
