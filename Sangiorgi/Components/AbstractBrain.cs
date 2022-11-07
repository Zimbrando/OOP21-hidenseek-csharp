using System;
using OOP_csharp.Components;
using System.Collections.Generic;
using OOP_csharp.Entities;

namespace OOP_csharp.Components
{
    abstract class AbstractBrain : AbstractComponent, IBrain
    {

        private IDictionary<eHeart, Predicate<IEntity>> _mapIsTargetable;
        private IDictionary<eHeart, Func<IEntity, IEntity, IEntity>> _mapConfrontTargetables;
        private IDictionary<eHeart, Action<IEntity, ISet<IEntity>>> _macActionOnTarget;

        public AbstractBrain()
        {
            _mapIsTargetable = new Dictionary<eHeart, Predicate<IEntity>>();
            _mapConfrontTargetables = new Dictionary<eHeart, Func<IEntity, IEntity, IEntity>>();
            _macActionOnTarget = new Dictionary<eHeart, Action<IEntity, ISet<IEntity>>>();
        }

        public void NeuroImpulse()
        {
        }
    }
}

