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
    public class TreasureCardTest
    {
        [TestMethod()]
        public void TestTreasureCardsFunction()
        {
            Turn.Instance.reInitVals();
            TreasureCard tc = new TreasureCopper();
            tc.play();
            Assert.AreEqual(1, Turn.Instance.Coins);

            Turn.Instance.reInitVals();
            tc = new TreasureSilver();
            tc.play();
            Assert.AreEqual(2, Turn.Instance.Coins);

            Turn.Instance.reInitVals();
            tc = new TreasureGold();
            tc.play();
            Assert.AreEqual(3, Turn.Instance.Coins);
        }

    }
}
