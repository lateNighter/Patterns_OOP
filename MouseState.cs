using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Drawer
{
    class MouseState
    {

        private int _sx = 0, _sy = 0, _ex = 0, _ey = 0;
        private bool _pressed = false;

        public void Reset()
        {
            this.SX = 0;
            this.SY = 0;
            this.EX = 0;
            this.EY = 0;
            this.Pressed = false;
        }

        public int SX
        {
            get { return _sx; }
            set
            {
                if (_sx != value)
                {
                    _sx = value;
                }
            }
        }

        public int SY
        {
            get { return _sy; }
            set
            {
                if (_sy != value)
                {
                    _sy = value;
                }
            }
        }

        public int EX
        {
            get { return _ex; }
            set
            {
                if (_ex != value)
                {
                    _ex = value;
                }
            }
        }

        public int EY
        {
            get { return _ey; }
            set
            {
                if (_ey != value)
                {
                    _ey = value;
                }
            }
        }

        public bool Pressed
        {
            get { return _pressed; }
            set
            {
                if (_pressed != value)
                {
                    _pressed = value;
                }
            }
        }

    }
}
