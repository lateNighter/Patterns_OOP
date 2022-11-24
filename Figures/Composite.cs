using Patterns_Drawer.Command;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Patterns_Drawer.Figures
{
    internal class Composite : Figure
    {
        private List<Figure> _children;
        public Composite() 
        {
            _children = new List<Figure>();
        }
        public override void Touch(float X, float Y)
        {
            this.selected = false;
            foreach (Figure f in _children)
            {
                f.Touch(X, Y);
                if (f.selected)
                {
                    this.selected = true;
                    foreach (Figure fig in _children)
                    {
                        fig.selected = true;
                    }
                    break;
                }
            }
        }
        public override Figure Copy()
        {
            Composite composite = new Composite();

            foreach (Figure f in _children)
            {
                composite.Add(f.Copy());
            }
            composite.selected = this.selected;
            composite.filled = this.filled;
            composite.fill_color = this.fill_color;

            return composite;
        }
        public void Add(Figure child)
        {
            _children.Add(child);
            this.x = _children.Min(f => f.x);
            this.y = _children.Min(f => f.y);
            this.width = _children.Max(f => f.x + f.width) - this.x;
            this.height = _children.Max(f => f.y + f.height) - this.y;
        }
        public override void Draw(Graphics g, Color color)
        {
            foreach (Figure f in _children)
            {
                if (this.filled)
                {
                    f.filled = this.filled;
                    f.fill_color = this.fill_color;
                }
                
                f.Draw(g, color);
            }
        }

        public override void DrawSelection(Graphics g)
        {
            foreach (Figure f in _children)
            {
                f.DrawSelection(g);
            }
        }

        public override void Fill(Graphics g)
        {
            foreach (Figure f in _children)
            {
                f.Fill(g);
            }
        }
        public override void Move(float X, float Y)
        {
            float xl = _children.Min(f => f.x);
            float yl = _children.Min(f => f.y);
            foreach (Figure f in _children)
            {
                f.Move(X + (f.x - xl), Y + (f.y - yl));
            }
            this.x = _children.Min(f => f.x); 
            this.y = _children.Min(f => f.y);
        }
        public override void Resize(int scale)
        {
            foreach (Figure f in _children)
            {
                f.Resize(scale);
            }
        }
        public override void Execute(ICommand command)
        {
            foreach (Figure f in _children)
            {
                //f.x = this.x;
                //f.y = this.y;
                command.Execute(f);
            }
        }
        public List<Figure> GetChildren()
        {
            return _children;
        }
    }
}
