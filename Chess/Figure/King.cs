using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Figure
{
    public class King : FigureBase
    {
        public King(IDesk desk, Color color, Coordinates coordinates) : base(desk, color, coordinates)
        {
        }

        public override List<Coordinates> GetAllAvailablePositions()
        {
            List<Coordinates> result = new List<Coordinates>();
            if (Coordinates.X > 1)
            {
                AddCoordinatesToResult(new Coordinates(Coordinates.X - 1, Coordinates.Y), result);
                if (Coordinates.Y > 1)
                    AddCoordinatesToResult(new Coordinates(Coordinates.X - 1, Coordinates.Y - 1), result);
                if (Coordinates.Y <8)
                    AddCoordinatesToResult(new Coordinates(Coordinates.X - 1, Coordinates.Y + 1), result);
            }

            if (Coordinates.X < 8)
            {
                AddCoordinatesToResult(new Coordinates(Coordinates.X + 1, Coordinates.Y), result);
                if (Coordinates.Y > 1)
                    AddCoordinatesToResult(new Coordinates(Coordinates.X + 1, Coordinates.Y - 1), result);
                if (Coordinates.Y < 8)
                    AddCoordinatesToResult(new Coordinates(Coordinates.X + 1, Coordinates.Y + 1), result);
            }

            if (Coordinates.Y > 1)
                AddCoordinatesToResult(new Coordinates(Coordinates.X, Coordinates.Y - 1), result);

            if (Coordinates.Y < 8)
                AddCoordinatesToResult(new Coordinates(Coordinates.X, Coordinates.Y + 1), result);

            return result;
        }

        protected void AddCoordinatesToResult(Coordinates c, List<Coordinates> result)
        {
            FigureBase f = Desk.GetFigure(c);
            if (f == null || f.Color != Color)
                result.Add(c);
        }

        public override string ToString()
        {
            return "K" + (Color == Color.White ? "W" : "B");
        }
    }
}
