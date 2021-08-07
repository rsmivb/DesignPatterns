namespace FactoryPattern
{
    public class BMW335XiFactory : IAutoFactory
    {
        public IAuto CreateAutomobile() =>  new BMW335Xi();
    }
}
