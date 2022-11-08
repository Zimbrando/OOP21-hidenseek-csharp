using System;
using System.Collections.Generic;
using System.Linq;
using OOP_csharp.Components;

namespace OOP_csharp.Entities
{
    abstract class AbstractEntity : IEntity
    {
        private ISet<IComponent> _components;

        public AbstractEntity()
        {
            _components = new HashSet<IComponent>();
        }

        public ISet<IComponent> Components => _components;

        public void Attach(IComponent comp)
        {
            comp.Owner = this;
            _components.Add(comp);
        }

        public void Detach(Type component)
        {
            IComponent comp = GetComponent(component);
            _components.Remove(comp);
            comp.Owner = null;
        }

        public IComponent GetComponent(Type component)
        {
            return _components.Where(c => component.IsInstanceOfType(c)).First();
        }

    }
}
