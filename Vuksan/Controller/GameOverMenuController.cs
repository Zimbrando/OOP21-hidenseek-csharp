using System;
using System.Collections.Generic;
using System.Text;

namespace Vuksan.Controller
{
    class GameOverMenuController : IMenuController
    {
        private double _interfaceHeight;

        private double _interfaceWidth;

        public double Width { 
            get =>  _interfaceWidth;
            set => _interfaceWidth = value;
        }
        public double Height {
            get => _interfaceHeight;
            set => _interfaceHeight = value;
        }
    }
}
