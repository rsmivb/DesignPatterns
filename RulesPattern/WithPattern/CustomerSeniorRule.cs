using RulesPattern.Model;
using System;

namespace RulesPattern.PatternApplied
{
    public class CustomerSeniorRule : IDiscountRule
    {
        public decimal Calculate(Customer customer)
        {
            // senior discount 5%
            return (customer.BirthDate < DateTime.Now.AddYears(-65)) ? .05m : 0;
        }
    }
}
