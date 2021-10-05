using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int souradniceX, int souradniceY)
        {
            X = souradniceX;
            Y = souradniceY;
        }
        public override string ToString()
        {
            return $"[{X},{Y}]";
        }

    }
}
