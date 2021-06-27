using RulesPattern.Model;

namespace RulesPattern.PatternApplied
{
    public interface IDiscountRule
    {
        decimal Calculate(Customer customer);
    }
}
