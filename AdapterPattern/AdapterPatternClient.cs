using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class AdapterPatternClient
    {
        public static void Main()
        {
            // Run Adapter Pattern
            var MyRenderer = new PatternRenderer();

            var myList = new List<Pattern>()
            {
                new Pattern (){ Id = 1, Name = "Adapter test 1", Description = "Description Test 1"},
                new Pattern (){ Id = 2, Name = "Adapter test 2", Description = "Description Test 2"}
            };

            string result = MyRenderer.ListPatterns(myList);
        }
    }
}
