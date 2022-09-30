using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace Patterns_Drawer.Visitor
{
    public interface IVisitor
    {
        void Visit(Figure figure);
        void SetXY(float x, float y);
    }
}
