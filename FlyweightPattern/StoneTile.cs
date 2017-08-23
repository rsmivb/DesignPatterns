using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    public class StoneTile : ITile
    {
        public static int objectCounter = 0;

        Brush paintBrush;

        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public StoneTile(int x, int y, int width, int height)
        {
            paintBrush = Brushes.Blue;
            X = x;
            Y = y;
            Height = height;
            Width = width;
            ++objectCounter;
        }

        public StoneTile()
        {
            paintBrush = Brushes.Blue;

            ++objectCounter;
        }
        public void Draw(/*Graphics g*/string writerGraphic, int x, int y, int width, int height)
        {
            Console.WriteLine($"{writerGraphic}-{x}-{y}-{width}-{height}");
            //g.FillRectangle(paintBrush, x, y, width, height);
        }

        public void Draw(string writer)
        {
            Console.Write(" ");
        }
    }
}
