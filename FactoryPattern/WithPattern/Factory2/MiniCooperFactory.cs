namespace FactoryPattern
{
    public class MiniCooperFactory : IAutoFactory
    {
        public IAuto CreateAutomobile() => new MiniCooper()
    }
}
