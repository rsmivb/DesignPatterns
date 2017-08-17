using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class Main
    {
        public void Run()
        {
            List<Manuscript> documents = new List<Manuscript>();

            var faq = new FAQ(new StandardFormatter())
            {
                Title = "Lots of Patterns"
            };
            faq.Questions.Add("Question 1", "Is it a Bridge pattern?");
            faq.Questions.Add("Question 2", "What time is it?");

            documents.Add(faq);

            var book = new Book(new ReverseFormatter())
            {
                Title = "Title",
                Author = "MySelf",
                Text = "Some text"
            };

            documents.Add(book);

            var paper = new TermPaper(new FancyFormmater())
            {
                Class = "New Class",
                References = "References",
                Student = "A Student",
                Text = "Some text"
            };
            documents.Add(paper);

            foreach (var doc in documents)
            {
                doc.Print();
            }
        }
    }
}
