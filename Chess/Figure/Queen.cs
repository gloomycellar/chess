using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Figure
{
    public class Queen : FigureBase
    {
        public Queen(IDesk desk, Color color, Coordinates coordinates) : base(desk, color, coordinates)
        {
        }

        public override List<Coordinates> GetAvailablePositions()
        {
            List<Coordinates> result = new List<Coordinates>();

            result.AddRange(AvailableCellsByDiagonals());
            result.AddRange(AvailableCellsByHorizontalsAndVerticals());

            return result;
        }

        private List<Coordinates> AvailableCellsByDiagonals()
        {
            List<Coordinates> result = new List<Coordinates>();
            Coordinates c;
            FigureBase figure;
            int x, y;
            if (Coordinates.X > 1 && Coordinates.Y > 1)
            {
                x = Coordinates.X - 1;
                y = Coordinates.Y - 1;

                do
                {
                    c = new Coordinates(x, y);
                    figure = Desk.GetFigure(c);
                    if (figure == null)
                    {
                        result.Add(c);
                    }
                    else if (figure.Color != Color)
                    {
                        result.Add(c);
                        break;
                    }
                    else
                    {
                        break;
                    }

                    x--;
                    y--;
                } while (x >= 1 && y >= 1);

            }

            if (Coordinates.X < 8 && Coordinates.Y > 1)
            {
                x = Coordinates.X + 1;
                y = Coordinates.Y - 1;

                do
                {
                    c = new Coordinates(x, y);
                    figure = Desk.GetFigure(c);
                    if (figure == null)
                    {
                        result.Add(c);
                    }
                    else if (figure.Color != Color)
                    {
                        result.Add(c);
                        break;
                    }
                    else
                    {
                        break;
                    }

                    x++;
                    y--;
                } while (x <= 8 && y >= 1);

            }

            if (Coordinates.X > 1 && Coordinates.Y < 8)
            {
                x = Coordinates.X - 1;
                y = Coordinates.Y + 1;

                do
                {
                    c = new Coordinates(x, y);
                    figure = Desk.GetFigure(c);
                    if (figure == null)
                    {
                        result.Add(c);
                    }
                    else if (figure.Color != Color)
                    {
                        result.Add(c);
                        break;
                    }
                    else
                    {
                        break;
                    }

                    x--;
                    y++;
                } while (x >= 1 && y <= 8);

            }

            if (Coordinates.X < 8 && Coordinates.Y < 8)
            {
                x = Coordinates.X + 1;
                y = Coordinates.Y + 1;

                do
                {
                    c = new Coordinates(x, y);
                    figure = Desk.GetFigure(c);
                    if (figure == null)
                    {
                        result.Add(c);
                    }
                    else if (figure.Color != Color)
                    {
                        result.Add(c);
                        break;
                    }
                    else
                    {
                        break;
                    }

                    x++;
                    y++;
                } while (x <= 8 && y <= 8);

            }

            return result;
        }

        private List<Coordinates> AvailableCellsByHorizontalsAndVerticals()
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
            return "Q" + (Color == Color.White ? "W" : "B");
        }
    }
}
