using RulesPattern.Model;
using RulesPattern.WithoutPattern;
using System;
using Xunit;

namespace RulesPattern.Test.WithoutPattern
{
    public class CalculatorDiscountWithoutPatternServiceTests
    {
        private readonly CalculatorDiscountNoPatternService _service;

        public CalculatorDiscountWithoutPatternServiceTests()
        {
            _service = new CalculatorDiscountNoPatternService();
        }

        [Fact(DisplayName = "Apply 0% Discount  - Customer no rules - 000")]
        [Trait("CalculateDiscount", "Service")]
        public void ShouldReturnZeroDiscountTest()
        {
            var customer = new Customer
            {
                BirthDate = DateTime.Now.AddDays(-1),
                IsVeteran = false,
                DateOfFirstPurchase = DateTime.Now
            };
            var expected = 0;
            var current = _service.CalculateDiscount(customer);
            Assert.Equal(expected, current);
        }

        [Fact(DisplayName = "Apply 5% Discount When Customer is Senior (BirthDate > 65) - 001")]
        [Trait("CalculateDiscount", "Service")]
        public void ShouldDiscountis5PercentTest()
        {
            var customer = new Customer
            {
                BirthDate = DateTime.Now.AddYears(-66).AddDays(-1),
                IsVeteran = false,
                DateOfFirstPurchase = DateTime.Now
            };
            var expected = .05m;
            var current = _service.CalculateDiscount(customer);
            Assert.Equal(expected, current);
        }

        [Fact(DisplayName = "Apply 10% Discount When Customer Purchase Date is his BirthDay - 002")]
        [Trait("CalculateDiscount", "Service")]
        public void ShouldCalculateDiscountWhenDateIsBirthDayTest()
        {
            var customer = new Customer
            {
                BirthDate = DateTime.Now,
                IsVeteran = false,
                DateOfFirstPurchase = DateTime.Now
            };
            var expected = .1m;
            var current = _service.CalculateDiscount(customer);
            Assert.Equal(expected, current);
        }

        [Fact(DisplayName = "Apply Discount 15% if Customer is Veteran - 003")]
        [Trait("CalculateDiscount", "Service")]
        public void ShouldCalculateDiscountWhenCustomerIsVeteranTest()
        {
            var customer = new Customer
            {
                BirthDate = DateTime.Now.AddDays(-1),
                IsVeteran = true,
                DateOfFirstPurchase = DateTime.Now
            };
            var expected = .15m;
            var current = _service.CalculateDiscount(customer);
            Assert.Equal(expected, current);
        }

        [Fact(DisplayName = "Apply Discount 2% based on Customer Purchase Date - 004")]
        [Trait("CalculateDiscount", "Service")]
        public void ShouldCalculateDiscountWhenCustomerFirstPurchaseIs5YearsOldTest()
        {
            var customer = new Customer
            {
                BirthDate = DateTime.Now.AddDays(-1),
                DateOfFirstPurchase = DateTime.Now.AddYears(-5)
            };
            var expected = .02m;
            var current = _service.CalculateDiscount(customer);
            Assert.Equal(expected, current);
        }

        [Fact(DisplayName = "Apply Discount 5% based on Customer Purchase Date - 004")]
        [Trait("CalculateDiscount", "Service")]
        public void ShouldCalculateDiscountWhenCustomerFirstPurchaseTest()
        {
            var customer = new Customer
            {
                BirthDate = DateTime.Now.AddDays(-1)
            };
            var expected = .05m;
            var current = _service.CalculateDiscount(customer);
            Assert.Equal(expected, current);
        }

    }
}
