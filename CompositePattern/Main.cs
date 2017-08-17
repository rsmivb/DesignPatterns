using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class Main
    {
        public void Run()
        {
            int goldForKill = 1023;
            Console.WriteLine($"You have killed the Giant IE6 Mosnter and gained {goldForKill} pieces of gold!");

            var joe = new Person { Name = "Joe" };
            var jake = new Person { Name = "Jake" };
            var emily = new Person { Name = "Emily" };
            var sophia = new Person { Name = "Sophia" };
            var brian = new Person { Name = "Brian" };
            var newBob = new Person { Name = "New Bob" };
            var oldBob = new Person { Name = "Old Bob" };

            var bobs = new Group { Members = { newBob, oldBob } };
            var developers = new Group { Name = "Developers", Members = { joe, jake, emily, bobs } };
            var parties = new Group { Members = { brian, sophia, developers } };

            parties.Gold += goldForKill;
            parties.Stats();
            /*
            var totalToSplitBy = parties.Count;
            var amountForEach = goldForKill / totalToSplitBy;
            var leftOver = goldForKill % totalToSplitBy;

            foreach (var member in parties)
            {
                member.Gold += amountForEach + leftOver;
                leftOver = 0;
                member.Stats();
            }
            */


        }
    }
}
