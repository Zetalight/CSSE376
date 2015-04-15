using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DominionSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibrary1
{
    [TestClass()]
    public class PlayerTest
    {
        [TestMethod()]
        public void TestThatPlayerInitializes()
        {
            Player p = new Player();
        }

        [TestMethod()]
        public void TestThatPlayerValuesInitialize()
        {
            Player p = new Player();
            Assert.AreEqual(0, p.coins);
            Assert.AreEqual(1, p.actions);
            Assert.AreEqual(1, p.buys);
        }
    }
}
