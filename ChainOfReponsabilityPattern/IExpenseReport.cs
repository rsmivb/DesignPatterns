using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfReponsabilityPattern
{
    public interface IExpenseReport
    {
        Decimal Total { get; }
    }

    public interface IExpenseApprover
    {
        ApprovalResponse ApprovalExpense(IExpenseReport expenseReport);
    }

    public enum ApprovalResponse
    {
        Denied,
        Approved,
        BeyondApprovalLimit
    }
}
