﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Drawer
{
    public interface IDrawable
    {
        void Draw(Graphics g, Color color);
    }
}
