using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_csharp
{
    abstract class AbstractEntity : IEntity
    {
        private ISet<IComponent> _components;
        public AbstractEntity()
        {
            _components = new HashSet<IComponent>();
        }

        public void Attach(IComponent component) => _components.Add(component);

        public void Detach(Type component)
        {
            ISet<IComponent> _toRemove = _components.
                Where(c => component.IsInstanceOfType(c)).ToHashSet();
            _components
                .ExceptWith(_toRemove.AsEnumerable());
        }

        public IComponent GetComponent(Type component)
        {
            return _components
                .Where(c => component.IsInstanceOfType(c))
                .First();
        }

        public ISet<IComponent> GetComponents()
        {
            return new HashSet<IComponent>(this._components);
        }

        public bool HasComponent(Type component)
        {
            return _components
                .Where(c => component.IsInstanceOfType(c))
                .Any();
        }
    }
}
