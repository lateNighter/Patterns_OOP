using Patterns_Drawer.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Drawer.CommandGroup
{
    internal class AddToGroupCommand : IGroupCommand
    {
        private float DX;
        private float DY;
        private Composite _composite;

        public AddToGroupCommand()
        {
            _composite = new Composite();
        }
        public void Execute(Canvas canvas)
        {
            if (!_composite.selected && _composite.GetChildren().Count>0) _composite = new Composite();
            foreach (var figure in canvas.Figures.ToArray())
            {
                if (!figure.selected)
                {
                    figure.Touch(DX, DY);
                }
                if (figure.selected && !_composite.GetChildren().Contains(figure) && _composite!=figure)
                {
                    _composite.Add(figure);
                    _composite.selected = true;
                    canvas.Figures.Remove(figure);
                }
            }
            if (_composite.GetChildren().Count > 0 && !canvas.Figures.Contains(_composite))
            {
                canvas.Figures.Add(_composite);
            }
        }
        public void SetStatus(List<object> status)
        {
            this.DX = float.Parse(status[0].ToString());
            this.DY = float.Parse(status[1].ToString());
        }
    }
}
