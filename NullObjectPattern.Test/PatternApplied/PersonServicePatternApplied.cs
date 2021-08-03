﻿using NullObjectPattern.PatternApplied;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace NullObjectPattern.Test.PatternApplied
{
    public class PersonServicePatternAppliedTest
    {

        [Theory(DisplayName = "MyMemberDataTest Description")]
        [Trait("Category", "Integration")]
        [MemberData(nameof(DataTest))]
        public void MyMemberDataTest(int id, IPerson expected)
        {
            var service = new PersonServicePatternApplied();
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