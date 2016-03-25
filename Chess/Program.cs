using Chess.Figure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            IDesk desk = new Desk();
            desk.ClearField();
            FigureBase figure = new Elephant(desk, Color.White, new Coordinates(1, 1));
            desk.ChangePosition(figure, new Coordinates(1, 1));

            Console.WriteLine(desk);
            figure = desk.GetFigure(new Coordinates(1, 1));
            figure.Move(new Coordinates(5, 1));
            Console.WriteLine(desk);
            figure.Move(new Coordinates(3, 1));
            Console.WriteLine(desk);

            desk = new Desk();
            desk.ClearField();
            figure = new Elephant(desk, Color.White, new Coordinates(1, 1));
            desk.ChangePosition(figure, new Coordinates(1, 1));

            Console.WriteLine(desk);
            figure = desk.GetFigure(new Coordinates(1, 1));
            figure.Move(new Coordinates(1, 5));
            Console.WriteLine(desk);
            figure.Move(new Coordinates(1, 3));
            Console.WriteLine(desk);
        }
    }
}
