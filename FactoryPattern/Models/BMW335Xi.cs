using System;
using System.Collections.Generic;

namespace FactoryPattern
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

        public override bool Equals(object obj)
        {
            return obj is BMW335Xi xi &&
                   Name == xi.Name;
        }

        public override int GetHashCode()
        {
            return 539060726 + EqualityComparer<string>.Default.GetHashCode(Name);
        }
    }
}
