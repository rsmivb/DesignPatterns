﻿using NullObjectPattern.PatternApplied;
using System.Collections.Generic;
using Xunit;

namespace NullObjectPattern.Test.PatternApplied
{
    public class PersonServiceWithPatternTest
    {

        [Theory(DisplayName = "Null Object Pattern Applied")]
        [Trait("NullObject", "Pattern")]
        [MemberData(nameof(DataTest))]
        public void GetPersonByIdTest(int id, IPerson expected)
        {
            var service = new PersonServiceWithPattern();
            var current = service.GetById(id);
            Assert.Equal(expected, current);
        }

        public static IEnumerable<object[]> DataTest =>
            new List<object[]>
            {
                new object[] { 1, new Person { Id = 1, Name = "Mesquita" } },
                new object[] { 2, new Person { Id = 2, Name = "Rafael" } },
                new object[] { 99, new NullPerson() }
            };

    }
}
