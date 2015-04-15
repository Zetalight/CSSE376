﻿using System;
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
            A = new ActionMilita();
            Assert.AreEqual(4, A.Cost);
            Assert.AreEqual("Milita", A.Name);

            //Costs 5
            A = new ActionWitch();
            Assert.AreEqual(5, A.Cost);
            Assert.AreEqual("Witch", A.Name);


            //Costs 6
        }
    }
}
