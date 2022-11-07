using System;
using System.Collections.Generic;
using OOP_csharp.Entities;

namespace OOP_csharp.Components
{
    class GPSMap : AbstractComponent, IMap
    {
        private ISet<KeyValuePair<int, int>> _entityPos;
        private ISet<KeyValuePair<int, int>> _gameMap;
        private IDictionary<KeyValuePair<KeyValuePair<int, int>, KeyValuePair<int, int>>, ISet<KeyValuePair<int, int>>> _gamePaths;


        public GPSMap()
        {
            _gamePaths = new Dictionary<KeyValuePair<KeyValuePair<int, int>, KeyValuePair<int, int>>, ISet<KeyValuePair<int, int>>>();
            _entityPos = new HashSet<KeyValuePair<int, int>>();
            _gameMap = new HashSet<KeyValuePair<int, int>>();
        }

        public ISet<KeyValuePair<int, int>> GameMap => _gameMap;

        public ISet<KeyValuePair<int, int>> GetPath(KeyValuePair<int, int> source, KeyValuePair<int, int> dest)
        {
            return _gamePaths[new KeyValuePair<KeyValuePair<int, int>, KeyValuePair<int, int>>(source, dest)];
        }

        public void MapEntities(ISet<IEntity> entities)
        {
        }
    }
}

