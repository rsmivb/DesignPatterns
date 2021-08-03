using System;

namespace NullObjectPattern
{
    public class NullPerson : IPerson
    {
        public int Id => -1;

        public string Name => "Null Person";

        public override bool Equals(object obj)
        {
            return obj is NullPerson person &&
                   Id == person.Id &&
                   Name == person.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name);
        }
    }
}
