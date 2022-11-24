using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Drawer.Command
{
    class FillCommand : ICommand
    {
        private float DX;
        private float DY;
        private Color color;

        public FillCommand() { }

        public void Execute(Figure figure)
        {
            figure.Touch(this.DX, this.DY);
            if (figure.selected)
            {
                figure.filled = true;
                figure.fill_color = color;
            }
            figure.selected = false;
        }

        public void SetStatus(List<object> status)
        {
            this.DX = float.Parse(status[0].ToString());
            this.DY = float.Parse(status[1].ToString());
            this.color = (Color)status[2];
        }
    }
}
