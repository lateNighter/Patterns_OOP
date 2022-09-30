using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Drawer
{
    public abstract class Creator
    {

        public abstract Figure Create(float X, float Y, float Width, float Height);
    }
}
