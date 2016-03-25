using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Figure
{
    public class Officer : FigureBase
    {
        public Officer(IDesk desk, Color color, Coordinates coordinates) : base(desk, color, coordinates)
        {
        }

        public override List<Coordinates> GetAllAvailablePositions()
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

        public override string ToString()
        {
            return "O" + (Color == Color.White ? "W" : "B");
        }
    }
}
