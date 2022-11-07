using System;
using System.Collections.Generic;
using System.Text;
using OOP_csharp.Entities;

namespace OOP_csharp.Components
{
    abstract class AbstractComponent : IComponent
    {
        public void Attach(IEntity e)
        {
        }

        public void Detach()
        {
        }

        public IEntity Owner
        {
            get => null;
            set
            {
            }
        }
    }
}
