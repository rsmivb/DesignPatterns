using System;

namespace NullObjectPattern
{
    public class Person : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Person person &&
                   Id == person.Id &&
                   Name == person.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name);
        }
    }
}
