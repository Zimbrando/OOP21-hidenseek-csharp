using System;
using System.Collections.Generic;
using System.ComponentModel;
using OOP_csharp.Components;
using IComponent = OOP_csharp.Components.IComponent;

namespace OOP_csharp.Entities
{
    public interface IEntity
    {
        public ISet<IComponent> Components
        {
            get;
        }

        void Attach(IComponent comp);

        void Detach(Type component);

        IComponent GetComponent(Type component);
    }

}