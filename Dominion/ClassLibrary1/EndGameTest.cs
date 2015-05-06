using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DominionSharp;

namespace ClassLibrary1
{
    [TestClass()]
    public class EndGameTest
    {
        [TestMethod()]
        public void noGardenEndPlayer0()
        {
            FormGame game = new FormGame();
            game.setPlayerCount(2);
            List<Player> players = Turn.Instance.Players;
            Player currentplayer = Turn.Instance.getActivePlayer();
            typeof(Player)
                .GetField("deck", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                .SetValue(Turn.Instance.Players[0], new List<Card>() {new VictoryProvince() });
            typeof(Player)
                .GetField("hand", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                .SetValue(Turn.Instance.Players[0], new List<Card>());
            typeof(Player)
                .GetField("deck", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                .SetValue(Turn.Instance.Players[1], new List<Card>() { new VictoryEstate() });
            typeof(Player)
                .GetField("hand", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                .SetValue(Turn.Instance.Players[1], new List<Card>());
            Assert.AreEqual(0, game.endGame());
        }

        [TestMethod()]
        public void noGardenEndPlayer1()
        {
            FormGame game = new FormGame();
            game.setPlayerCount(2);
            List<Player> players = Turn.Instance.Players;
            Player currentplayer = Turn.Instance.getActivePlayer();
            typeof(Player)
                .GetField("deck", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                .SetValue(Turn.Instance.Players[0], new List<Card>() { new VictoryCurse() });
            typeof(Player)
                .GetField("hand", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                .SetValue(Turn.Instance.Players[0], new List<Card>());
            typeof(Player)
                .GetField("deck", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                .SetValue(Turn.Instance.Players[1], new List<Card>() { new VictoryDuchy() });
            typeof(Player)
                .GetField("hand", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                .SetValue(Turn.Instance.Players[1], new List<Card>());
            Assert.AreEqual(1, game.endGame());
        }

        [TestMethod()]
        public void GardenEndPlayer0()
        {
            FormGame game = new FormGame();
            game.setPlayerCount(2);
            List<Player> players = Turn.Instance.Players;
            Player currentplayer = Turn.Instance.getActivePlayer();
            typeof(Player)
                .GetField("deck", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                .SetValue(Turn.Instance.Players[0], new List<Card>() { new VictoryGardens(), 
                    new TreasureCopper(), new TreasureCopper(), new TreasureCopper(), 
                    new TreasureCopper(), new TreasureCopper(), new TreasureCopper(), 
                    new TreasureCopper(), new TreasureCopper(), new TreasureCopper(), 
                    new TreasureCopper(), new TreasureCopper(), new TreasureCopper(), 
                    new TreasureCopper(), new TreasureCopper(), new TreasureCopper(), 
                    new TreasureCopper(), new TreasureCopper(), new TreasureCopper(), 
                    new TreasureCopper(), new TreasureCopper() });
            typeof(Player)
                .GetField("hand", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                .SetValue(Turn.Instance.Players[0], new List<Card>());
            typeof(Player)
                .GetField("deck", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                .SetValue(Turn.Instance.Players[1], new List<Card>() { new VictoryEstate(), new VictoryCurse() });
            typeof(Player)
                .GetField("hand", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                .SetValue(Turn.Instance.Players[1], new List<Card>());
            Assert.AreEqual(0, game.endGame());
        }

        [TestMethod()]
        public void GardenEndPlayer1()
        {
            FormGame game = new FormGame();
            game.setPlayerCount(2);
            List<Player> players = Turn.Instance.Players;
            Player currentplayer = Turn.Instance.getActivePlayer();
            typeof(Player)
               .GetField("deck", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
               .SetValue(Turn.Instance.Players[0], new List<Card>() { new VictoryEstate(), new VictoryCurse(), new VictoryDuchy(), new VictoryCurse() });
            typeof(Player)
                .GetField("hand", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                .SetValue(Turn.Instance.Players[0], new List<Card>());
            typeof(Player)
                .GetField("deck", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                .SetValue(Turn.Instance.Players[1], new List<Card>() { new VictoryGardens(), new VictoryGardens(), 
                    new TreasureCopper(), new TreasureCopper(), new TreasureCopper(), 
                    new TreasureCopper(), new TreasureCopper(), new TreasureCopper(), 
                    new TreasureCopper(), new TreasureCopper(), new TreasureCopper(), 
                    new TreasureCopper(), new TreasureCopper(), new TreasureCopper(), 
                    new TreasureCopper(), new TreasureCopper(), new TreasureCopper(), 
                    new TreasureCopper(), new TreasureCopper(), new TreasureCopper(), 
                    new TreasureCopper(), new TreasureCopper() });
            typeof(Player)
                .GetField("hand", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                .SetValue(Turn.Instance.Players[1], new List<Card>());
            Assert.AreEqual(1, game.endGame());
        }        
    }
}
