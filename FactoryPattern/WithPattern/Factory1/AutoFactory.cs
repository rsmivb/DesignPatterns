using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace FactoryPattern
{
    public class AutoFactory
    {
        private IEnumerable<Type> carTypes;

        public AutoFactory()
        {
            LoadAllCarsTypes();
        }

        private void LoadAllCarsTypes()
        {
            var carType = typeof(IAuto);
            carTypes = Assembly.GetExecutingAssembly().GetTypes().Where(x => x.GetInterfaces().Contains(carType));

        }
        public IAuto GetInstance(string carName)
        {
            var carTypeSelected = carTypes.FirstOrDefault(x => x.Name.Equals(carName)) ?? typeof(NullCar);
            return Activator.CreateInstance(carTypeSelected) as IAuto;
        }
    }
}
