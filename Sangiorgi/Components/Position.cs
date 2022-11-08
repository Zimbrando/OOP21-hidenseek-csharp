using System;
using System.Collections.Generic;

namespace OOP_csharp.Components
{
    class Position : AbstractComponent, IPosition
    {
        private KeyValuePair<int, int> _position;

        public Position(int x, int y)
        {
            _position = new KeyValuePair<int, int>(x, y);
        }

        KeyValuePair<int, int> IPosition.Position { get => _position; set => _position = value; }
    }
}

