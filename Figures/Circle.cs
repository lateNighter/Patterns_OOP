using Patterns_Drawer.Command;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Drawer
{
    public class Circle : Figure
    {
        private Circle(float X, float Y, float Width, float Height) : base(X, Y, Width, Height) { }

        public override void Draw(Graphics g, Color color)
        {
            SetColor(color);
            var pen = new Pen(this.color);
            g.DrawEllipse(pen, x, y, width, height);

            if (this.selected) DrawSelection(g);
            if (this.filled) Fill(g);
        }


        public override void Touch(float X, float Y)
        {
            this.selected = ((Math.Pow(X - (x + width / 2), 2) + Math.Pow(Y - (y + height / 2), 2)) <= Math.Pow(width / 2, 2));
        }

        public override void Execute(ICommand command)
        {
            command.Execute(this);
        }

        public override void DrawSelection(Graphics g)
        {
            var rectangle = new System.Drawing.RectangleF(this.x, this.y, this.width, this.height);
            g.DrawEllipse(new Pen(Color.Red), rectangle);

            const int selection_width = 5;
            var pen = new Pen(Color.Red);
            var brush = new SolidBrush(Color.Red);

            var t = new RectangleF(x + width/2 - selection_width + 1, y - selection_width + 1, selection_width, selection_width);
            var r = new RectangleF(x + width - selection_width + 1, y + height/2 - selection_width + 1, selection_width, selection_width);
            var l = new RectangleF(x, y + height / 2 - selection_width + 1, selection_width, selection_width);
            var b = new RectangleF(x + width/2 - selection_width + 1, y + height - selection_width + 1, selection_width, selection_width);

            g.FillRectangle(brush, t);
            g.FillRectangle(brush, r);
            g.FillRectangle(brush, l);
            g.FillRectangle(brush, b);
        }

        public override void Fill(Graphics g)
        {
            g.FillEllipse(new SolidBrush(fill_color), this.x, this.y, this.width, this.height);
        }

        public override Figure Copy()
        {
            Circle c = new Circle(this.x, this.y, this.width, this.height);
            c.color = this.color;
            c.fill_color = this.fill_color;
            c.selected = this.selected;
            c.filled = this.filled;
            return c; 
        }

        public class CircleCreator : Creator 
        {
            public override Figure Create(float X, float Y, float Width, float Height)
            {
                Circle r = new Circle(X, Y, Width, Height);
                return r;
            }
        }
    }
}
