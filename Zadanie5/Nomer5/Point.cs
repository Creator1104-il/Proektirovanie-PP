using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomer5
{
    internal class Point
    {
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Deconstruct(out int x, out int y)
        {
            x = this.X;
            y = this.Y;
        }
    }
}
