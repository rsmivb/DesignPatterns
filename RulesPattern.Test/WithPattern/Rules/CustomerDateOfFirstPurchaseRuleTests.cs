using RulesPattern.Model;
using RulesPattern.PatternApplied;
using System;
using System.Collections.Generic;
using Xunit;

namespace RulesPattern.Test.PatternApplied.Rules
{
    public class CustomerDateOfFirstPurchaseRuleTests
    {
        private readonly IDiscountRule customerDateOfFirstPurchaseRule;

        public CustomerDateOfFirstPurchaseRuleTests()
        {
            customerDateOfFirstPurchaseRule = new CustomerDateOfFirstPurchaseRule();
        }

        [Theory(DisplayName = "Apply Discount (0%, 2%, 5%) based on Customer Purchase Date - 004")]
        [Trait("Rules", "Pattern")]
        [MemberData(nameof(CustomerDateOfFirstPurchaseDataTest))]
        public void GivenCustoemrCalculatePurchaseDateDiscountTest(Customer customer, decimal expected)
        {
            decimal current = customerDateOfFirstPurchaseRule.Calculate(customer);
            Assert.Equal(expected, current);
        }

        public static IEnumerable<object[]> CustomerDateOfFirstPurchaseDataTest =>
            new List<object[]>
            {
                new object[] { new Customer { DateOfFirstPurchase = DateTime.Now.AddYears(-1) }, 0 },
                new object[] { new Customer { DateOfFirstPurchase = DateTime.Now.AddYears(-5) }, .02m },
                new object[] { new Customer(), .05m }
            };
    }
}
