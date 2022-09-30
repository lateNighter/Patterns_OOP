using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace Patterns_Drawer.Visitor
{
    class MoveVisitor : IVisitor
    {
        public float DX { get; set; }
        public float DY { get; set; }

        public MoveVisitor() { }

        public void Visit(Figure figure)
        {
            if (figure.selected)
            {
                figure.x = this.DX;
                figure.y = this.DY;
            }
        }

        public void SetXY(float x, float y)
        {
            this.DX = x;
            this.DY = y;
        }
    }
}
