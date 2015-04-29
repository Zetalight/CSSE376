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
            List<Player> players = game.getPlayers();
            Assert.Equals(players.Count, 2);
            Assert.Equals(game.getPlayerTabCount(), 2);

            for (int i = 0; i < players.Count; i++)
            {
                Assert.Equals(players[i].getDeck().Count, 5);
                Assert.Equals(players[i].getHand().Count, 5);
            }
        }

        [TestMethod()]
        public void TestThatFourPlayersInitializeProperly()
        {
            game.setPlayerCount(4);
            List<Player> players = game.getPlayers();
            Assert.Equals(players.Count, 4);
            Assert.Equals(game.getPlayerTabCount(), 4);

            for (int i = 0; i < players.Count; i++)
            {
                Assert.Equals(players[i].getDeck().Count, 5);
                Assert.Equals(players[i].getHand().Count, 5);
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
    }
}
