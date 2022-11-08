using NUnit.Framework;
using OOP_csharp.Components;
using OOP_csharp.Entities;
using System.Collections.Generic;
using System.Linq;

namespace OOP_csharp
{
    [TestFixture]
    public class UnitTest
    {
        [Test]
        public void TestSenseComponent()
        {
            IEntity entity1 = new Entity();
            ISense sight = new SightSense(100);
            IPosition pos1 = new Position(0, 0);
            Assert.True(entity1.Components.Count == 0);
            entity1.Attach(sight);
            entity1.Attach(pos1);

            Assert.True(entity1.Components.Count == 2);

            IEntity entity2 = new Entity();
            IPosition pos2 = new Position(50, 0);
            Assert.True(entity2.Components.Count == 0);
            entity2.Attach(pos2);
            Assert.True(entity2.Components.Count == 1);

            // check entity1 sight
            eSenseConfidence feeling = ((ISense)(entity1.GetComponent(typeof(ISense)))).Feel(entity2);
            Assert.True(feeling != eSenseConfidence.NONE);
            // check entity1 sight
            pos2.Position = new KeyValuePair<int, int>(150, 0);
            eSenseConfidence feeling2 = ((ISense)(entity1.GetComponent(typeof(ISense)))).Feel(entity2);
            Assert.True(feeling2 == eSenseConfidence.NONE);


        }

    }
}
