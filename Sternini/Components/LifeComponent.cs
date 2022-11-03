using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_csharp
{
    class LifeComponent : AbstractComponent, ILifeComponent
    {
        public int MaxHealth { get; }
        public int Health { get; private set; }

        public LifeComponent(int maxHealth)
        {
            MaxHealth = maxHealth;
            Health = maxHealth;
        }

        public void Hurt(int damage) => Health -= damage;

        public bool IsAlive()
        {
            return Health > 0;
        }

    }
}
