using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcreteComponents
{
    public class MediumPizza : Pizza
    {
        public MediumPizza()
        {
            Description = "Medium Pizza";
        }
        public override double CalculateCost()
        {
            return 5.00;
        }

        public override string GetDescription()
        {
            return Description;
        }
    }
}
