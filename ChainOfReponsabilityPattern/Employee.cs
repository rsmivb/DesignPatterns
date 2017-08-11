using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfReponsabilityPattern
{
    public class Employee : IExpenseApprover
    {
        public string Name { get; set; }

        private readonly decimal _approvalLimit;
        public Employee(string name, decimal approvalLimit)
        {
            Name = name;
            _approvalLimit = approvalLimit;
        }
        public ApprovalResponse ApprovalExpense(IExpenseReport expenseReport)
        {
            return expenseReport.Total > _approvalLimit
                ? ApprovalResponse.BeyondApprovalLimit
                : ApprovalResponse.Approved;
        }
    }
}
