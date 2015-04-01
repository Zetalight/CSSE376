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
    public class TurnTest
    {
        [TestMethod()]
        public void TestThatTreasureInitializes()
        {
            var target = new FormGame();
            Assert.AreEqual(target.getLabel3Text(), "Coins: 0");
        }

        [TestMethod()]
        public void TestThatActionsInitializes()
        {
            var target = new FormGame();
            Assert.AreEqual(target.getLabel2Text(), "Buys: 1");
        }

        [TestMethod()]
        public void TestThatBuysInitializes()
        {
            var target = new FormGame();
            Assert.AreEqual(target.getLabel1Text(), "Actions: 1");
        }
    }
}