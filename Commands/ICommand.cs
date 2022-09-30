using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Drawer.Commands
{
    public interface ICommand<T>
    {
        T Execute();
    }
}
