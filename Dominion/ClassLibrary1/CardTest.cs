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
    class CardTest
    {
        private Card T; //TODO: Change these to Cards
        private Card V;
        private int K;

        [TestInitialize()]
        public void setupTests()
        {
            this.T = new TreasureCopper(); //TODO: Replace these with new Treasure, Victory, and Kingdom Cards
            this.V = new VictoryEstate();
            this.K = 3;
        }

        [TestMethod()]
        public void testCost()
        {
            Assert.AreEqual(0, T.Cost);
            Assert.AreEqual(2, V.Cost);
        }

        [TestMethod()]
        public void testName()
        {
            Assert.AreEqual("Copper", T.Name);
            Assert.AreEqual("Estate", V.Name);
        }

        [TestMethod()]
        public void testImage()
        {
            Assert.Fail("No test yet!");
        }
    }
}
