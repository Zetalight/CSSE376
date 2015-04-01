using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DominionSharp;

namespace ClassLibrary1
{
    [TestClass()]
    public class CardTest
    {
        private TreasureCard T; //TODO: Change these to Cards
        private VictoryCard V;
        private ActionCard K;

        [TestInitialize()]
        public void setupTests()
        {
            this.T = new TreasureCopper(); //TODO: Replace these with new Treasure, Victory, and Kingdom Cards
            this.V = new VictoryEstate();
            this.K = new ActionChapel();
        }

        [TestMethod()]
        public void testCost()
        {
            Assert.AreEqual(0, T.Cost);
            Assert.AreEqual(2, V.Cost);
            Assert.AreEqual(2, K.Cost);
        }

        [TestMethod()]
        public void testName()
        {
            Assert.AreEqual("Copper", T.Name);
            Assert.AreEqual("Estate", V.Name);
            Assert.AreEqual("Chapel", K.Name);
        }

        [TestMethod()]
        public void testImage()
        {
            Assert.Fail("No test yet!");
        }
        [TestMethod()]
        public void testVictoryPoints()
        {
            Assert.AreEqual(1, V.VictoryPoints);
        }

        [TestMethod()]
        public void testValue()
        {
            Assert.AreEqual(1, T.Value);
        }
    }
}
