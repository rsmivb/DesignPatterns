using System.Collections.Generic;
using System.Linq;

namespace NullObjectPattern.WithoutPattern
{
    public class PersonService : IPersonService
    {
        private readonly List<Person> _repository;

        public PersonService()
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
            return _repository.FirstOrDefault(p => p.Id == id);
        }
    }
}
