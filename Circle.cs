using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Drawer
{
    class Circle : Figure
    {
        public float width { get; set; }
        public float height { get; set; }
        private Circle(float X, float Y, float Width, float Height) : base(X, Y)
        {
            width = Width;
            height = Height;
        }

        public override void Draw(Graphics g, Color color)
        {
            var pen = new Pen(color);
            g.DrawEllipse(pen, x, y, width, height);
            //var rectangle = new System.Drawing.Rectangle(this.X, this.Y, this.Width, this.Height);

            //if (this.Selected) g.DrawEllipse(new Pen(Color.Red), rectangle);
        }


        //public override bool Touch(float X, float Y)
        //{
        //    return ((Math.Pow(X - (x + w / 2), 2) + Math.Pow(Y - (y + h / 2), 2)) <= Math.Pow(w / 2, 2));

        //}
        public class CircleCreator : Creator //Rect.RectCreator
        {
            public override Figure Create(float X, float Y, float Width, float Height)
            {
                Circle r = new Circle(X, Y, Width, Height);
                return r;
            }
        }
    }
}
