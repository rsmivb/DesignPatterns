using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfReponsabilityPattern
{
    public class ExpenseReport : IExpenseReport
    {
        public decimal Total { get; private set; }
        public ExpenseReport(Decimal total)
        {
            Total = total;
        }
    }
}
