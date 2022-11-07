using System;
using System.Collections.Generic;
using System.Text;

namespace Vuksan.Model
{
    interface ILevelHandler
    {
        void Next();
 
        Boolean HasNext();

        void Reset();

#nullable enable
        IGameLevel? GetCurrentLevel();
    }
}
