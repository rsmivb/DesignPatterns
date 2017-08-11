using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class UpdateQuantityCommand : ICommand, ICommandFactory
    {
        public int NewQuantity { get; set; }

        public string CommandName { get { return "UpdateQuantity"; } }

        public string Description { get { return "UpdateQuantity number"; } }

        public void Execute()
        {
            const int oldQuantity = 5;
            Console.WriteLine($"LOG: Update value {oldQuantity} to {NewQuantity}");
        }

        ICommand ICommandFactory.MakeCommand(string[] arguments)
        {
            return new UpdateQuantityCommand { NewQuantity = int.Parse(arguments[1]) };
        }
    }
}
