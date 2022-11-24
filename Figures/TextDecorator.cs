using Patterns_Drawer.Command;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Drawer.Figures
{
    internal class TextDecorator : Figure
    {
        private Figure _component;
        private string _text;
        public TextDecorator(Figure figure, string text)
        {
            _component = figure;
            this.x = _component.x;
            this.y = _component.y;
            this.filled = _component.filled;
            this.fill_color = _component.fill_color;
            this.selected = _component.selected;
            _text = text;
        }
        public override void Touch(float X, float Y)
        {
            this.selected = false;
            _component.Touch(X, Y);
            if (_component.selected)
            {
                this.selected = true;
            }
        }
        public override Figure Copy()
        {
            Figure figure = _component.Copy();
            TextDecorator textDecorator = new TextDecorator(figure, _text);
            textDecorator.filled = this.filled;
            textDecorator.fill_color = this.fill_color;
            return textDecorator;
        }
        public override void Move(float X, float Y)
        {
            _component.Move(X, Y);
            this.x = _component.x;
            this.y = _component.y;
        }
        public override void Draw(Graphics g, Color color)
        {
            _component.selected = this.selected;
            _component.filled = this.filled;
            _component.fill_color = this.fill_color;
            _component.Draw(g, color);
            DrawText(g);
        }
        public override void Resize(int scale)
        {
            _component.Resize(scale);
        }
        public override void DrawSelection(Graphics g)
        {
            //_component.selected = this.selected;
            //_component.filled = this.filled;
            //_component.fill_color = this.fill_color;
            _component.DrawSelection(g);
        }

        public override void Execute(ICommand command)
        {
            _component.Execute(command);
        }

        public override void Fill(Graphics g)
        {
            _component.Fill(g);
        }
        private void DrawText(Graphics g)
        {
            var font = new Font("Arial", 16);
            var brush = new SolidBrush(Color.Black);
            var format = new StringFormat();
            g.DrawString(this._text, font, brush, _component.x + _component.width/2, _component.y + _component.height/2, format);
        }
    }
}
