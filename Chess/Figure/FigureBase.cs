using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Figure
{
    public abstract class FigureBase
    {
        public FigureBase(IDesk desk, Color color, Coordinates coordinates)
        {
            Desk = desk;
            Color = color;
            Coordinates = coordinates;
        }

        public Color Color { get; set; }

        public IDesk Desk { get; set; }

        public Coordinates Coordinates { get; set; }

        public abstract void Move(Coordinates coordinate);
    }
}
