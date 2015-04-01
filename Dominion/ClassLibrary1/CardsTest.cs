using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DominionSharp;
using NUnit.Framework;

namespace ClassLibrary1
{
    [TestFixture()]
    public class CardsTest
    {
        [Test()]
        public void TestThatTreasureInitializes()
        {
            var target = new FormGame();
            Assert.AreEqual(target.getLabel3Text(), "Coins: 0");
        }

        [Test()]
        public void TestThatActionsInitializes()
        {
            var target = new FormGame();
            Assert.AreEqual(target.getLabel2Text(), "Buys: 1");
        }

        [Test()]
        public void TestThatBuysInitializes()
        {
            var target = new FormGame();
            Assert.AreEqual(target.getLabel1Text(), "Actions: 1");
        }
    }
}