using Chess.Figure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public interface IDesk
    {
        FigureBase GetFigure(Coordinates coordinates);

        void ChangePosition(FigureBase figure, Coordinates coordiantes);

        void Clear();
    }
}
