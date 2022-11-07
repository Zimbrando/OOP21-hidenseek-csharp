using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_csharp
{
    interface ILifeComponent : IComponent
    {
        public int MaxHealth
        { 
            get;
        }

        public int Health 
        {
            get; 
        }

        void Hurt(int damage);

        bool IsAlive();

    }
}
