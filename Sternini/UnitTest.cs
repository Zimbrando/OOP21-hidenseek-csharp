using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace OOP_csharp
{
    [TestClass]
    internal class UnitTest
    {
        [TestMethod]
        public void TestExample()
        {
            IEntity entity = new Entity();
            Assert.AreEqual(0, entity.GetComponents().Count());
        }
    }
}
