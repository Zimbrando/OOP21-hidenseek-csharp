using Fragozzi.Model.Entities;
using System.Windows;

namespace Fragozzi.Model.Components.Physics
{
    public interface ICollisionComponent : IComponent
    {
        IHitbox Hitbox { get; }

        void OnCollision(IEntity entity);
        void OnNear(IEntity entity);
        bool CollisionTo(IEntity entity, Point ownOffset);
        bool NearTo(IEntity entity, Point ownOffset);
        bool CollisionOrNearTo(IEntity entity, Point ownOffset);
    }
}
