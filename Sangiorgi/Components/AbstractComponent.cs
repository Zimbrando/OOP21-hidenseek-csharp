using System;
using System.Collections.Generic;
using System.Text;
using OOP_csharp.Entities;

namespace OOP_csharp.Components
{
    abstract class AbstractComponent : IComponent
    {
        private IEntity _owner;

        public AbstractComponent()
        {
            _owner = null;
        }

        public void Attach(IEntity e)
        {
        }

        public void Detach()
        {
        }

        public IEntity Owner
        {
            get => _owner;
            set
            {
                _owner = value;
            }
        }
    }
}
