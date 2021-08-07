namespace FactoryPattern
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
