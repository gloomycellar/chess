using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public struct Coordinates
    {
        public Coordinates(int x, int y)
        {
            if (x > 8 || x < 1)
                throw new ArgumentOutOfRangeException("X have to be from 1 to 8");

            if (y > 8 || y < 1)
                throw new ArgumentOutOfRangeException("Y have to be from 1 to 8");

            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }
    }
}
