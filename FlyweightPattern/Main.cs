using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    public class Main
    {
        Random r = new Random();
        public void Run()
        {
            // Not using Flyweight
            for (int i = 0; i < 20; i++)
            {
                ITile ceramicTile = new CeramicTile(GetRandomNumber(), GetRandomNumber(), GetRandomNumber(), GetRandomNumber());
                ceramicTile.Draw("CeramicTile");
                ITile stoneTile = new StoneTile(GetRandomNumber(), GetRandomNumber(), GetRandomNumber(), GetRandomNumber());
                stoneTile.Draw("StoneTile");
            }
            Console.WriteLine($"Total of files created not using Flyweight pattern and TileFactory factory : {CeramicTile.objectCounter} + {StoneTile.objectCounter} created");


            // Using Flyweight
            for (int i = 0; i < 20; i++)
            {
                ITile ceramicTile = TileFactory.GetTile("Ceramic");
                ceramicTile.Draw("CeramicTile", GetRandomNumber(), GetRandomNumber(), GetRandomNumber(), GetRandomNumber());
                ITile stoneTile = TileFactory.GetTile("Stone");
                stoneTile.Draw("StoneTile", GetRandomNumber(), GetRandomNumber(), GetRandomNumber(), GetRandomNumber());
            }
            Console.WriteLine($"Total of files created using Flyweight pattern using TileFactory factory : {CeramicTile.objectCounter} + {StoneTile.objectCounter} created");
            Console.ReadKey();
        }

        public int GetRandomNumber()
        {
            return (int)(r.Next(100));
        }
    }
}
