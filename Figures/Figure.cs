using Patterns_Drawer.Visitor;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Drawer
{

    public abstract class Figure : IDrawable
    {
        public float x { get; set; } = 0;
        public float y { get; set; } = 0;
        public float width { get; set; }
        public float height { get; set; }
        public bool selected { get; set; } = false;
        public bool filled { get; set; } = false;
        public Color color { get; set; }
        public Color fill_color { get; set; }
        public Figure(float X, float Y, float Width, float Height)
        {
            x = X;
            y = Y;
            width = Width;
            height = Height;
        }
        protected void SetColor(Color color)
        {
            if (this.color == Color.Empty) this.color = color;
            if (this.filled && fill_color == Color.Empty) this.fill_color = color;
        }
        public abstract void Draw(Graphics g, Color color);
        public abstract void Visit(IVisitor visitor);
        //public abstract void Dispose();
        public abstract void Fill(Graphics g);
        //public virtual void Move(float X, float Y)
        //{
        //    x = X;
        //    y = Y;
        //}
        //public virtual void Resize(int a)
        //{
        //    w += a;
        //    h += a;
        //    if (w <= 0 || h <= 0)
        //    {
        //        w = 0;
        //        h = 0;
        //    }
        //}

        public virtual void Touch(float X, float Y)
        {
            this.selected = (X > x && X < x + width && Y > y && Y < y + height);
        }
        public abstract void DrawSelection(Graphics g);

    }
}
