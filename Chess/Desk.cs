using Chess.Figure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Desk : IDesk
    {
        private FigureBase[,] field = new FigureBase[8, 8];

        public Desk()
        {
            Init();
        }

        private void Init()
        {
            //init whites
            Coordinates coordinates;
            FigureBase figure;
            for (int x = 1; x <= 8; x++)
            {
                coordinates = new Coordinates(x, 2);
                figure = new Pawn(this, Color.White, coordinates);
                ChangePosition(figure, coordinates);
            }

            coordinates = new Coordinates(1, 1);
            figure = new Elephant(this, Color.White, coordinates);
            ChangePosition(figure, coordinates);

            coordinates = new Coordinates(8, 1);
            figure = new Elephant(this, Color.White, coordinates);
            ChangePosition(figure, coordinates);

            coordinates = new Coordinates(2, 1);
            figure = new Hourse(this, Color.White, coordinates);
            ChangePosition(figure, coordinates);

            coordinates = new Coordinates(7, 1);
            figure = new Hourse(this, Color.White, coordinates);
            ChangePosition(figure, coordinates);

            coordinates = new Coordinates(3, 1);
            figure = new Officer(this, Color.White, coordinates);
            ChangePosition(figure, coordinates);

            coordinates = new Coordinates(6, 1);
            figure = new Officer(this, Color.White, coordinates);
            ChangePosition(figure, coordinates);

            coordinates = new Coordinates(4, 1);
            figure = new Queen(this, Color.White, coordinates);
            ChangePosition(figure, coordinates);

            coordinates = new Coordinates(5, 1);
            figure = new King(this, Color.White, coordinates);
            ChangePosition(figure, coordinates);

            //init blacks
            for (int x = 1; x <= 8; x++)
            {
                coordinates = new Coordinates(x, 7);
                figure = new Pawn(this, Color.Black, coordinates);
                ChangePosition(figure, coordinates);
            }

            coordinates = new Coordinates(1, 8);
            figure = new Elephant(this, Color.Black, coordinates);
            ChangePosition(figure, coordinates);

            coordinates = new Coordinates(8, 8);
            figure = new Elephant(this, Color.Black, coordinates);
            ChangePosition(figure, coordinates);

            coordinates = new Coordinates(2, 8);
            figure = new Hourse(this, Color.Black, coordinates);
            ChangePosition(figure, coordinates);

            coordinates = new Coordinates(7, 8);
            figure = new Hourse(this, Color.Black, coordinates);
            ChangePosition(figure, coordinates);

            coordinates = new Coordinates(3, 8);
            figure = new Officer(this, Color.Black, coordinates);
            ChangePosition(figure, coordinates);

            coordinates = new Coordinates(6, 8);
            figure = new Officer(this, Color.Black, coordinates);
            ChangePosition(figure, coordinates);

            coordinates = new Coordinates(4, 8);
            figure = new Queen(this, Color.Black, coordinates);
            ChangePosition(figure, coordinates);

            coordinates = new Coordinates(5, 8);
            figure = new King(this, Color.Black, coordinates);
            ChangePosition(figure, coordinates);
        }

        public void ClearField()
        {
            field = new FigureBase[8, 8];
        }

        public void ChangePosition(FigureBase figure, Coordinates coordiantes)
        {
            Coordinates old = figure.Coordinates;
            figure.Coordinates = coordiantes;
            field[old.X - 1, old.Y - 1] = null;
            field[coordiantes.X - 1, coordiantes.Y - 1] = figure;
        }

        public FigureBase GetFigure(Coordinates coordinates)
        {
            return field[coordinates.X - 1, coordinates.Y - 1];
        }

        public override string ToString()
        {
            string underscore = string.Format("{0}  ________________________________________{0}", Environment.NewLine);
            StringBuilder result = new StringBuilder("Desk:" + underscore);
            for (int i = 7; i >= 0; i--)
            {
                result.AppendFormat("{0} | {1}", i + 1, field[0, i] == null ? "  " : field[0, i].ToString());
                for (int j = 1; j < 8; j++)
                {
                    result.AppendFormat(" | {0}", field[j, i] == null ? "  " : field[j, i].ToString());
                }

                result.Append("|");
                result.Append(underscore);
            }

            result.Append("    A     B    C    D    E    F    G    H");

            return result.ToString();
        }
    }
}
