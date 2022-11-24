using Patterns_Drawer.Command;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xaml;

namespace Patterns_Drawer
{
    public class Line : Figure
    {
        private Line(float X, float Y, float Width, float Height) : base(X, Y, Width, Height) { }

        public override void Draw(Graphics g, Color color)
        {
            SetColor(color);
            var pen = new Pen(this.color);
            g.DrawLine(pen, x, y, x+width, y+height);

            if (this.selected) DrawSelection(g);
            if (this.filled) Fill(g);
        }
        public override void Touch(float X, float Y)
        {
            this.selected = DistToLine(X, Y) < 10;
        }
        private float DistToLine(float k, float l)
        {
            float px = 0;
            float py = 0;
            if (width == 0)
            {
                px = x;
                py = l;
            }
            else if (height == 0)
            {
                py = y;
                px = k;
            }
            else
            {
                py = ((width * width / height) * y + width * (k - x) + height * l) / ((width * width / height) + height);
                px = (width / height) * (py - y) + x;
            }
            return (float)Math.Sqrt((k - px) * (k - px) + (l - py) * (l - py));
        }
        public override void DrawSelection(Graphics g)
        {
            var pen = new Pen(Color.Red);
            var brush = new SolidBrush(Color.Red);
            const int selection_width = 5;

            var tl = new RectangleF(x, y, selection_width, selection_width);
            var br = new RectangleF(x + width - selection_width + 1, y + height - selection_width + 1, selection_width, selection_width);
            g.FillRectangle(brush, tl);
            g.FillRectangle(brush, br);
            g.DrawLine(pen, x, y, x + width, y + height);
        }

        public override void Execute(ICommand command)
        {
            command.Execute(this);
        }

        public override void Fill(Graphics g)
        {
            var pen = new Pen(fill_color);
            g.DrawLine(pen, x, y, x + width, y + height);
        }

        public override Figure Copy()
        {
            Line l = new Line(this.x, this.y, this.width, this.height);
            l.color = this.color;
            l.fill_color = this.fill_color;
            l.selected = this.selected;
            l.filled = this.filled;
            return l;
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
