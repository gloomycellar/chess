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
        private FigureBase[,] desk = new FigureBase[8, 8];

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
                SetFigure(figure, coordinates);
            }

            coordinates = new Coordinates(1, 1);
            figure = new Elephant(this, Color.White, coordinates);
            SetFigure(figure, coordinates);

            coordinates = new Coordinates(8, 1);
            figure = new Elephant(this, Color.White, coordinates);
            SetFigure(figure, coordinates);

            coordinates = new Coordinates(2, 1);
            figure = new Hourse(this, Color.White, coordinates);
            SetFigure(figure, coordinates);

            coordinates = new Coordinates(7, 1);
            figure = new Hourse(this, Color.White, coordinates);
            SetFigure(figure, coordinates);

            coordinates = new Coordinates(3, 1);
            figure = new Officer(this, Color.White, coordinates);
            SetFigure(figure, coordinates);

            coordinates = new Coordinates(6, 1);
            figure = new Officer(this, Color.White, coordinates);
            SetFigure(figure, coordinates);

            coordinates = new Coordinates(4, 1);
            figure = new Queen(this, Color.White, coordinates);
            SetFigure(figure, coordinates);

            coordinates = new Coordinates(5, 1);
            figure = new King(this, Color.White, coordinates);
            SetFigure(figure, coordinates);

            //init blacks
            for (int x = 1; x <= 8; x++)
            {
                coordinates = new Coordinates(x, 7);
                figure = new Pawn(this, Color.Black, coordinates);
                SetFigure(figure, coordinates);
            }

            coordinates = new Coordinates(1, 8);
            figure = new Elephant(this, Color.Black, coordinates);
            SetFigure(figure, coordinates);

            coordinates = new Coordinates(8, 8);
            figure = new Elephant(this, Color.Black, coordinates);
            SetFigure(figure, coordinates);

            coordinates = new Coordinates(2, 8);
            figure = new Hourse(this, Color.Black, coordinates);
            SetFigure(figure, coordinates);

            coordinates = new Coordinates(7, 8);
            figure = new Hourse(this, Color.Black, coordinates);
            SetFigure(figure, coordinates);

            coordinates = new Coordinates(3, 8);
            figure = new Officer(this, Color.Black, coordinates);
            SetFigure(figure, coordinates);

            coordinates = new Coordinates(6, 8);
            figure = new Officer(this, Color.Black, coordinates);
            SetFigure(figure, coordinates);

            coordinates = new Coordinates(4, 8);
            figure = new Queen(this, Color.Black, coordinates);
            SetFigure(figure, coordinates);

            coordinates = new Coordinates(5, 8);
            figure = new King(this, Color.Black, coordinates);
            SetFigure(figure, coordinates);
        }

        private void SetFigure(FigureBase figure, Coordinates coordiantes)
        {
            desk[coordiantes.X - 1, coordiantes.Y - 1] = figure;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < 8; i++)
            {
                result.AppendFormat(" {0}", desk[i, 0] == null ? "  " : desk[i, 0].ToString());
                for (int j = 1; j < 8; j++)
                {
                    result.AppendFormat(" , {0}", desk[i, j] == null ? "  " : desk[i, j].ToString());
                }

                result.Append(Environment.NewLine);
            }

            return result.ToString();
        }
    }
}
