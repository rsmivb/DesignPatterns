using RulesPattern.Model;
using System;

namespace RulesPattern.PatternApplied
{
    public class CustomerDateOfFirstPurchaseRule : IDiscountRule
    {
        public decimal Calculate(Customer customer)
        {
            decimal discount = 0;
            if (customer.DateOfFirstPurchase.HasValue)
            {
                // last purchase was 5 Years Old + 2%
                if (customer.DateOfFirstPurchase < DateTime.Now.AddYears(-5))
                {
                    discount += .02m;
                }
            }
            else //customer first purchase apply 5%
            {
                discount += .05m;
            }
            return discount;
        }
    }
}
