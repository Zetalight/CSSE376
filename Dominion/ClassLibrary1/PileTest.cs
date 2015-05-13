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
    public class PileTest
    {
        [TestMethod()]
        public void TestPileVariableConstructor()
        {
            Pile p = new Pile(new AttackWitch(), 2);
            Card c = new AttackWitch();
            Assert.AreEqual(c.GetType(), p.getCard().GetType());
            Assert.AreEqual(2, p.getCount());
            p.draw();
            Assert.AreEqual(1, p.getCount());
        }

        [TestMethod()]
        public void TestPileNormalConstructor()
        {
            Pile p = new Pile(new AttackWitch());
            Assert.AreEqual(10, p.getCount());
        }

        [TestMethod()]
        public void TestPileDecrementsOnDraw()
        {
            Pile p = new Pile(new AttackWitch(), 2);
            p.draw();
            Assert.AreEqual(1, p.getCount());
        }

        [TestMethod()]
        public void TestPileReportsEmpty()
        {
            Pile p = new Pile(new AttackWitch(), 2);
            Assert.IsTrue(p.draw());
            Assert.IsFalse(p.draw());
        }
    }
}
