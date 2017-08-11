using System;

namespace CommandPattern
{
    public class NotFoundCommand : ICommand
    {
        public string Name { get; set; }
        public void Execute()
        {
            Console.WriteLine("Couldn't not find command: " + Name);
        }
    }
}