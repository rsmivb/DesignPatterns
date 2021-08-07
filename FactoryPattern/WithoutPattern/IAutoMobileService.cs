namespace FactoryPattern
{
    public interface IAutoMobileService
    {
        IAuto GetCar(string carName);
    }
}