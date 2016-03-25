using System.Collections.Generic;

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

        public void Move(Coordinates coordinates)
        {
            if (GetAllAvailablePositions().Contains(coordinates))
            {
                Desk.ChangePosition(this, coordinates);
            }
        }

        public abstract List<Coordinates> GetAllAvailablePositions();
    }
}
