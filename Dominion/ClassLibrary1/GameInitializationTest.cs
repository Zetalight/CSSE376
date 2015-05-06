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
    public class GameInitializationTest
    {
        FormGame game;

        [TestInitialize()]
        public void TestThatGameInitializes()
        {
            game = new FormGame();
        }

        [TestMethod()]
        public void TestThatTwoPlayersInitializeProperly()
        {
            game.setPlayerCount(2);
            List<Player> players = Turn.Instance.Players;
            Assert.AreEqual(players.Count, 2);
            Assert.AreEqual(game.getPlayerTabCount(), 2);

            for (int i = 0; i < players.Count; i++)
            {
                Assert.AreEqual(players[i].getDeck().Count, 5);
                Assert.AreEqual(players[i].getHand().Count, 5);
            }
        }

        [TestMethod()]
        public void TestThatFourPlayersInitializeProperly()
        {
            game.setPlayerCount(4);
            List<Player> players = Turn.Instance.Players;
            Assert.AreEqual(players.Count, 4);
            Assert.AreEqual(game.getPlayerTabCount(), 4);

            for (int i = 0; i < players.Count; i++)
            {
                Assert.AreEqual(players[i].getDeck().Count, 5);
                Assert.AreEqual(players[i].getHand().Count, 5);
            }
        }

        [TestMethod()]
        [ExpectedException(typeof(System.Exception), "INVALID PLAYER COUNT")]
        public void TestThatOnePlayerFailsToInitialize()
        {
            game.setPlayerCount(1);
        }

        [TestMethod()]
        [ExpectedException(typeof(System.Exception), "INVALID PLAYER COUNT")]
        public void TestThatFivePlayersFailToInitialize()
        {
            game.setPlayerCount(5);
        }

        [TestMethod()]
        public void TestThatGameMakesSupply()
        {
            List<Pile> p = game.getPiles();
            Assert.IsNotNull(p);
            Assert.AreEqual(10, p.Count());
            List<Pile> t = game.getTreasures();
            Assert.IsNotNull(t);
            Assert.AreEqual(3, t.Count());
            Assert.AreEqual(60 - (7 * Turn.Instance.Players.Count()), t[0].getCount());
            Assert.AreEqual(typeof(TreasureCopper), t[0].getCard().GetType());
            Assert.AreEqual(40, t[1].getCount());
            Assert.AreEqual(typeof(TreasureSilver), t[1].getCard().GetType());
            Assert.AreEqual(30, t[2].getCount());
            Assert.AreEqual(typeof(TreasureGold), t[2].getCard().GetType());
            List<Pile> v = game.getVictories();
            Assert.IsNotNull(v);
            Assert.AreEqual(Turn.Instance.Players.Count() == 2 ? 8 : 12, v[0].getCount());
            Assert.AreEqual(typeof(VictoryEstate), v[0].getCard().GetType());
            Assert.AreEqual(v[0].getCount(), v[1].getCount());
            Assert.AreEqual(typeof(VictoryDuchy), v[1].getCard().GetType());
            Assert.AreEqual(v[0].getCount(), v[2].getCount());
            Assert.AreEqual(typeof(VictoryProvince), v[2].getCard().GetType());
        }
    }
}
