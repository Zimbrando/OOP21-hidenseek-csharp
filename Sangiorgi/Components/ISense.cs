using System;
using System.Collections.Generic;
using OOP_csharp.Entities;

namespace OOP_csharp.Components
{
    interface ISense : IComponent
    {

        public ISet<IEntity> World
        {
            get;
        }

        eSenseConfidence Feel<T>(T e) where T : IEntity;

    }
}

