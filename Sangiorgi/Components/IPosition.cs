using System;
using System.Collections.Generic;

namespace OOP_csharp.Components
{
    public interface IPosition : IComponent
    {

        KeyValuePair<int, int> Position { get; set; }

    }
}

