using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Drawer.Visitor
{
    class RemoveVisitor : IVisitor
    {
        public float DX { get; set; }
        public float DY { get; set; }
        private Canvas _canvas;

        public RemoveVisitor(Canvas canvas) 
        { 
            this._canvas = canvas;
        }

        public void Visit(Figure figure)
        {
            figure.Touch(DX, DY);
            if (figure.selected)
            {
                _canvas.Remove(figure);
            }
        }

        public void SetXY(float x, float y)
        {
            this.DX = x;
            this.DY = y;
        }
    }
}
