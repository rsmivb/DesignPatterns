using RulesPattern.Model;
using System;

namespace RulesPattern.WithoutPattern
{
    // This class has multiples rules to apply discount
    // Every new rule needs to apply in method CalculateDiscount
    // It is breaking the SOLID principle (Open-closed): Open for extension extend closed for modification
    public class CalculatorDiscountNoPatternService : ICalculateDiscountService
    {
        public decimal CalculateDiscount(Customer customer)
        {
            decimal discount = 0;
            // senior discount 5%
            if (customer.BirthDate < DateTime.Now.AddYears(-65))
            {
                discount = .05m;
            }

            // if customer BirthDate is buying when is BirthDay apply 10%
            if (customer.BirthDate.Day == DateTime.Now.Day &&
                customer.BirthDate.Month == DateTime.Now.Month)
            {
                discount = 0.1m;
            }

            // if customer is veteran apply  + 15%
            if (customer.IsVeteran)
            {
                discount = 0.15m;
            }

            if (customer.DateOfFirstPurchase.HasValue)
            {
                // last purchase was 5 Years Old + 2%
                if (customer.DateOfFirstPurchase < DateTime.Now.AddYears(-5))
                {
                    discount = .02m;
                }
            }
            else //customer first purchase apply 5%
            {
                discount = .05m;
            }
            return discount;
        }
    }
}
