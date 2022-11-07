using System;
using System.Collections.Generic;
using OOP_csharp.Entities;

namespace OOP_csharp.Components
{
    internal abstract class AbstractSense : AbstractComponent, ISense
    {

        private IDictionary<IEntity, eSenseConfidence> _entityMap;


        public AbstractSense()
        {
            _entityMap = new Dictionary<IEntity, eSenseConfidence>();
        }

        public ISet<IEntity> World => new HashSet<IEntity>(_entityMap.Keys);

        public eSenseConfidence Feel<T>(T e) where T : IEntity
        {
            eSenseConfidence conf = senseCheck(e);
            if (conf != eSenseConfidence.NONE)
            {
                _entityMap.Add(e, conf);
            }
            else
            {
                _entityMap.Remove(e);
            }
            return conf;
        }

        public abstract eSenseConfidence senseCheck(IEntity e);
    }
}

