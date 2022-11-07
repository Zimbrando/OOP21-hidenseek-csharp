using System;
using OOP_csharp.Entities;

namespace OOP_csharp.Components
{
    abstract class AbstractHeart : AbstractComponent, IHeart
    {
        private eHeart _heart;

        public AbstractHeart()
        {
        }

        public eHeart Heart => _heart;

        protected void setHeart(eHeart heart)
        {
            _heart = heart;
        }

        public abstract bool Hates<T>(T e) where T : IEntity;

        public abstract bool Loves<T>(T e) where T : IEntity;
    }
}

