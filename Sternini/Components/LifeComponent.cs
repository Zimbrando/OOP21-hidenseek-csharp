using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_csharp
{
    class LifeComponent : AbstractComponent, ILifeComponent
    {
        private int _health;
        private readonly int _maxHealth;

        public int Health
        {
            get => _health;
            private set => _health = value;
        }

        public int MaxHealth
        {
            get => _maxHealth;
        }

        public LifeComponent(int maxHealth)
        {
            _maxHealth = maxHealth;
            _health = maxHealth;
        }

        public void Hurt(int damage) => _health -= damage;

        public bool IsAlive()
        {
            return _health > 0;
        }

    }
}
