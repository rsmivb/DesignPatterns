using System;

namespace CommandPattern
{
    internal class ShipOrderCommand : ICommand, ICommandFactory
    {
        public int NewQuantity { get; set; }

        public string CommandName { get { return "ShipOrderCommand"; } }

        public string Description { get { return "ShipOrderCommand number"; } }

        public void Execute()
        {
            const int oldQuantity = 5;
            Console.WriteLine($"LOG: ShipOrderCommand value {oldQuantity} to {NewQuantity}");
        }

        ICommand ICommandFactory.MakeCommand(string[] arguments)
        {
            return new ShipOrderCommand { NewQuantity = int.Parse(arguments[0]) };
        }
    }
}