using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Figure
{
    public class Hourse : FigureBase
    {
        public Hourse(IDesk desk, Color color, Coordinates coordinates) : base(desk, color, coordinates)
        {
        }

        public override void Move(Coordinates coordinate)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "H" + (Color == Color.White ? "W" : "B");
        }
    }
}
