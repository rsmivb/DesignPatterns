using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    public class CeramicTile : ITile
    {
        public static int objectCounter = 0;

        Brush paintBrush;

        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public CeramicTile(int x, int y, int width, int height)
        {
            paintBrush = Brushes.Red;
            X = x;
            Y = y;
            Height = height;
            Width = width;
            ++objectCounter;
        }
        public CeramicTile()
        {
            paintBrush = Brushes.Red;

            ++objectCounter;
        }
        public void Draw(/*Graphics g*/string writerGraphic, int x, int y, int width, int height)
        {
            Console.WriteLine($"{writerGraphic}-{x}-{y}-{width}-{height}");
            //g.FillRectangle(paintBrush, x, y, width, height);
        }

        // this method is using to create one tile per new ObjectTile called
        public void Draw(string writer)
        {
            Console.Write("");
        }
    }
}
