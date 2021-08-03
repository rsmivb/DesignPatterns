using System.Collections.Generic;

namespace NullObjectPattern.WithoutPattern
{
    public interface IPersonService
    {
        IPerson GetById(int id);
    }
}