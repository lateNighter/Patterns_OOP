using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Drawer
{
    public class Memento
    {
        private List<Figure> _ContainerState;

        public List<Figure> ContainerState
        {
            get { return _ContainerState; }
        }
        public Memento(List<Figure> containerState)
        {
            this._ContainerState = containerState;
        }
    }
}
