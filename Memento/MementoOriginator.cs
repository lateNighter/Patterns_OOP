using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using System.Xml;

namespace Patterns_Drawer
{
    public class MementoOriginator
    {
        private Canvas _Container;

        public MementoOriginator(Canvas container)
        {
            _Container = container;
        }

        public Memento getMemento()
        {
            List<Figure> _ContainerState = new List<Figure>();

            foreach (Figure item in _Container.Figures)
            {
                _ContainerState.Add(item.Copy());
            }

            return new Memento(_ContainerState);

        }

        public void setMemento(Memento memento)
        {
            _Container.Figures.Clear();
            Memento memento1 = MementoClone(memento);
            foreach (Figure item in memento1.ContainerState)
            {
                _Container.Figures.Add(item);
            }
        }

        public Memento MementoClone(Memento memento)
        {
            List<Figure> _ContainerState = new List<Figure>();

            foreach (Figure item in memento.ContainerState)
            {
                _ContainerState.Add(item.Copy());
                
            }

            return new Memento(_ContainerState);

        }
    }
}
