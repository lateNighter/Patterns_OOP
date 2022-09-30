using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Drawer.Commands
{
    class SelectFigureCommand : ICommand<List<Figure>>
    {
        List<Figure> Figures;
        Figure FigureToSelect;

        public SelectFigureCommand()
        {
            this.Figures = new List<Figure>();
            this.FigureToSelect = null;
        }

        public SelectFigureCommand(List<Figure> figures, Figure fts)
        {
            this.Figures = figures;
            this.FigureToSelect = fts;
        }

        public List<Figure> Execute()
        {
            foreach (var f in this.Figures) f.selected = false;

            this.Figures.Find(x => x == this.FigureToSelect).selected = true;

            return this.Figures;
        }
    }
}
