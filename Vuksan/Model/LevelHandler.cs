using System;
using System.Collections.Generic;
using System.Text;

namespace Vuksan.Model
{
    class LevelHandler : ILevelHandler
    {
        private readonly List<IGameLevel> _gameLevels;
        private int _currentLevel;

        public LevelHandler()
        {
            Reset();
        }

        public bool HasNext()
        {
            return _currentLevel < _gameLevels.Count;
        }

        public void Next() => _currentLevel++;

        public void Reset() => _currentLevel = 1;

        public IGameLevel GetCurrentLevel()
        {
            if (_currentLevel > _gameLevels.Count)
            {
                return null;
            }
            return _gameLevels[_currentLevel - 1];
        }
    }
}
