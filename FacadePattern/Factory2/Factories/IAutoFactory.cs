using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Factory2
{
    public interface IAutoFactory
    {
        IAuto CreateAutomobile();

        // Another types of car can been created
        //IAuto CreateSportsCar();
        //IAuto CreateLuxCar();
        //IAuto CreateStandardCar();
    }
}
