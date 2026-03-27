using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nomer6
{
    internal struct Point
    {
        public int X;
        public int Y;

        public void Move(int deltaX, int deltaY)
        {
            X += deltaX;
            Y += deltaY;
        }

        public void PrintCoordinates()
        {
            Console.WriteLine($"Точка: ({X}, {Y})");
        }
    }
}
