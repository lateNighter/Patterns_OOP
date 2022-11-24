using Patterns_Drawer.Command;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Drawer
{

    public class Rectangle : Figure
    {
        private Rectangle(float X, float Y, float Width, float Height) : base(X, Y, Width, Height) { }

        public override void Draw(Graphics g, Color color)
        {
            SetColor(color);
            var pen = new Pen(this.color);
            g.DrawRectangle(pen, x, y, width, height);

            if (this.selected) DrawSelection(g);
            if (this.filled) Fill(g); 
        }

        public override void DrawSelection(Graphics g)
        {
            if (!selected) return;

            var pen = new Pen(Color.Red);
            var brush = new SolidBrush(Color.Red);
            const int selection_width = 5;

            var tl = new RectangleF(x, y, selection_width, selection_width);
            var tr = new RectangleF(x + width - selection_width + 1, y, selection_width, selection_width);
            var bl = new RectangleF(x, y + height - selection_width + 1, selection_width, selection_width);
            var br = new RectangleF(x + width - selection_width + 1, y + height - selection_width + 1, selection_width, selection_width);

            g.DrawRectangle(pen, x, y, width, height);
            g.FillRectangle(brush, tl);
            g.FillRectangle(brush, tr);
            g.FillRectangle(brush, bl);
            g.FillRectangle(brush, br);
        }

        public override void Fill(Graphics g)
        {
            g.FillRectangle(new SolidBrush(fill_color), x, y, width, height);
        }

        public override void Execute(ICommand command)
        {
            command.Execute(this);
        }
        public override Figure Copy()
        {
            Rectangle r = new Rectangle(this.x, this.y, this.width, this.height);
            r.color = this.color;
            r.fill_color = this.fill_color;
            r.selected = this.selected;
            r.filled = this.filled;
            return r;
        }
        public class RectCreator : Creator 
        {
            public override Figure Create(float X, float Y, float Width, float Height)
            {
                Rectangle r = new Rectangle(X, Y, Width, Height);
                return r;
            }
        }
    }
}
