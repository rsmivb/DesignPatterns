using DecoratorPattern.ConcreteComponents;
using DecoratorPattern.ConcreteDecorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class DecoratorRun
    {
        public void Main()
        {
            Pizza pizzaLarge = new LargePizza();
            pizzaLarge = new Cheese(pizzaLarge);
            pizzaLarge = new Ham(pizzaLarge);
            pizzaLarge = new Pepper(pizzaLarge);

            Console.WriteLine(pizzaLarge.GetDescription());
            Console.WriteLine($"Cost: {pizzaLarge.CalculateCost()}");
            Console.ReadKey();
        }
    }
}
