using Patterns_Drawer.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Drawer.CommandGroup
{
    internal interface IGroupCommand
    {
        void Execute(Canvas canvas);
        void SetStatus(List<object> status);
    }
}
