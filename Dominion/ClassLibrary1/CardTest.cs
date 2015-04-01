using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibrary1
{
    [TestClass()]
    class CardTest
    {
        private int T; //TODO: Change these to Cards
        private int V;
        private int K;

        [TestInitialize()]
        public void setupTests()
        {
            this.T = 1; //TODO: Replace these with new Treasure, Victory, and Kingdom Cards
            this.V = 2;
            this.K = 3;
        }

        [TestMethod()]
        public void testCost()
        {
            Assert.Fail("No test yet!");
        }

        [TestMethod()]
        public void testName()
        {
            Assert.Fail("No test yet!");

        }

        [TestMethod()]
        public void testImage()
        {
            Assert.Fail("No test yet!");

        }
    }
}
