using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Drawer.Command
{
    class RemoveCommand : ICommand
    {
        private float DX;
        private float DY;
        private Canvas _canvas;

        public RemoveCommand(Canvas canvas) 
        { 
            this._canvas = canvas;
        }

        public void Execute(Figure figure)
        {
            figure.Touch(DX, DY);
            if (figure.selected)
            {
                _canvas.Remove(figure);
            }
        }

        public void SetStatus(List<object> status)
        {
            this.DX = float.Parse(status[0].ToString());
            this.DY = float.Parse(status[1].ToString());
        }
    }
}
