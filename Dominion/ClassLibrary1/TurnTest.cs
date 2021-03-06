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
    public class TurnTest
    {
        private Player p1;
        private Player p2;
        private Player p3;
        List<Player> plist;
        [TestInitialize()]
        public void setup()
        {
            p1 = new Player();
            p2 = new Player();
            p3 = new Player();
            plist = new List<Player> {p1, p2, p3};
            Turn.Instance.instantiate(plist);
        }
        [TestMethod()]
        public void TestThatTurnInitializes()
        {
            Assert.AreEqual(p1, Turn.Instance.getActivePlayer());
            Assert.AreEqual(0, Turn.Instance.Coins);
            Assert.AreEqual(1, Turn.Instance.Actions);
            Assert.AreEqual(1, Turn.Instance.Buys);
            Assert.AreEqual(0, Turn.Instance.Trashes);    
        }

        [TestMethod()]
        public void TestNextTurn()
        {
            Assert.AreEqual(0, Turn.Instance.Coins);
            Assert.AreEqual(1, Turn.Instance.Actions);
            Assert.AreEqual(1, Turn.Instance.Buys);
            Assert.AreEqual(0, Turn.Instance.Trashes);
            Turn.Instance.Coins = (3);
            Turn.Instance.Actions = (3);
            Turn.Instance.Buys = (3);
            Turn.Instance.Trashes = (3);
            Assert.AreEqual(3, Turn.Instance.Coins);
            Assert.AreEqual(3, Turn.Instance.Actions);
            Assert.AreEqual(3, Turn.Instance.Buys);
            Assert.AreEqual(3, Turn.Instance.Trashes);
            Turn.Instance.nextTurn();
            Assert.AreEqual(p2, Turn.Instance.getActivePlayer());
            Assert.AreEqual(0, Turn.Instance.Coins);
            Assert.AreEqual(1, Turn.Instance.Actions);
            Assert.AreEqual(1, Turn.Instance.Buys);
            Assert.AreEqual(0, Turn.Instance.Trashes);
            Turn.Instance.nextTurn();
            Assert.AreEqual(p3, Turn.Instance.getActivePlayer());
            Assert.AreEqual(0, Turn.Instance.Coins);
            Assert.AreEqual(1, Turn.Instance.Actions);
            Assert.AreEqual(1, Turn.Instance.Buys);
            Assert.AreEqual(0, Turn.Instance.Trashes);
            Turn.Instance.nextTurn();
            Assert.AreEqual(p1, Turn.Instance.getActivePlayer());
            Assert.AreEqual(0, Turn.Instance.Coins);
            Assert.AreEqual(1, Turn.Instance.Actions);
            Assert.AreEqual(1, Turn.Instance.Buys);
            Assert.AreEqual(0, Turn.Instance.Trashes);
        }

        [TestMethod()]
        public void TestGetPlayers()
        {
            Assert.AreEqual(plist, Turn.Instance.Players);
        }
        
        [TestMethod()]
        public void TestPhases()
        {

            //Number of Players
            int numberOfPlayers = 3; //Must be at least 2
            int numberOfTests = 20;
            //Council Room Test
            FormGame game = new FormGame();
            game.setPlayerCount(numberOfPlayers);
            Turn.Phases currentPhase;
            Turn.Phases newPhase;
            for(int i = 0; i < numberOfTests; i++){
            currentPhase = Turn.Instance.Phase;
            Turn.Instance.nextPhase();
            newPhase = Turn.Instance.Phase;
            if(currentPhase.Equals(Turn.Phases.Action)){
                Assert.AreEqual(Turn.Phases.Buy, newPhase);
            }
            else if (currentPhase.Equals(Turn.Phases.Buy))
            {
                Assert.AreEqual(Turn.Phases.Cleanup, newPhase);
            }
            else if (currentPhase.Equals(Turn.Phases.Cleanup))
            {
                Assert.AreEqual(Turn.Phases.Draw, newPhase);
            }
            else if (currentPhase.Equals(Turn.Phases.Draw))
            {
                Assert.AreEqual(Turn.Phases.Action, newPhase);
            }
            else
            {
                Assert.Fail("The Phase is not a valid phase ( Action, Buy, Cleanup, or Draw)");
            }
            }
        }
    }
}
