using NUnit.Framework;
using System.Linq;

namespace OOP_csharp
{
    [TestFixture]
    public class UnitTest
    {
        [Test]
        public void TestExample()
        {
            IEntity entity = new Entity();
            Assert.AreEqual(0, entity.GetComponents().Count());
        }
    }
}
