using System.Collections.Generic;
using Xunit;

namespace FactoryPattern.Test.WithoutPattern
{
    public class AutomobileServiceWithoutPatternTest
    {
        private readonly IAutoMobileService _service;

        public AutomobileServiceWithoutPatternTest()
        {
            _service = new AutoMobileService();
        }

        [Theory(DisplayName = "Given carName should return IAuto instance ")]
        [Trait("Factory", "Pattern")]
        [MemberData(nameof(IAutoDataTest))]
        public void GivenCarNameShouldReturnIAutoInstanceTest(string carName, IAuto expected)
        {
            var actualAuto = _service.GetCar(carName);
            Assert.Equal(expected, actualAuto);
        }

        public static IEnumerable<object[]> IAutoDataTest =>
            new List<object[]>
            {
                        new object[] { "BMW", new BMW335Xi()  },
                        new object[] { "mini", new MiniCooper() },
                        new object[] { "OTHER", new NullCar()  },
            };
    }
}
