using NullObjectPattern.WithoutPattern;
using System.Collections.Generic;

namespace NullObjectPattern.PatternApplied
{
    public class PersonServiceWithPattern : IPersonService
    {
        private readonly List<Person> _repository;

        public PersonServiceWithPattern()
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
            return (IPerson) _repository.Find(p => p.Id == id) ?? new NullPerson();
        }
    }
}
