using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    public class MyService : IMyService
    {
        public ComplexObject Create()
        {
            return new ComplexObject
            {
                Id = 1,
                Name = "Some name",
                BirthDay = DateTime.Now,
                Value = 10L,
                Ideas = new List<string> { "some1", "some2" , "some3" },
                Internal = new InternalObject
                {
                    Id = 1,
                    Name = "Internal Object",
                    AnotherIdeas = new List<string> { "another1", "another2", "another3" }
                }
            };
        }
    }

    public interface IMyService
    {
        ComplexObject Create();
    }
}
