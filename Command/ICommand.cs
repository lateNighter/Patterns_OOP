using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace Patterns_Drawer.Command
{
    public interface ICommand
    {
        void Execute(Figure figure);
        void SetStatus(List<object> status);
    }
}
