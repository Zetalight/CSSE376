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
            Assert.AreEqual(5, p.getDeckSize());
            Assert.AreEqual(5, p.getHandSize());
        }

        [TestMethod()]
        public void TestPlayerInitializeValues()
        {
            Player p = new Player();
            Assert.AreEqual(5, p.getDeckSize());
            Assert.AreEqual(5, p.getHandSize());

            List<Card> cards = new List<Card>();
            cards.AddRange(p.getDeck());
            cards.AddRange(p.getHand());
            int coppers = 0;
            int estates = 0;
            for (int i = 0; i < cards.Count; i++)
            {
                if (cards[i] is TreasureCopper)
                {
                    coppers++;
                }
                else if (cards[i] is VictoryEstate)
                {
                    estates++;
                }
            }
            Assert.AreEqual(7, coppers);
            Assert.AreEqual(3, estates);
        }

        [TestMethod()]
        public void TestPlayerOverDraw()
        {
            Player p = new Player();
            for (int i = 0; i < 11; i++)
            {
                p.drawCard();
            }
        }

        [TestMethod()]
        public void TestPlayerGainsCard()
        {
            Player p = new Player();
            Assert.IsFalse(exists(p.getDiscard(), new ActionChapel()));
            p.gainCard(new ActionChapel());
            Assert.IsTrue(exists(p.getDiscard(), new ActionChapel()));
        }

        private Boolean exists(List<Card> clist, Card c)
        {
            foreach (Card c2 in clist)
            {
                if (c2.GetType() == c.GetType())
                    return true;
            }
            return false;
        }
    }
}
