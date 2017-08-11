namespace CommandPattern
{
    public interface ICommandFactory
    {
        string CommandName { get; }
        string Description { get; }

        ICommand MakeCommand(string[] arguments);
    }
}