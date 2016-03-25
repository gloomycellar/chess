using System.Collections.Generic;

namespace Chess.Figure
{
    public class Hourse : FigureBase
    {
        public Hourse(IDesk desk, Color color, Coordinates coordinates) : base(desk, color, coordinates)
        {
        }

        public override List<Coordinates> GetAllAvailablePositions()
        {
            List<Coordinates> result = new List<Coordinates>();
            if (Coordinates.X > 1)
            {
                if (Coordinates.Y > 2)
                    AddCoordinatesToResult(new Coordinates(Coordinates.X - 1, Coordinates.Y - 2), result);

                if (Coordinates.Y < 7)
                    AddCoordinatesToResult(new Coordinates(Coordinates.X - 1, Coordinates.Y + 2), result);
            }

            if (Coordinates.X < 8)
            {
                if (Coordinates.Y > 2)
                    AddCoordinatesToResult(new Coordinates(Coordinates.X + 1, Coordinates.Y - 2), result);

                if (Coordinates.Y < 7)
                    AddCoordinatesToResult(new Coordinates(Coordinates.X + 1, Coordinates.Y + 2), result);
            }

            if (Coordinates.X > 2)
            {
                if (Coordinates.Y > 1)
                    AddCoordinatesToResult(new Coordinates(Coordinates.X - 2, Coordinates.Y - 1), result);

                if (Coordinates.Y < 8)
                    AddCoordinatesToResult(new Coordinates(Coordinates.X - 2, Coordinates.Y + 1), result);
            }

            if (Coordinates.X < 7)
            {
                if (Coordinates.Y > 1)
                    AddCoordinatesToResult(new Coordinates(Coordinates.X + 2, Coordinates.Y - 1), result);

                if (Coordinates.Y < 8)
                    AddCoordinatesToResult(new Coordinates(Coordinates.X + 2, Coordinates.Y + 1), result);
            }

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
            return "H" + (Color == Color.White ? "W" : "B");
        }
    }
}
