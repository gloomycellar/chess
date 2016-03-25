using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Figure
{
    public class Pawn : FigureBase
    {
        public Pawn(IDesk desk, Color color, Coordinates coordinates) : base(desk, color, coordinates)
        {
        }

        public override List<Coordinates> GetAvailablePositions()
        {
            List<Coordinates> result = new List<Coordinates>();
            Coordinates c;
            FigureBase figure;
            if (Color == Color.White)
            {
                if (Coordinates.Y < 8)
                {
                    c = new Coordinates(Coordinates.X, Coordinates.Y + 1);
                    figure = Desk.GetFigure(c);
                    if (figure == null)
                        result.Add(c);

                    if (Coordinates.X > 1)
                    {
                        c = new Coordinates(Coordinates.X - 1, Coordinates.Y + 1);
                        figure = Desk.GetFigure(c);
                        if (figure != null && figure.Color != Color)
                            result.Add(c);
                    }

                    if (Coordinates.X < 8)
                    {
                        c = new Coordinates(Coordinates.X + 1, Coordinates.Y + 1);
                        figure = Desk.GetFigure(c);
                        if (figure != null && figure.Color != Color)
                            result.Add(c);
                    }
                }
            }
            else
            {
                if (Coordinates.Y > 1)
                {
                    c = new Coordinates(Coordinates.X, Coordinates.Y - 1);
                    figure = Desk.GetFigure(c);
                    if (figure == null)
                        result.Add(c);

                    if (Coordinates.X > 1)
                    {
                        c = new Coordinates(Coordinates.X - 1, Coordinates.Y - 1);
                        figure = Desk.GetFigure(c);
                        if (figure != null && figure.Color != Color)
                            result.Add(c);
                    }

                    if (Coordinates.X < 8)
                    {
                        c = new Coordinates(Coordinates.X + 1, Coordinates.Y - 1);
                        figure = Desk.GetFigure(c);
                        if (figure != null && figure.Color != Color)
                            result.Add(c);
                    }
                }
            }

            return result;
        }

        public override string ToString()
        {
            return "P" + (Color == Color.White ? "W" : "B");
        }
    }
}
