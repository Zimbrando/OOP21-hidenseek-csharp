using System;
using System.Collections.Generic;
using System.Text;
using Vuksan.Controller;

namespace Vuksan.Model
{
    class SceneManager : ISceneManager
    {
        private readonly IDictionary<string, IMenuController> _sceneController;

        public SceneManager() => _sceneController = new Dictionary<string, IMenuController>();
        

        public void AddScreenController(string name, IMenuController controller)
        {
            _sceneController.Add(name, controller);
        }

        public void RemoveScreenController(string name)
        {
            _sceneController.Remove(name);
        }

        public IMenuController GetSceneControllerByName(string name)
        {
            return _sceneController[name];
        }

    }
}
