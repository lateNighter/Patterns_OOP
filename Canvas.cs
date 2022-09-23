using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Drawer
{
    public class Canvas
    {
        private List<Figure> _figures;
        public List<Figure> Figures { get { return _figures; } }
        public Canvas()
        {
            _figures = new List<Figure>();
        }
        public void Add(Figure figure)
        {
            _figures.Add(figure);
        }
    }
}
