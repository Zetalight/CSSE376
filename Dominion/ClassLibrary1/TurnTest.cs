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
        private Player p1;
        private Player p2;
        private Player p3;
        [TestInitialize()]
        public void setup()
        {
            p1 = new Player();
            p2 = new Player();
            p3 = new Player();
            List<Player> plist = new List<Player> {p1, p2, p3};
            Turn.Instance.instantiate(ref plist);
        }
        [TestMethod()]
        public void TestThatTurnInitializes()
        {
            Assert.AreEqual(p1, Turn.Instance.getActivePlayer());
            Assert.AreEqual(0, Turn.Instance.getCoins());
            Assert.AreEqual(1, Turn.Instance.getActions());
            Assert.AreEqual(1, Turn.Instance.getBuys());
            Assert.AreEqual(0, Turn.Instance.getTrashes());    
        }

        [TestMethod()]
        public void TestNextTurn()
        {
            Assert.AreEqual(0, Turn.Instance.getCoins());
            Assert.AreEqual(1, Turn.Instance.getActions());
            Assert.AreEqual(1, Turn.Instance.getBuys());
            Assert.AreEqual(0, Turn.Instance.getTrashes());
            Turn.Instance.setCoins(3);
            Turn.Instance.setActions(3);
            Turn.Instance.setBuys(3);
            Turn.Instance.setTrashes(3);
            Assert.AreEqual(3, Turn.Instance.getCoins());
            Assert.AreEqual(3, Turn.Instance.getActions());
            Assert.AreEqual(3, Turn.Instance.getBuys());
            Assert.AreEqual(3, Turn.Instance.getTrashes());
            Turn.Instance.nextTurn();
            Assert.AreEqual(p2, Turn.Instance.getActivePlayer());
            Assert.AreEqual(0, Turn.Instance.getCoins());
            Assert.AreEqual(1, Turn.Instance.getActions());
            Assert.AreEqual(1, Turn.Instance.getBuys());
            Assert.AreEqual(0, Turn.Instance.getTrashes());
            Turn.Instance.nextTurn();
            Assert.AreEqual(p3, Turn.Instance.getActivePlayer());
            Assert.AreEqual(0, Turn.Instance.getCoins());
            Assert.AreEqual(1, Turn.Instance.getActions());
            Assert.AreEqual(1, Turn.Instance.getBuys());
            Assert.AreEqual(0, Turn.Instance.getTrashes());
            Turn.Instance.nextTurn();
            Assert.AreEqual(p1, Turn.Instance.getActivePlayer());
            Assert.AreEqual(0, Turn.Instance.getCoins());
            Assert.AreEqual(1, Turn.Instance.getActions());
            Assert.AreEqual(1, Turn.Instance.getBuys());
            Assert.AreEqual(0, Turn.Instance.getTrashes());
        }
    }
}
