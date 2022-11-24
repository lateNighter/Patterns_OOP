using Patterns_Drawer.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Drawer.Command
{
    internal class AddTextCommand : ICommand
    {
        private float DX;
        private float DY;
        private string _text;
        private Canvas _canvas;
        public void Execute(Figure figure)
        {
            figure.Touch(DX, DY);
            if (figure.selected)
            {
                figure.selected = false;
                _canvas.Figures[_canvas.Figures.IndexOf(figure)] = new TextDecorator(figure.Copy(), _text);
            }
        }

        public void SetStatus(List<object> status)
        {
            this.DX = float.Parse(status[0].ToString());
            this.DY = float.Parse(status[1].ToString());
            this._text = status[3].ToString();
            this._canvas = (Canvas)status[4];
        }
    }
}
