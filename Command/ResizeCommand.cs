using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Drawer.Command
{
    class ResizeCommand : ICommand
    {
        private float DX;
        private float DY;
        public int scale { get; set; }

        public ResizeCommand(int scale) 
        {
            this.scale = scale;
        }

        public void Execute(Figure figure)
        {
            figure.Touch(DX,DY);
            if (figure.selected)
            {
                figure.Resize(scale);
            }
            figure.selected = false;
        }

        public void SetStatus(List<object> status)
        {
            this.DX = float.Parse(status[0].ToString());
            this.DY = float.Parse(status[1].ToString());
        }
    }
}
