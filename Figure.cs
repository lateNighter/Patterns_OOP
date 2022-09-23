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
        public bool selected { get; set; } = false;
        public Figure(float X, float Y)
        {
            x = X;
            y = Y;
        }
        public abstract void Draw(Graphics g, Color color);
        //public abstract void Dispose();
        //public abstract void Fill();
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

        //public virtual bool Touch(float X, float Y)
        //{
        //    if (X > x && X < x + w && Y > y && Y < y + h)
        //    {
        //        return true;
        //    }
        //    else return false;
        //}
    }
}
