using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Drawer
{
    class Rectangle : Figure
    {
        public float width { get; set; }
        public float height { get; set; }
        private Rectangle(float X, float Y, float Width, float Height) : base(X, Y)
        {
            width = Width;
            height = Height;
        }

        public override void Draw(Graphics g, Color color)
        {
            var pen = new Pen(color);
            g.DrawRectangle(pen, x, y, width, height);
            //var rectangle = new System.Drawing.Rectangle(this.X, this.Y, this.Width, this.Height);

            //if (this.Selected) g.DrawRectangle(new Pen(Color.Red), rectangle);
        }
        public class RectCreator : Creator //Rect.RectCreator
        {
            public override Figure Create(float X, float Y, float Width, float Height)
            {
                Rectangle r = new Rectangle(X, Y, Width, Height);
                return r;
            }
        }
    }
}
