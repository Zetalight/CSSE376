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
    public class InitTest
    {
        [TestMethod()]
        public void TestThatTreasureInitializes()
        {
            var target = new FormGame();
            Assert.AreEqual(target.getCoinsText(), "Coins: 0");
        }

        [TestMethod()]
        public void TestThatActionsInitializes()
        {
            var target = new FormGame();
            Assert.AreEqual(target.getBuysText(), "Buys: 1");
        }

        [TestMethod()]
        public void TestThatBuysInitializes()
        {
            var target = new FormGame();
            Assert.AreEqual(target.getActionsText(), "Actions: 1");
        }
    }
}