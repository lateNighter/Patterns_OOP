using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Drawer.Command
{
    class SelectCommand : ICommand
    {
        private float DX;
        private float DY;

        public SelectCommand() { }

        public void Execute(Figure figure)
        {
            figure.Touch(this.DX, this.DY);
        }

        public void SetStatus(List<object> status)
        {
            this.DX = float.Parse(status[0].ToString());
            this.DY = float.Parse(status[1].ToString());
        }
    }
}
