using NullObjectPattern.WithoutPattern;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NullObjectPattern.PatternApplied
{
    public class PersonServicePatternApplied : IPersonService
    {
        private readonly List<Person> _repository;

        public PersonServicePatternApplied()
        {
            _repository = new List<Person>{
                new Person
                {
                    Id = 1,
                    Name = "Mesquita"
                },
                new Person
                {
                    Id = 2,
                    Name = "Rafael"
                }
            };
        }

        public IPerson GetById(int id)
        {
            try
            {
                return _repository.First(p => p.Id == id);
            }
            catch (InvalidOperationException)
            {
                return new NullPerson();
            }
        }
    }
}
