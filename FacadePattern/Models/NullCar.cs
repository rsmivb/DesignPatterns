using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class NullCar : IAuto
    {
        public string Name { get; private set; }

        public NullCar()
        {
            Name = "";
        }

        public void TurnOff()
        {
            Console.WriteLine($"car does not exist.");
        }

        public void TurnOn()
        {
            Console.WriteLine($"car does not exist.");
        }
    }
}
