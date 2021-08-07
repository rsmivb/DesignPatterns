using System;
using System.Collections.Generic;

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

        public override bool Equals(object obj)
        {
            return obj is MiniCooper cooper &&
                   Name == cooper.Name;
        }

        public override int GetHashCode()
        {
            return 539060726 + EqualityComparer<string>.Default.GetHashCode(Name);
        }
    }
}
