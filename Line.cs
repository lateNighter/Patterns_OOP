using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Drawer
{
    class Line : Figure
    {
        public float width { get; set; }
        public float height { get; set; }
        private Line(float X, float Y, float Width, float Height) : base(X, Y)
        {
            width = Width;
            height = Height;
        }

        public override void Draw(Graphics g, Color color)
        {
            var pen = new Pen(color);
            g.DrawLine(pen, x, y, x+width, y+height);
        }

        public class LineCreator : Creator 
        {
            public override Figure Create(float X, float Y, float Width, float Height)
            {
                Line l = new Line(X, Y, Width, Height);
                return l;
            }
        }
    }
}
