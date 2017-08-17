using FactoryPattern.Factory1;
using FactoryPattern.Factory2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Main
    {
        public void Run()
        {
            //run Factory Pattern
            //var carName = "";
            //Real Example without factory
            //IAuto car = GetCar(carName);
            //car.TurnOn();
            //car.TurnOff();

            //   using Simple Factory1
            //AutoFactory factory = new AutoFactory();
            //IAuto car = factory.CreateInstance(carName);
            //car.TurnOn();
            //car.TurnOff();

            // using Factory 2
            IAutoFactory autofactory = LoadFactory();
            IAuto car = autofactory.CreateAutomobile();

            car.TurnOn();
            car.TurnOff();
        }

        private IAutoFactory LoadFactory()
        {
            string factoryName = "BMW355XiFactory";
            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as IAutoFactory;
        }
        /* Using method without factory pattern
static IAuto GetCar(string carName)
{
   switch (carName)
   {
       case "bmw":
           return new BMW335Xi();
       case "mini":
           return new MiniCooper();
       default:
           return new NullCar();
   }
}
*/
    }
}
