using DecoratorPattern.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcreteDecorators
{
    public class Pepper : PizzaDecorator
    {
        public Pepper(Pizza pizza) : base(pizza)
        {
            Description = "Pepper";
        }

        public override string GetDescription()
        {
            return $"{_pizza.GetDescription()}, {Description}";
        }

        public override double CalculateCost()
        {
            return _pizza.CalculateCost() + 3.25;
        }
    }
}
