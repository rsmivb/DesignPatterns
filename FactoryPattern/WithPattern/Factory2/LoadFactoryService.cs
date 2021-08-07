using System.Linq;
using System.Reflection;
namespace FactoryPattern
{
    public class LoadFactoryService
    {
        private readonly string defaultFactory = "FactoryPattern.NullCarFactory";
        public IAutoFactory LoadFactory(string factoryName)
        {
            var fullQualifyName =  Assembly.GetExecutingAssembly().DefinedTypes.FirstOrDefault(x => x.FullName.Contains(factoryName))?.FullName ?? defaultFactory;

            return Assembly.GetExecutingAssembly().CreateInstance(fullQualifyName) as IAutoFactory;
        }
    }
}
