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
    public class ActionCards
    {
        private ActionCard A;

        [TestMethod()]
        public void TestThatActionCardsCanInitialize()
        {
            A = new ActionChapel();
            A = new ActionVillage();
            A = new ActionWitch();
            A = new ActionCellar();
        }
        [TestMethod()]
        public void TestActionCardsCost()
        {
            //Costs 2
            A = new ActionChapel();
            Assert.AreEqual(2, A.Cost);
            A = new ActionCellar();
            Assert.AreEqual(2, A.Cost);

            //Costs 3
            A = new ActionVillage();
            Assert.AreEqual(3, A.Cost);

            //Costs 4

            //Costs 5
            A = new ActionWitch();
            Assert.AreEqual(5, A.Cost);

            //Costs 6
        }
    }
}
