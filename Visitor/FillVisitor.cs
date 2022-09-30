using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Drawer.Visitor
{
    class FillVisitor : IVisitor
    {
        public float DX { get; set; }
        public float DY { get; set; }

        public FillVisitor() { }

        public void Visit(Figure figure)
        {
            figure.Touch(this.DX, this.DY);
            if (figure.selected)
            {
                figure.filled = true;
            }
            figure.selected = false;
        }

        public void SetXY(float x, float y)
        {
            this.DX = x;
            this.DY = y;
        }
    }
}
