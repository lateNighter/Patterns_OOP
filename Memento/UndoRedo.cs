using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Drawer
{
    public class UndoRedo : IUndoRedo
    {
        Caretaker _Caretaker = new Caretaker();
        MementoOriginator _MementoOriginator = null;

        public UndoRedo(Canvas container)
        {
            _MementoOriginator = new MementoOriginator(container);

        }
        public void Undo(int level)
        {
            Memento memento = null;
            for (int i = 1; i <= level; i++)
            {
                memento = _Caretaker.getUndoMemento();
            }
            if (memento != null)
            {
                _MementoOriginator.setMemento(memento);

            }
        }

        public void Redo(int level)
        {
            Memento memento = null;
            for (int i = 1; i <= level; i++)
            {
                memento = _Caretaker.getRedoMemento();
            }
            if (memento != null)
            {
                _MementoOriginator.setMemento(memento);

            }
        }

        public void SetStateForUndoRedo()
        {
            Memento memento = _MementoOriginator.getMemento();
            _Caretaker.InsertMementoForUndoRedo(memento);
        }

        public bool IsUndoPossible()
        {
            return _Caretaker.IsUndoPossible();

        }
        public bool IsRedoPossible()
        {
            return _Caretaker.IsRedoPossible();
        }
    }
}
