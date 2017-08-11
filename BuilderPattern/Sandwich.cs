using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    //This is a model which is needed to have a Maker and a Builder to construct it
    public class Sandwich
    {
        public bool IsToasted { get; set; }
        public bool HasMustard { get; set; }
        public bool HasCatchup { get; set; }
        public bool HasMayo { get; set; }
        public IList<string> Vegetables { get; set; }
        public CheeseType CheeseType { get; set; }
        public BreadType BreadType { get; set; }
        public MeatType MeatType { get; set; }

        public void Display()
        {
            Console.WriteLine($"Toasted: {IsToasted}");
            Console.WriteLine($"Mustard: {HasMustard}");
            Console.WriteLine($"Catchup: {HasCatchup}");
            Console.WriteLine($"Mayo: {HasMayo}");
            Console.WriteLine($"Cheese: {CheeseType}, Meat: {MeatType}");
        }
    }

    public enum BreadType
    {
        White,
        Wheat
    }
    public enum CheeseType
    {
        Swiss,
        Cheddar
    }
    public enum MeatType
    {
        Sausage,
        Turkey
    }
}
