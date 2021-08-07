using RulesPattern.Model;
using RulesPattern.PatternApplied;
using System;
using Xunit;

namespace RulesPattern.Test
{
    public class CalculatorDiscountWithPatternServiceTests
    {
        private ICalculateDiscountService _service;

        [Fact(DisplayName = "Apply 0% Discount  - Customer no rules - 000")]
        [Trait("Rules", "Pattern")]
        public void ShouldReturnZeroDiscountTest()
        {
            var customer = new Customer
            {
                BirthDate = DateTime.Now.AddDays(-1),
                IsVeteran = false,
                DateOfFirstPurchase = DateTime.Now
            };
            var expected = 0;
            _service = new CalculateDiscountWithPatternService();

            var current = _service.CalculateDiscount(customer);

            Assert.Equal(expected, current);
        }
    }
}
