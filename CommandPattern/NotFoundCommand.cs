using System;

namespace CommandPattern
{
    public class NotFoundCommand : ICommand
    {
        public string Name { get; set; }
        public void Execute()
        {
            Console.WriteLine("Could not find command: " + Name);
        }
    }
}