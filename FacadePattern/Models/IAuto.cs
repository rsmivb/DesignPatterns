namespace FacadePattern
{
    public interface IAuto
    {
        string Name { get; }
        void TurnOn();
        void TurnOff();
    }
}