using System;
using System.Collections.Generic;

namespace FactoryPattern
{
    public class NullCar : IAuto
    {
        public string Name { get; private set; }

        public NullCar()
        {
            Name = string.Empty;
        }

        public void TurnOff()
        {
            Console.WriteLine($"car does not exist.");
        }

        public void TurnOn()
        {
            Console.WriteLine($"car does not exist.");
        }

        public override bool Equals(object obj)
        {
            return obj is NullCar car &&
                   Name == car.Name;
        }

        public override int GetHashCode()
        {
            return 539060726 + EqualityComparer<string>.Default.GetHashCode(Name);
        }
    }
}
