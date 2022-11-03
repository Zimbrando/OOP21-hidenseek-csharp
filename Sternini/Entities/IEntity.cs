using System;
using System.Collections.Generic;

namespace OOP_csharp
{
    public interface IEntity
    {
        void Attach(IComponent component);

        void Detach(Type component);

        ISet<IComponent> GetComponents();

        IComponent GetComponent(Type component);

        bool HasComponent(Type component);
    }

}