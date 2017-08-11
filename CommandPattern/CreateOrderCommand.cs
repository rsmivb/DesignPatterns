using System;

namespace CommandPattern
{
    internal class CreateOrderCommand : ICommand, ICommandFactory
    {
        public int NewQuantity { get; set; }

        public string CommandName { get { return "CreateOrderCommand"; } }

        public string Description { get { return "CreateOrderCommand number"; } }

        public void Execute()
        {
            const int oldQuantity = 5;
            Console.WriteLine($"LOG: CreateOrderCommand value {oldQuantity} to {NewQuantity}");
        }

        ICommand ICommandFactory.MakeCommand(string[] arguments)
        {
            return new CreateOrderCommand { NewQuantity = int.Parse(arguments[2]) };
        }
    }
}