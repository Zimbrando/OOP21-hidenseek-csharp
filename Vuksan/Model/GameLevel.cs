using System;
using System.Collections.Generic;
using System.Text;

namespace Vuksan.Model
{
    class GameLevel : IGameLevel
    {
        private readonly int _levelID;

        public int LevelID
        {
            get => _levelID;
        }

        public GameLevel(int levelID)
        {
            _levelID = levelID;
        }
    }
}
