using RulesPattern.Model;
using RulesPattern.PatternApplied;
using System.Collections.Generic;
using Xunit;

namespace RulesPattern.Test.PatternApplied.Rules
{
    public class CustomerVeteranRuleTests
    {
        private readonly IDiscountRule _customerIsVeteranRule;

        public CustomerVeteranRuleTests()
        {
            _customerIsVeteranRule = new CustomerVeteranRule();
        }

        [Theory(DisplayName = "Apply Discount 15% if Customer is Veteran - 003")]
        [Trait("CustomerIsVeteran", "Rule")]
        [MemberData(nameof(DataTest))]
        public void MyMemberDataTest(Customer customer, decimal expected)
        {
            var current = _customerIsVeteranRule.Calculate(customer);
            Assert.Equal(expected, current);
        }

        public static IEnumerable<object[]> DataTest =>
            new List<object[]>
            {
                new object[] { new Customer { IsVeteran= true }, 0.15m },
                new object[] { new Customer(), 0 }
            };
    }
}
