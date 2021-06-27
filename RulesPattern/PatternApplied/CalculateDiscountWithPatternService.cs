using RulesPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RulesPattern.PatternApplied
{
    public class CalculateDiscountWithPatternService : ICalculateDiscountService
    {
        private readonly List<IDiscountRule> _rules = new List<IDiscountRule>();

        public CalculateDiscountWithPatternService(IEnumerable<IDiscountRule> rules)
        {
            _rules.AddRange(rules);
        }
        public CalculateDiscountWithPatternService()
        {
            var ruleType = typeof(IDiscountRule);
            var rulesBasedReflection = this.GetType().Assembly.GetTypes()
                .Where(p => ruleType.IsAssignableFrom(p) && !p.IsInterface)
                .Select(r => Activator.CreateInstance(r) as IDiscountRule).ToList();
            _rules.AddRange(rulesBasedReflection);
        }
        public decimal CalculateDiscount(Customer customer)
        {
            decimal discount = 0;
            foreach (var rule in _rules)
            {
                discount = Math.Max(discount, rule.Calculate(customer));
            }
            return discount;
        }
    }
}
