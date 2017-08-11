using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class CompositeClient
    {
        public void RunComposite()
        {
            var rafael = new Employee { Name = "Rafael" };
            var william = new Employee { Name = "William" };
            var john = new Employee { Name = "John" };
            var employeeGroup = new Group { Name = "Devs", Members = new List<IParty> { rafael, william } };

            var allEmployees = new List<IParty> { employeeGroup, john };

            foreach (var employee in allEmployees)
            {
                employee.ShowSalary();
            }
        }
    }
}
