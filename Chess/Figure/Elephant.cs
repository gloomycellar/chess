using System.Collections.Generic;

namespace Chess.Figure
{
    public class Elephant : FigureBase
    {
        public Elephant(IDesk desk, Color color, Coordinates coordinates) : base(desk, color, coordinates)
        {
        }

        public override List<Coordinates> GetAllAvailablePositions()
        {
            List<Coordinates> result = new List<Coordinates>();
            FigureBase another;
            Coordinates c;
            if (Coordinates.X > 1)
            {
                for (int index = (Coordinates.X - 1); index >= 1; index--)
                {
                    c = new Coordinates(index, Coordinates.Y);
                    another = Desk.GetFigure(c);
                    if (another == null)
                    {
                        result.Add(c);
                    }
                    else if (another.Color != Color)
                    {
                        result.Add(c);
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            if (Coordinates.X < 8)
            {
                for (int index = (Coordinates.X + 1); index <= 8; index++)
                {
                    c = new Coordinates(index, Coordinates.Y);
                    another = Desk.GetFigure(c);
                    if (another == null)
                    {
                        result.Add(c);
                    }
                    else if (another.Color != Color)
                    {
                        result.Add(c);
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            if (Coordinates.Y > 1)
            {
                for (int index = (Coordinates.Y - 1); index >= 1; index--)
                {
                    c = new Coordinates(Coordinates.X, index);
                    another = Desk.GetFigure(c);
                    if (another == null)
                    {
                        result.Add(c);
                    }
                    else if (another.Color != Color)
                    {
                        result.Add(c);
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            if (Coordinates.Y < 8)
            {
                for (int index = (Coordinates.Y + 1); index <= 8; index++)
                {
                    c = new Coordinates(Coordinates.X, index);
                    another = Desk.GetFigure(c);
                    if (another == null)
                    {
                        result.Add(c);
                    }
                    else if (another.Color != Color)
                    {
                        result.Add(c);
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return result;
        }

        public override string ToString()
        {
            return "E" + (Color == Color.White ? "W" : "B");
        }
    }
}
