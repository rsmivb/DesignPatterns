using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Model
    {
    }
    public class FAQ : Manuscript
    {
        public FAQ(IFormatter _formatter) : base(_formatter)
        {
        }

        public string Title { get; set; }
        public IDictionary<string,string> Questions { get; set; }

        public override void Print()
        {
            Console.WriteLine(formatter.Format("Title", Title));
            foreach (var question in Questions)
            {
                Console.WriteLine(formatter.Format(question.Key, question.Value));
            }
        }
    }
    public class Book : Manuscript
    {
        public Book(IFormatter _formatter) : base(_formatter)
        {
        }

        public FAQ MyProperty { get; set; }

        public string Title { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }
        public override void Print()
        {
            Console.WriteLine(formatter.Format("Title", Title));
            Console.WriteLine(formatter.Format("Author", Author));
            Console.WriteLine(formatter.Format("Text", Text));
        }
    }
    public class TermPaper : Manuscript
    {
        public TermPaper(IFormatter _formatter) : base(_formatter)
        {
        }
        public string Class { get; set; }
        public string Student { get; set; }
        public string Text { get; set; }
        public string References { get; set; }
        public override void Print()
        {
            Console.WriteLine(formatter.Format("Class", Class));
            Console.WriteLine(formatter.Format("Studen", Student));
            Console.WriteLine(formatter.Format("Text", Text));
            Console.WriteLine(formatter.Format("References", References));
        }
    }
}
