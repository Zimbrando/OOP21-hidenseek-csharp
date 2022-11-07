using System;
using System.Collections.Generic;
using System.Text;
using OOP_csharp.Entities;

namespace OOP_csharp.Components
{
    public interface IComponent
    {
        void Attach(IEntity e);

        void Detach();

        IEntity Owner { get; set; }
    }
}
