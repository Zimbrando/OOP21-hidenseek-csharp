using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_csharp
{
    interface ILifeComponent
    {
        void Hurt(int damage);

        bool IsAlive();

    }
}
