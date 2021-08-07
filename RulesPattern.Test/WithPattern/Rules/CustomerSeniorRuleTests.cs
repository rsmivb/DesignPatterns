using RulesPattern.Model;
using RulesPattern.PatternApplied;
using System;
using System.Collections.Generic;
using Xunit;

namespace RulesPattern.Test.PatternApplied.Rules
{
    public class CustomerSeniorRuleTests
    {
        private readonly IDiscountRule _customerSeniorRule;

        public CustomerSeniorRuleTests()
        {
            _customerSeniorRule = new CustomerSeniorRule();
        }

        [Theory(DisplayName = "Apply 5% Discount When Customer is Senior (BirthDate > 65) - 001")]
        [Trait("Rules", "Pattern")]
        [MemberData(nameof(CustomerSeniorDataTest))]
        public void GivenCustomerCalculateSeniorDiscountTest(Customer customer, decimal expected)
        {
            decimal current = _customerSeniorRule.Calculate(customer);
            Assert.Equal(expected, current);
        }

        public static IEnumerable<object[]> CustomerSeniorDataTest =>
            new List<object[]>
            {
                new object[] { new Customer { BirthDate = DateTime.Now.AddYears(-30) }, 0 },
                new object[] { new Customer { BirthDate = DateTime.Now.AddYears(-66) }, .05m }
            };
    }
}
