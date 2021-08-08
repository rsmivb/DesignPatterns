using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    public class ComplexObject
    {
        public int Id { get; set; }
        public string Name { set; get; }
        public DateTime BirthDay { set; get; }
        public decimal Value { get; set; }
        public List<string> Ideas { get; set; }
        public InternalObject Internal { get; set; }
    }
}
