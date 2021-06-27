using RulesPattern.Model;
using System;

namespace RulesPattern.PatternApplied
{
    public class CustomerBirthDateRule : IDiscountRule
    {
        public decimal Calculate(Customer customer)
        {
            // if customer BirthDate is buying when is BirthDay apply 10%
            return (customer.BirthDate.Day == DateTime.Now.Day &&
                customer.BirthDate.Month == DateTime.Now.Month) ? 0.1m : 0;
        }
    }
}
