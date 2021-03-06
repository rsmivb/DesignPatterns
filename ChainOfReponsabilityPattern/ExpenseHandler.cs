﻿using System;

namespace ChainOfReponsabilityPattern
{
    public class ExpenseHandler : IExpenseHandler
    {
        private readonly IExpenseApprover _approver;
        private IExpenseHandler _next;
        public ExpenseHandler(IExpenseApprover expenseApprover)
        {
            _approver = expenseApprover;
            _next = EndOfChainExpenseHandler.Instance;
        }

        public ApprovalResponse Approve(IExpenseReport expenseReport)
        {
            ApprovalResponse response = _approver.ApprovalExpense(expenseReport);
            if (response == ApprovalResponse.BeyondApprovalLimit)
            {
                return _next.Approve(expenseReport);
            }
            return response;
        }

        public void RegisterNext(IExpenseHandler next)
        {
            _next = next;
        }
    }
    public interface IExpenseHandler
    {
        ApprovalResponse Approve(IExpenseReport expenseReport);
        void RegisterNext(IExpenseHandler next);
    }

}