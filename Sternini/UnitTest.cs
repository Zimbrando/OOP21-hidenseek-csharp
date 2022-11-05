using NUnit.Framework;
using System.Linq;

namespace OOP_csharp
{
    [TestFixture]
    public class UnitTest
    {
        [Test]
        public void TestEntityComponent()
        {
            IEntity entity = new Entity();
            Assert.False(entity.GetComponents().Any());
            entity.Attach(new LifeComponent(100));
            Assert.True(entity.GetComponents().Any());
            IComponent component = entity.GetComponent(typeof(ILifeComponent));
            Assert.AreEqual(typeof(LifeComponent), component.GetType());
            entity.Detach(typeof(ILifeComponent));
            Assert.False(entity.GetComponents().Any());
        }

        [Test]
        public void TestSingleComponentType()
        {
            IEntity entity = new Entity();
            entity.Attach(new LifeComponent(100));
            entity.Attach(new LifeComponent(200));
            Assert.AreEqual(1, entity.GetComponents().Count);
            ILifeComponent life = entity.GetComponent(typeof(ILifeComponent)) as ILifeComponent;
            Assert.AreEqual(100, life.MaxHealth);
        }

        [Test]
        public void TestLifeComponent()
        {
            const int maxHealth = 100;
            const int damage = 10;
            ILifeComponent lifeComponent = new LifeComponent(maxHealth);
            Assert.AreEqual(maxHealth, lifeComponent.Health);
            lifeComponent.Hurt(damage);
            Assert.AreEqual(maxHealth - damage, lifeComponent.Health);
            lifeComponent.Hurt(maxHealth);
            Assert.False(lifeComponent.IsAlive());
        }

        [Test]
        public void TestInventoryComponent()
        {
            IInventoryComponent inventoryComponent = new InventoryComponent();
            Assert.AreEqual(0, inventoryComponent.GetQuantity(typeof(Key)));
            inventoryComponent.AddCollectible(new Key());
            inventoryComponent.AddCollectible(new Key());
            Assert.AreEqual(2, inventoryComponent.GetQuantity(typeof(Key)));
        }

    }
}
