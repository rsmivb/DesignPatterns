using Xunit;

namespace BuilderPattern.Test
{
    public class MyServiceTest
    {

        [Fact(DisplayName = "FactTest Description")]
        [Trait("Category", "Integration")]
        public void FactTest()
        {
            var expected = "";
            var current = "";
            Assert.Equal(expected, current);
        }

    }
}
