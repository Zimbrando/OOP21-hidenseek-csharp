using System;
using System.Collections.Generic;
using OOP_csharp.Entities;

namespace OOP_csharp.Components
{
    public interface IMap : IComponent
    {

        public ISet<KeyValuePair<int, int>> GameMap
        {
            get;
        }

        void MapEntities(ISet<IEntity> entities);

        ISet<KeyValuePair<int,int>> GetPath(KeyValuePair<int, int> source, KeyValuePair<int, int> dest);
    }
}

