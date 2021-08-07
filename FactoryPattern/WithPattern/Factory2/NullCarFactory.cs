namespace FactoryPattern
{
    public class NullCarFactory : IAutoFactory
    {
        public IAuto CreateAutomobile() =>  new NullCar();
    }
}
