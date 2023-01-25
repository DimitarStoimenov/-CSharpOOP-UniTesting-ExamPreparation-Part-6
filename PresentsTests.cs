namespace Presents.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class PresentsTests
    {
        [Test]

        public void ChecksPressentProp()
        {
            Present present = new Present("Ball", 10.10);
            Assert.AreEqual(present.Name, "Ball");
            Assert.AreEqual(present.Magic, 10.10);

        }

        [Test]

        public void ChecksCreateThrows()
        {
            Present present = null;
            Bag bag = new Bag();
            Assert.Throws<ArgumentNullException>(() => bag.Create(present));

        }
        [Test]

        public void ChecksCreateThrowsNameEx()
        {
            Present present = new Present("Ball", 10.19);
            Bag bag = new Bag();
            bag.Create(present);
            Assert.Throws<InvalidOperationException>(() => bag.Create(present));

        }
        [Test]

        public void ChecksCreatePresent()
        {
            Present present = new Present("Ball", 10.19);
            Bag bag = new Bag();
            bag.Create(present);

            Assert.AreEqual(bag.GetPresent("Ball"), present);

        }
        [Test]

        public void Checksremoves()
        {
            Present present = new Present("Ball", 10.19);
            Bag bag = new Bag();
            bag.Create(present);
            
            Assert.IsTrue(bag.Remove(present));

        }

        [Test]

        public void ChecksGetPerLessMagic()
        {
            Present present = new Present("Ball", 10.19);
            Present present1 = new Present("BallY", 10.20);
            Bag bag = new Bag();
            bag.Create(present);
            bag.Create(present1);

            Assert.AreEqual(bag.GetPresentWithLeastMagic(), present);

        }





    }
}
