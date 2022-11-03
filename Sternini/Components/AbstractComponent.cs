using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_csharp
{
    abstract class AbstractComponent : IComponent
    {
        public override bool Equals(object obj)
        {
            return obj.GetType().Equals(GetType());
        }

        public override int GetHashCode()
        {
            return GetType().FullName.GetHashCode();
        }
    }
}
