using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DominionSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace ClassLibrary1
{
    [TestClass()]
    public class AttackCardTest
    {
        private AttackCard A;
        public static List<bool> defendList = new List<bool>{true, false, true, false};
        public static List<bool> spyDiscardList = new List<bool> { false, true, true, false };

        private class FakeAttackWitch : AttackWitch
        {
            protected override bool defend(int playerNum)
            {
                return AttackCardTest.defendList[playerNum];
            }
        }

        private class FakeAttackBureaucrat : AttackBureaucrat
        {
            private String myReveal = "";

            protected override void attack(int playerNum)
            {
                myReveal += reveal(playerNum);
            }
            protected override bool defend(int playerNum)
            {
                return AttackCardTest.defendList[playerNum];
            }

            public String getReveal()
            {
                return myReveal;
            }
        }

        private class FakeAttackSpy : AttackSpy
        {
            private String myReveal = "";

            protected override void attack(int playerNum)
            {
                myReveal += reveal(playerNum);
                if (AttackCardTest.spyDiscardList[playerNum])
                {
                    Turn.Instance.Players[playerNum].discardTopCardOfDeck();
                }
            }

            protected override bool defend(int playerNum)
            {
                return AttackCardTest.defendList[playerNum];
            }

            public String getReveal()
            {
                return myReveal;
            }
        }

        private class FakeAttackThief : AttackThief
        {
            public override void play()
            {
            }

            protected override bool defend(int playerNum)
            {
                return AttackCardTest.defendList[playerNum];
            }
        }

        private class FakeAttackMilitia : AttackMilitia
        {
            protected override void attack(int playerNum)
            {
                List<Card> cards = Turn.Instance.Players[playerNum].getHand();
                Random rng = new Random();
                while (cards.Count > 3)
                {
                    cards.RemoveAt((int)rng.Next(cards.Count));
                }
            }
            protected override bool defend(int playerNum)
            {
                return AttackCardTest.defendList[playerNum];
            }
        }

        [TestMethod()]
        public void TestThatAttackCardsCanInitialize()
        {
            A = new AttackWitch();
            A = new AttackBureaucrat();
            A = new AttackMilitia();
            A = new AttackSpy();
            A = new AttackThief();
        }
        [TestMethod()]
        public void TestAttackCardsValues()
        {
            //Costs 4
            A = new AttackBureaucrat();
            Assert.AreEqual(4, A.Cost);
            Assert.AreEqual("Bureaucrat", A.Name);
            A = new AttackMilitia();
            Assert.AreEqual(4, A.Cost);
            Assert.AreEqual("Militia", A.Name);
            A = new AttackSpy();
            Assert.AreEqual(4, A.Cost);
            Assert.AreEqual("Spy", A.Name);
            A = new AttackThief();
            Assert.AreEqual(4, A.Cost);
            Assert.AreEqual("Thief", A.Name);
            //Costs 5
            A = new AttackWitch();
            Assert.AreEqual(5, A.Cost);
            Assert.AreEqual("Witch", A.Name); 
        }

        [TestMethod()]
        public void TestWitchAttack()
        {
            initPlayers();

            //Witch
            Player currentplayer = Turn.Instance.getActivePlayer();
            currentplayer.playCard(new FakeAttackWitch());
            List<Player> players = Turn.Instance.Players;
            currentplayer = Turn.Instance.getActivePlayer();
            Assert.AreEqual(7, currentplayer.getHand().Count);
            for (int i = 0; i < players.Count; i++ )
            {
                if (!players[i].Equals(currentplayer))
                {
                    List<Card> discard = players[i].getDiscard();
                    if (!AttackCardTest.defendList[i])
                    {
                        Assert.IsTrue(discard[discard.Count - 1] is VictoryCurse);
                    }
                    else
                    {
                        Assert.IsTrue(discard.Count == 0);
                    }
                }
            }
        }

        [TestMethod()]
        public void TestMilitiaAttack()
        {
            initPlayers();

            //Militia
            Player currentplayer = Turn.Instance.getActivePlayer();
            currentplayer.playCard(new FakeAttackMilitia());
            List<Player> players = Turn.Instance.Players;
            currentplayer = Turn.Instance.getActivePlayer();
            Assert.AreEqual(2, Turn.Instance.Coins);
            for (int i = 0; i < players.Count; i++)
            {
                if (!players[i].Equals(currentplayer))
                {
                    List<Card> hand = players[i].getHand();
                    if (!AttackCardTest.defendList[i])
                    {
                        Assert.IsTrue(hand.Count == 3);
                    }
                    else
                    {
                        Assert.IsTrue(hand.Count == 5);
                    }
                }
            }
        }

        [TestMethod()]
        public void TestBureaucratAttack()
        {
            initPlayers();

            //Bureaucrat
            Player currentplayer = Turn.Instance.getActivePlayer();
            FakeAttackBureaucrat bur = new FakeAttackBureaucrat();
            currentplayer.playCard(bur);
            List<Player> players = Turn.Instance.Players;
            currentplayer = Turn.Instance.getActivePlayer();
            Assert.IsTrue(currentplayer.getDiscard()[0] is TreasureSilver);
            for (int i = 1; i < players.Count; i++)
            {
                if (!AttackCardTest.defendList[i])
                {
                    Assert.IsFalse(players[i].getHand().Contains(new VictoryDuchy()));
                }
            }

            String expectedReveal = "Copper\n";
            expectedReveal += "Copper\n";
            expectedReveal += "Copper\n";
            expectedReveal += "Copper\n";
            expectedReveal += "Moat\n";
            expectedReveal += "Duchy\n";
            Assert.AreEqual(expectedReveal, bur.getReveal());
        }

        [TestMethod()]
        public void TestSpyAttack()
        {
            initPlayers();

            List<Player> players = Turn.Instance.Players;

            //Spy
            Player currentplayer = Turn.Instance.getActivePlayer();
            FakeAttackSpy spy = new FakeAttackSpy();
            currentplayer.playCard(spy);
            players = Turn.Instance.Players;
            currentplayer = Turn.Instance.getActivePlayer();
            Assert.IsTrue(currentplayer.getHand().Count == 6);
            Assert.IsTrue(Turn.Instance.Actions == 2);
            for (int i = 1; i < players.Count; i++)
            {
                if (!AttackCardTest.defendList[i] && AttackCardTest.spyDiscardList[i])
                {
                    Assert.IsTrue(players[i].getDiscard().Count == 1);
                }
            }

            Assert.AreEqual("CopperCopper", spy.getReveal());
        }

        private void initPlayers()
        {
            List<Player> players = new List<Player>();
            for (int i = 0; i < 4; i++)
            {
                players.Add(new Player());
            }
            Turn.Instance.instantiate(players);

            for (int i = 0; i < players.Count; i++)
            {
                List<Card> handToGive = new List<Card>();
                handToGive.Add(new TreasureCopper());
                handToGive.Add(new TreasureCopper());
                handToGive.Add(new TreasureCopper());
                handToGive.Add(new TreasureCopper());
                handToGive.Add(new ActionMoat());
                if (i == 3 || i == 2)
                {
                    handToGive.RemoveAt(0);
                    handToGive.Insert(0, new VictoryDuchy());
                }
                typeof(Player).GetField(
                    "hand",
                    System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                        .SetValue(Turn.Instance.Players[i],
                    handToGive);
            }
        }

        [TestMethod()]
        public void TestAttackCardFunctions()
        {
            ReInitTurn();

            //4 coin cost cards
            A = new FakeAttackBureaucrat();
            A.play();
            Assert.AreEqual(1, Turn.Instance.Buys);
            Assert.AreEqual(0, Turn.Instance.Coins);
            Assert.AreEqual(1, Turn.Instance.Actions);
            Assert.AreEqual(0, Turn.Instance.Trashes);
            ReInitTurn();

            A = new FakeAttackMilitia();
            A.play();
            Assert.AreEqual(1, Turn.Instance.Buys);
            Assert.AreEqual(2, Turn.Instance.Coins);
            Assert.AreEqual(1, Turn.Instance.Actions);
            Assert.AreEqual(0, Turn.Instance.Trashes);
            ReInitTurn();

            A = new FakeAttackSpy();
            A.play();
            Assert.AreEqual(1, Turn.Instance.Buys);
            Assert.AreEqual(0, Turn.Instance.Coins);
            Assert.AreEqual(2, Turn.Instance.Actions);
            Assert.AreEqual(0, Turn.Instance.Trashes);
            ReInitTurn();

            A = new FakeAttackThief();
            A.play();
            Assert.AreEqual(1, Turn.Instance.Buys);
            Assert.AreEqual(0, Turn.Instance.Coins);
            Assert.AreEqual(1, Turn.Instance.Actions);
            Assert.AreEqual(0, Turn.Instance.Trashes);
            ReInitTurn();

            A = new FakeAttackWitch();
            A.play();
            Assert.AreEqual(1, Turn.Instance.Buys);
            Assert.AreEqual(0, Turn.Instance.Coins);
            Assert.AreEqual(1, Turn.Instance.Actions);
            Assert.AreEqual(0, Turn.Instance.Trashes);
            Assert.AreEqual(7, Turn.Instance.getActivePlayer().getHandSize());
            ReInitTurn();
        }

        private void ReInitTurn()
        {
            List<Player> players = new List<Player> { new Player() };
            Turn.Instance.instantiate(players);
            Turn.Instance.reInitVals();
        }
    }
}
