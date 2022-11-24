using Patterns_Drawer.Command;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

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
        public Figure() { }
        protected void SetColor(Color color)
        {
            if (this.color == Color.Empty) this.color = color;
        }
        public virtual void Touch(float X, float Y)
        {
            this.selected = (X > x && X < x + width && Y > y && Y < y + height);
        }
        public virtual void Move(float X, float Y)
        {
            this.x = X;
            this.y = Y;
        }
        public virtual void Resize(int scale)
        {
            this.width = this.width * (100 + scale) / 100;
            this.height = this.height * (100 + scale) / 100;
            //if (figure.width <= 0 || figure.height <= 0)
            //{
            //    figure.width = 0;
            //    figure.height = 0;
            //}
        }
        public abstract Figure Copy();
        public abstract void Draw(Graphics g, Color color);
        public abstract void Execute(ICommand command);
        public abstract void Fill(Graphics g);
        public abstract void DrawSelection(Graphics g);

    }
}
