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
            entity.Detach(typeof(ILifeComponent));
            Assert.False(entity.GetComponents().Any());

            entity.Attach(new LifeComponent(100));
            entity.Attach(new LifeComponent(200));
            Assert.AreEqual(1, entity.GetComponents().Count);
            LifeComponent life = entity.GetComponent(typeof(ILifeComponent)) as LifeComponent;
            Assert.AreEqual(100, life.MaxHealth);
        }
    }
}
