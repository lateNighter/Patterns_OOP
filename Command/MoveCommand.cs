using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace Patterns_Drawer.Command
{
    class MoveCommand : ICommand
    {
        private float DX;
        private float DY;

        public MoveCommand() { }

        public void Execute(Figure figure)
        {
            if (figure.selected)
            {
                figure.Move(DX,DY);
            }
        }

        public void SetStatus(List<object> status)
        {
            this.DX = float.Parse(status[0].ToString());
            this.DY = float.Parse(status[1].ToString());
        }
    }
}
