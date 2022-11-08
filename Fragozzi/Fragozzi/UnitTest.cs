using Fragozzi.Model.Components.Physics;
using Fragozzi.Model.Entities;
using NUnit.Framework;
using System.Windows;

namespace Fragozzi
{
    [TestFixture]
    public class UnitTest
    {
        [Test]
        public void TestCollisionComponent()
        {
            Point offset = new Point(0, 0);

            //CREATE ENTITY1
            IEntity entity1 = null; //new Entity();
            //Position component
            IPositionComponent positionComponent1 = new PositionComponent();
            positionComponent1.Position = new Point(100, 10);
            entity1.Attach(positionComponent1);
            //Move component
            IMoveComponent moveComponent1 = new MoveComponent(1);
            entity1.Attach(moveComponent1);
            //Material component
            IMaterialComponent materialComponent1 = new MaterialComponent();
            entity1.Attach(materialComponent1);
            //Collision component
            ICollisionComponent collisionComponent1 = new CollisionComponent();
            collisionComponent1.Hitbox.AddPoint(new Point(0, 0));
            collisionComponent1.Hitbox.AddPoint(new Point(0, 30));
            collisionComponent1.Hitbox.AddPoint(new Point(30, 30));
            collisionComponent1.Hitbox.AddPoint(new Point(30, 0));
            entity1.Attach(collisionComponent1);

            //CREATE ENTITY2
            IEntity entity2 = null; //new Entity();
            //Position component
            PositionComponent positionComponent2 = new PositionComponent();
            entity2.Attach(positionComponent2);
            //Move component
            MoveComponent moveComponent2 = new MoveComponent(1);
            entity2.Attach(moveComponent2);
            //Material component
            MaterialComponent materialComponent2 = new MaterialComponent();
            entity2.Attach(materialComponent2);
            //Collision component
            CollisionComponent collisionComponent2 = new CollisionComponent();
            collisionComponent2.Hitbox.AddPoint(new Point(0, 0));
            collisionComponent2.Hitbox.AddPoint(new Point(0, 30));
            collisionComponent2.Hitbox.AddPoint(new Point(30, 30));
            collisionComponent2.Hitbox.AddPoint(new Point(30, 0));
            entity2.Attach(collisionComponent2);


            //intersection
            positionComponent2.Position = new Point(110, 110);
            Assert.True(collisionComponent1.CollisionTo(entity2, offset) && collisionComponent2.CollisionTo(entity1, offset));
            Assert.True(collisionComponent1.CollisionTo(entity2, offset) && collisionComponent2.CollisionTo(entity1, offset));

            //one side overlapped
            positionComponent2.Position = new Point(110, 70);
            Assert.False(collisionComponent1.CollisionTo(entity2, offset)); // || collisionComponent2.CollisionTo(entity1, offset)
            Assert.True(collisionComponent1.NearTo(entity2, offset) && collisionComponent2.NearTo(entity1, offset));
            positionComponent2.Position = new Point(130, 110);
            Assert.False(collisionComponent1.CollisionTo(entity2, offset) || collisionComponent2.CollisionTo(entity1, offset));
            Assert.True(collisionComponent1.NearTo(entity2, offset) && collisionComponent2.NearTo(entity1, offset));
            positionComponent2.Position = new Point(90, 130);
            Assert.False(collisionComponent1.CollisionTo(entity2, offset) || collisionComponent2.CollisionTo(entity1, offset));
            Assert.True(collisionComponent1.NearTo(entity2, offset) && collisionComponent2.NearTo(entity1, offset));
            positionComponent2.Position = new Point(70, 90);
            Assert.False(collisionComponent1.CollisionTo(entity2, offset) || collisionComponent2.CollisionTo(entity1, offset));
            Assert.True(collisionComponent1.NearTo(entity2, offset) && collisionComponent2.NearTo(entity1, offset));

            //one point overlapped
            positionComponent2.Position = new Point(70, 70);
            Assert.False(collisionComponent1.CollisionTo(entity2, offset) || collisionComponent2.CollisionTo(entity1, offset));
            Assert.True(collisionComponent1.NearTo(entity2, offset) && collisionComponent2.NearTo(entity1, offset));
            positionComponent2.Position = new Point(130, 70);
            Assert.False(collisionComponent1.CollisionTo(entity2, offset) || collisionComponent2.CollisionTo(entity1, offset));
            Assert.True(collisionComponent1.NearTo(entity2, offset) && collisionComponent2.NearTo(entity1, offset));
            positionComponent2.Position = new Point(130, 130);
            Assert.False(collisionComponent1.CollisionTo(entity2, offset) || collisionComponent2.CollisionTo(entity1, offset));
            Assert.True(collisionComponent1.NearTo(entity2, offset) && collisionComponent2.NearTo(entity1, offset));
            positionComponent2.Position = new Point(70, 130);
            Assert.False(collisionComponent1.CollisionTo(entity2, offset) || collisionComponent2.CollisionTo(entity1, offset));
            Assert.True(collisionComponent1.NearTo(entity2, offset) && collisionComponent2.NearTo(entity1, offset));

        }

    }
}
