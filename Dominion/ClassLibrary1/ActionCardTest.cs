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
            A = new ActionMoat();
            A = new ActionChancellor();
            A = new ActionWoodcutter();
        }
        [TestMethod()]
        public void TestActionCardsValues()
        {
            //Costs 2
            A = new ActionChapel();
            Assert.AreEqual(2, A.Cost);
            Assert.AreEqual("Chapel", A.Name);
            A = new ActionCellar();
            Assert.AreEqual(2, A.Cost);
            Assert.AreEqual("Cellar", A.Name);
            A = new ActionMoat();
            Assert.AreEqual(2, A.Cost);
            Assert.AreEqual("Moat", A.Name);

            //Costs 3
            A = new ActionVillage();
            Assert.AreEqual(3, A.Cost);
            Assert.AreEqual("Village", A.Name);
            A = new ActionChancellor();
            Assert.AreEqual(3, A.Cost);
            Assert.AreEqual("Chancellor", A.Name);
            A = new ActionWoodcutter();
            Assert.AreEqual(3, A.Cost);
            Assert.AreEqual("Woodcutter", A.Name);

            //Costs 4

            //Costs 5
            A = new ActionWitch();
            Assert.AreEqual(5, A.Cost);
            Assert.AreEqual("Witch", A.Name);

            //Costs 6
        }
    }
}
