using Fragozzi.Model.Entities;
using System;
using System.Windows;

namespace Fragozzi.Model.Components.Physics
{
    public class CollisionComponent : Component, ICollisionComponent
    {
        public IHitbox Hitbox { get; }

        public bool CollisionOrNearTo(IEntity entity, Point ownOffset)
        {
            throw new NotImplementedException();
        }

        public bool CollisionTo(IEntity entity, Point ownOffset)
        {
            throw new NotImplementedException();
        }

        public bool NearTo(IEntity entity, Point ownOffset)
        {
            throw new NotImplementedException();
        }

        public void OnCollision(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public void OnNear(IEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
