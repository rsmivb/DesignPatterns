using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    public interface ITile
    {
        void Draw(/*Graphics g*/string writerGraphic, int x, int y, int width, int height);

        void Draw(string writer);
    }
}
