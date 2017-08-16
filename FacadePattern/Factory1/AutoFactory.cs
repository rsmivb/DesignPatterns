using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Factory1
{
    /// <summary>
    /// Simple factory using reflections
    /// </summary>
    public class AutoFactory
    {
        Dictionary<string, Type> autos;

        public AutoFactory()
        {
            LoadTypesICanReturn();
        }

        private void LoadTypesICanReturn()
        {
            autos = new Dictionary<string, Type>();
            Type[] typesinThisAssembly = Assembly.GetExecutingAssembly().GetTypes();
            foreach (Type type in typesinThisAssembly)
            {
                autos.Add(type.Name.ToLower(), type);
            }
        }

        internal IAuto CreateInstance(string carName)
        {
            Type t = GetTypeToCreate(carName);
            if (t == null) return new NullCar();

            return Activator.CreateInstance(t) as IAuto;
        }

        Type GetTypeToCreate(string carName)
        {
            foreach (var auto in autos)
            {
                if (auto.Key.Contains(carName))
                {
                    return autos[auto.Key];
                }
            }
            return null;
        }
    }
}
