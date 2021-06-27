using System;

namespace RulesPattern.Model
{
    public class Customer
    {
        public string Name { set; get; }
        public DateTime BirthDate { get; set; }
        public DateTime? DateOfFirstPurchase { get; set; }
        public bool IsVeteran { get; set; }
    }
}