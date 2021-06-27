using RulesPattern.Model;
using RulesPattern.PatternApplied;
using System;
using System.Collections.Generic;
using Xunit;

namespace RulesPattern.Test.PatternApplied.Rules
{
    public class CustomerBirthDateRuleTests
    {
        private readonly IDiscountRule birthDayRule;

        public CustomerBirthDateRuleTests()
        {
            birthDayRule = new CustomerBirthDateRule();
        }

        [Theory(DisplayName = "Apply 10% Discount When Customer Purchase Date is his BirthDay -002")]
        [Trait("CustomerBirthDate", "Rule")]
        [MemberData(nameof(CustomerBirthDateDataTest))]
        public void MyMemberDataTest(Customer customer, decimal expected)
        {
            decimal current = birthDayRule.Calculate(customer);
            Assert.Equal(expected, current);
        }

        public static IEnumerable<object[]> CustomerBirthDateDataTest =>
            new List<object[]>
            {
                new object[] { new Customer { BirthDate = DateTime.Now }, .1m },
                new object[] { new Customer { BirthDate = DateTime.Now.AddDays(-1) }, 0 }
            };
    }
}
