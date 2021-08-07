using System.Collections.Generic;
using Xunit;

namespace FactoryPattern.Test.WithPattern
{
    public class LoadFactoryServiceWithPatternTest
    {
        private readonly LoadFactoryService _service;

        public LoadFactoryServiceWithPatternTest()
        {
            _service = new LoadFactoryService();
        }
        [Theory(DisplayName = "Given factoryCar Name should return IAuto instance ")]
        [Trait("Factory", "Pattern")]
        [MemberData(nameof(IAutoDataTest))]
        public void GivenFactoryCarNameShouldReturnIAutoInstanceTest(string factoryCarName, IAuto expected)
        {
            var factory = _service.LoadFactory(factoryCarName);
            var actualAuto = factory.CreateAutomobile();
            Assert.Equal(expected, actualAuto);
        }

        public static IEnumerable<object[]> IAutoDataTest =>
            new List<object[]>
            {
                        new object[] { "BMW335XiFactory", new BMW335Xi()  },
                        new object[] { "MiniCooperFactory", new MiniCooper() },
                        new object[] { "OTHER", new NullCar()  },
            };
    }
}
