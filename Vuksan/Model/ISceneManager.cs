using System;
using System.Collections.Generic;
using System.Text;
using Vuksan.Controller;

namespace Vuksan.Model
{
    interface ISceneManager
    {
        void AddScreenController(String name, IMenuController controller);

        void RemoveScreenController(String name);

        IMenuController GetSceneControllerByName(String name);
    }
}
