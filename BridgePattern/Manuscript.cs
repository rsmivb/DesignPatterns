

namespace BridgePattern
{
    public abstract class Manuscript
    {
        protected readonly IFormatter formatter;
    public Manuscript(IFormatter _formatter)
    {
            formatter = _formatter;
    }
    public abstract void Print();
    }
}