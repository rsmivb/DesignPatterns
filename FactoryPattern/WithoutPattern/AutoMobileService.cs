
namespace FactoryPattern
{
    public class AutoMobileService : IAutoMobileService
    {
        public IAuto GetCar(string carName)
        {
            switch (carName.ToLowerInvariant())
            {
                case "bmw":
                    return new BMW335Xi();
                case "mini":
                    return new MiniCooper();
                default:
                    return new NullCar();
            }
        }
    }
}
