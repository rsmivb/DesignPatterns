using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FactoryPattern.Test.WithPattern.Factory1
{
    public class AutoFactoryTest
    {

        [Theory(DisplayName = "MyMemberDataTest Description")]
        [Trait("Factory", "Pattern")]
        [MemberData(nameof(DataTest))]
        public void MyMemberDataTest(string carName, IAuto expectedCar)
        {
            var _service = new AutoFactory();
            var actualCar = _service.GetInstance(carName);
            Assert.Equal(expectedCar, actualCar);
        }

        public static IEnumerable<object[]> DataTest =>
            new List<object[]>
            {
                        new object[] { "BMW335Xi", new BMW335Xi()  },
                        new object[] { "MiniCooper", new MiniCooper() },
                        new object[] { "OTHER", new NullCar()  },
            };
    }
}
