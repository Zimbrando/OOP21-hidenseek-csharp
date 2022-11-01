using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_csharp
{
    abstract class AbstractEntity : IEntity
    {
        private readonly ISet<IComponent> components;
        public AbstractEntity()
        {
            components = new HashSet<IComponent>();
        }

        public void Attach(IComponent component)
        {
            this.components.Add(component);
        }

        public void Detach(Type component)
        {
            components.ToList()
                .RemoveAll(c => c.GetType().Equals(component));
        }

        public IComponent GetComponent(Type component)
        {
            return components
                .Where(c => c.GetType().Equals(component))
                .First();
        }

        public ISet<IComponent> GetComponents()
        {
            return new HashSet<IComponent>(this.components);
        }

        public bool HasComponent(Type component)
        {
            return components
                .Where(c => c.GetType().Equals(component))
                .Any();
        }
    }
}
