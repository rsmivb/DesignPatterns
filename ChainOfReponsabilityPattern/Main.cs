using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfReponsabilityPattern
{
    public class Main
    {
        public void Run()
        {
            ExpenseHandler william = new ExpenseHandler(new Employee("William Worker", Decimal.Zero));
            ExpenseHandler mary = new ExpenseHandler(new Employee("Mary Manager", new Decimal(1000)));
            ExpenseHandler victor = new ExpenseHandler(new Employee("Victor VP", new Decimal(5000)));
            ExpenseHandler paula = new ExpenseHandler(new Employee("Paula President", new decimal(20000)));

            william.RegisterNext(mary);
            mary.RegisterNext(victor);
            victor.RegisterNext(paula);
            Decimal expenseReportAmount;
            if (ConsoleInput.TryReadDecimal("Input Expense Amount Report: ",out expenseReportAmount))
            {
                IExpenseReport expense = new ExpenseReport(expenseReportAmount);

                ApprovalResponse response = william.Approve(expense);

                Console.WriteLine($"The request was {response}");
            }
            /*
            IEnumerable <Employee> managers = new List<Employee>()
            {
                new Employee("William Worker",Decimal.Zero),
                new Employee("Mary Manager",new Decimal(1000)),
                new Employee("Victor VP",new Decimal(5000)),
                new Employee("Paula President",new decimal(20000))
            };
            Decimal expenseReportAmount;
            while (Console.ReadLine())
            {
                IExpenseReport expense = new ExpenseReport(expenseReportAmount);
                bool expenseProcessed = false;

                foreach (Employee approver in managers)
                {
                    ApprovalResponse response = approver.ApprovalExpense(expense);
                    if (response != ApprovalResponse.BeyondApprovalLimit)
                    {
                        Console.WriteLine($"The request was {response}");
                        expenseProcessed = true;
                        break;
                    }
                }
                if (!expenseProcessed)
                {
                    Console.WriteLine("No one was able to approve your expense.");
                }
            }
            */
        }
    }
}
