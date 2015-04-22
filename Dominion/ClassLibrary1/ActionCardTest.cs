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
            A = new ActionWorkshop();
            A = new ActionBureaucrat();
            A = new ActionFeast();
            //A = new ActionGardens();
            A = new ActionMilitia();
            A = new ActionMoneylender();
            A = new ActionRemodel();
            A = new ActionSmithy();
            A = new ActionSpy();
            A = new ActionThief();
            A = new ActionThroneRoom();
            A = new ActionCouncilRoom();
            A = new ActionFestival();
            A = new ActionLaboratory();
            A = new ActionLibrary();
            A = new ActionMarket();
            A = new ActionMine();
            A = new ActionAdventure();
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
            A = new ActionWorkshop();
            Assert.AreEqual(3, A.Cost);
            Assert.AreEqual("Workshop", A.Name);

            //Costs 4
            A = new ActionBureaucrat();
            Assert.AreEqual(4, A.Cost);
            Assert.AreEqual("Bureaucrat", A.Name);
            A = new ActionFeast();
            Assert.AreEqual(4, A.Cost);
            Assert.AreEqual("Feast", A.Name);
            //A = new ActionGardens(); //Do We want to put as ActionCard or Victory Card. Bought like Action, used like Victory.
            //Assert.AreEqual(4, A.Cost);
            //Assert.AreEqual("Gardens", A.Name);
            A = new ActionMilitia();
            Assert.AreEqual(4, A.Cost);
            Assert.AreEqual("Militia", A.Name);
            A = new ActionMoneylender();
            Assert.AreEqual(4, A.Cost);
            Assert.AreEqual("Moneylender", A.Name);
            A = new ActionRemodel();
            Assert.AreEqual(4, A.Cost);
            Assert.AreEqual("Remodel", A.Name);
            A = new ActionSmithy();
            Assert.AreEqual(4, A.Cost);
            Assert.AreEqual("Smithy", A.Name);
            A = new ActionSpy();
            Assert.AreEqual(4, A.Cost);
            Assert.AreEqual("Spy", A.Name);
            A = new ActionThief();
            Assert.AreEqual(4, A.Cost);
            Assert.AreEqual("Thief", A.Name);
            A = new ActionThroneRoom();
            Assert.AreEqual(4, A.Cost);
            Assert.AreEqual("Throne Room", A.Name);

            //Costs 5
            A = new ActionWitch();
            Assert.AreEqual(5, A.Cost);
            Assert.AreEqual("Witch", A.Name); 
            A = new ActionCouncilRoom();
            Assert.AreEqual(5, A.Cost);
            Assert.AreEqual("Council Room", A.Name);
            A = new ActionFestival();
            Assert.AreEqual(5, A.Cost);
            Assert.AreEqual("Festival", A.Name);
            A = new ActionLaboratory();
            Assert.AreEqual(5, A.Cost);
            Assert.AreEqual("Laboratory", A.Name);
            A = new ActionLibrary();
            Assert.AreEqual(5, A.Cost);
            Assert.AreEqual("Library", A.Name);
            A = new ActionMarket();
            Assert.AreEqual(5, A.Cost);
            Assert.AreEqual("Market", A.Name);
            A = new ActionMine();
            Assert.AreEqual(5, A.Cost);
            Assert.AreEqual("Mine", A.Name);

            //Costs 6
            A = new ActionAdventure();
            Assert.AreEqual(6, A.Cost);
            Assert.AreEqual("Adventure", A.Name);
        }
        [TestMethod()]
        public void TestActionCardFunctions()
        {
            Player B = new Player();
            A = new ActionWoodcutter();
            A.play(B);
            Assert.AreEqual(B.getBuys(), 2);
            Assert.AreEqual(B.getCoins(), 2);

        }
    }
}
