using NullObjectPattern.WithoutPattern;
using System.Collections.Generic;
using Xunit;
namespace NullObjectPattern.Test.WithoutPattern
{
    public class PersonServiceWithoutPatternTest
    {

        [Theory(DisplayName = "PersonService should get Person by Id")]
        [Trait("Person", "Service")]
        [MemberData(nameof(DataTest))]
        public void PersonServiceShouldGetPersonByIdTest(int id, IPerson expected)
        {
            var service = new PersonService();
            var current = service.GetById(id);
            Assert.Equal(expected, current);
        }

        public static IEnumerable<object[]> DataTest =>
            new List<object[]>
            {
                new object[] { 1, new Person { Id = 1, Name = "Mesquita" } },
                new object[] { 2, new Person { Id = 2, Name = "Rafael" } },
                new object[] { 99, null }
            };

    }
}
