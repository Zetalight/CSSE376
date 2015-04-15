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
        [TestMethod()]
        public void TestPlayerGetSets()
        {
            Player p = new Player();
            Assert.AreEqual(0, p.getCoins());
            Assert.AreEqual(1, p.getActions());
            Assert.AreEqual(1, p.getBuys);
            p.setCoins(2);
            p.setActions(2);
            p.setBuys(2);
            Assert.AreEqual(2, p.getCoins());
            Assert.AreEqual(2, p.getActions());
            Assert.AreEqual(2, p.getBuys());
        }
    }
}
