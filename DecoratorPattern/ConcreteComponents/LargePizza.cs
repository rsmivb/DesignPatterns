using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcreteComponents
{
    public class LargePizza : Pizza
    {
        public LargePizza()
        {
            Description = "Large Pizza";
        }
        public override double CalculateCost()
        {
            return 7.00;
        }

        public override string GetDescription()
        {
            return Description;
        }
    }
}
