using RulesPattern.Model;

namespace RulesPattern.PatternApplied
{
    public class CustomerVeteranRule : IDiscountRule
    {
        public decimal Calculate(Customer customer)
        {
            // if customer is veteran apply  + 15%
            return customer.IsVeteran ? 0.15m : 0;
        }
    }
}
