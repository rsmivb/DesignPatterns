using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class CommandProgramClient
    {
        public void Run(string[] args)
        {

            var availableCommands = GetAvailableCommands();

            if(args.Length == 0)
            {
                PrintUsage(availableCommands);
                return;
            }

            var parser = new CommandParser(availableCommands);
            var command = parser.ParseCommand(args);
            command.Execute();
        }

        private static void PrintUsage(IEnumerable<ICommandFactory> availableCommands)
        {
            Console.WriteLine("Usage: Logging demo Arguments.");
            Console.WriteLine("Commands!");
            foreach (var command in availableCommands)
            {
                Console.WriteLine($" {command.Description}");
            }
        }

        public IEnumerable<ICommandFactory> GetAvailableCommands()
        {
            return new ICommandFactory[]
            {
                new CreateOrderCommand(),
                new UpdateQuantityCommand(),
                new ShipOrderCommand()
            };
        }

    }
}
