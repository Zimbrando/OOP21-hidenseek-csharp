using System;
using System.Collections.Generic;
using System.Linq;
using OOP_csharp.Components;

namespace OOP_csharp.Entities
{
    abstract class AbstractEntity : IEntity
    {
        public ISet<IComponent> Components => new HashSet<IComponent>();

        public void Attach(IComponent comp)
        {
        }

        public void Detach(Type component)
        {
        }

        public IComponent getComponent(Type component)
        {
            return null;
        }

        public IComponent GetComponent(Type component)
        {
            return null;
        }

    }
}
