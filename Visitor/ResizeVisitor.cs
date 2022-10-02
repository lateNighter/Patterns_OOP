using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Drawer.Visitor
{
    class ResizeVisitor : IVisitor
    {
        public float DX { get; set; }
        public float DY { get; set; }
        public int scale { get; set; }

        public ResizeVisitor(int scale) 
        {
            this.scale = scale;
        }

        public void Visit(Figure figure)
        {
            figure.Touch(DX,DY);
            if (figure.selected)
            {
                figure.width = figure.width * (100 + scale) / 100;
                figure.height = figure.height * (100 + scale) / 100;
                //if (figure.width <= 0 || figure.height <= 0)
                //{
                //    figure.width = 0;
                //    figure.height = 0;
                //}
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
