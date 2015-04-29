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
        public void TestActionCardAdvancedFunctions()
        {
            //Number of Players
            int numberOfPlayers = 3; //Must be at least 2
            //Council Room Test
            FormGame game = new FormGame();
            game.setPlayerCount(numberOfPlayers);
            List<Player> players = Turn.Instance.Players;
            Player currentplayer = Turn.Instance.getActivePlayer();
            List<Card> handToGive = new List<Card>();
            handToGive.Add(new TreasureCopper());
            handToGive.Add(new TreasureCopper());
            handToGive.Add(new TreasureCopper());
            handToGive.Add(new TreasureCopper());
            handToGive.Add(new ActionCouncilRoom());
            typeof(Player)
                .GetField("hand", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                .SetValue(Turn.Instance.getActivePlayer(), handToGive);
            currentplayer = Turn.Instance.getActivePlayer();
            Turn.Instance.getActivePlayer().playCard(currentplayer.getHand()[currentplayer.getHandSize() - 1]);
            Assert.AreEqual(8, currentplayer.getHandSize());
            players = Turn.Instance.Players;
            currentplayer = Turn.Instance.getActivePlayer();
            for (int i = 0; i < players.Count; i++ )
            {
                if (!players[i].Equals(currentplayer))
                {
                    Assert.AreEqual(6, players[i].getHandSize());
                }
            }
            //Witch Test
            game = new FormGame();
            game.setPlayerCount(numberOfPlayers);
            players = Turn.Instance.Players;
            currentplayer = Turn.Instance.getActivePlayer();
            currentplayer.playCard(new ActionWitch());
            for (int i = 0; i < players.Count; i++)
            {
                if (players[i] != currentplayer)
                {
                    //This card's discard
                    List<Card> discard = players[i].getDiscard();
                    //Testing top card to be a curse
                    Assert.AreEqual(discard[discard.Count - 1].GetType(), new VictoryCurse().GetType());
                }
            }
            //ThroneRoom Test
            game = new FormGame();
            game.setPlayerCount(numberOfPlayers);
            players = Turn.Instance.Players;
            currentplayer = Turn.Instance.getActivePlayer();
            handToGive = new List<Card>();
            handToGive.Add(new TreasureCopper());
            handToGive.Add(new TreasureCopper());
            handToGive.Add(new TreasureCopper());
            handToGive.Add(new ActionThroneRoom());
            handToGive.Add(new ActionCouncilRoom());
            typeof(Player)
                .GetField("hand", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                .SetValue(Turn.Instance.getActivePlayer(), handToGive);
            currentplayer.playCard(Turn.Instance.getActivePlayer().getHand()[Turn.Instance.getActivePlayer().getHandSize() - 2]);
            currentplayer.playCard(Turn.Instance.getActivePlayer().getHand()[Turn.Instance.getActivePlayer().getHandSize() - 1]);
            Assert.AreEqual(currentplayer.getHandSize(), 11);
            for (int i = 0; i < players.Count; i++)
            {
                if (players[i] != currentplayer)
                {
                    Assert.AreEqual(players[i].getHandSize(), 7);
                }
            }
        }


        [TestMethod()]
        public void TestActionCardFunctions()
        {
            ReInitTurn();
            //2 coin cost cards
            A = new ActionCellar();
            A.play();
            Assert.AreEqual(1, Turn.Instance.Buys);
            Assert.AreEqual(0, Turn.Instance.Coins);
            Assert.AreEqual(2, Turn.Instance.Actions);
            Assert.AreEqual(0, Turn.Instance.Trashes);
            ReInitTurn();

            A = new ActionChapel();
            A.play();
            Assert.AreEqual(1, Turn.Instance.Buys);
            Assert.AreEqual(0, Turn.Instance.Coins);
            Assert.AreEqual(1, Turn.Instance.Actions);
            Assert.AreEqual(4, Turn.Instance.Trashes);
            ReInitTurn();

            A = new ActionMoat();
            A.play();
            Assert.AreEqual(1, Turn.Instance.Buys);
            Assert.AreEqual(0, Turn.Instance.Coins);
            Assert.AreEqual(1, Turn.Instance.Actions);
            Assert.AreEqual(0, Turn.Instance.Trashes);
            Assert.AreEqual(7, Turn.Instance.getActivePlayer().getHandSize());
            ReInitTurn();

            //3 coin cost cards
            A = new ActionChancellor();
            A.play();
            Assert.AreEqual(1, Turn.Instance.Buys);
            Assert.AreEqual(2, Turn.Instance.Coins);
            Assert.AreEqual(1, Turn.Instance.Actions);
            Assert.AreEqual(0, Turn.Instance.Trashes);
            ReInitTurn();

            A = new ActionVillage();
            A.play();
            Assert.AreEqual(1, Turn.Instance.Buys);
            Assert.AreEqual(0, Turn.Instance.Coins);
            Assert.AreEqual(3, Turn.Instance.Actions);
            Assert.AreEqual(0, Turn.Instance.Trashes);
            Assert.AreEqual(6, Turn.Instance.getActivePlayer().getHandSize());
            ReInitTurn();

            A = new ActionWoodcutter();
            A.play();
            Assert.AreEqual(2, Turn.Instance.Buys);
            Assert.AreEqual(2, Turn.Instance.Coins);
            Assert.AreEqual(1, Turn.Instance.Actions);
            Assert.AreEqual(0, Turn.Instance.Trashes);
            ReInitTurn();

            A = new ActionWorkshop();
            A.play();
            Assert.AreEqual(1, Turn.Instance.Buys);
            Assert.AreEqual(0, Turn.Instance.Coins);
            Assert.AreEqual(1, Turn.Instance.Actions);
            Assert.AreEqual(0, Turn.Instance.Trashes);
            ReInitTurn();

            //4 coin cost cards
            A = new ActionBureaucrat();
            A.play();
            Assert.AreEqual(1, Turn.Instance.Buys);
            Assert.AreEqual(0, Turn.Instance.Coins);
            Assert.AreEqual(1, Turn.Instance.Actions);
            Assert.AreEqual(0, Turn.Instance.Trashes);
            ReInitTurn();

            A = new ActionFeast();
            A.play();
            Assert.AreEqual(1, Turn.Instance.Buys);
            Assert.AreEqual(0, Turn.Instance.Coins);
            Assert.AreEqual(1, Turn.Instance.Actions);
            Assert.AreEqual(0, Turn.Instance.Trashes);
            ReInitTurn();

            //A = new ActionGarden();
            //A.play();
            //Assert.AreEqual(1, Turn.Instance.Buys);
            //Assert.AreEqual(0, Turn.Instance.Coins);
            //Assert.AreEqual(0, Turn.Instance.Actions);
            //Assert.AreEqual(0, Turn.Instance.Trashes);
            //ReInitTurn();

            A = new ActionMilitia();
            A.play();
            Assert.AreEqual(1, Turn.Instance.Buys);
            Assert.AreEqual(2, Turn.Instance.Coins);
            Assert.AreEqual(1, Turn.Instance.Actions);
            Assert.AreEqual(0, Turn.Instance.Trashes);
            ReInitTurn();

            A = new ActionMoneylender();
            A.play();
            Assert.AreEqual(1, Turn.Instance.Buys);
            Assert.AreEqual(0, Turn.Instance.Coins);
            Assert.AreEqual(1, Turn.Instance.Actions);
            Assert.AreEqual(0, Turn.Instance.Trashes);
            ReInitTurn();

            A = new ActionRemodel();
            A.play();
            Assert.AreEqual(1, Turn.Instance.Buys);
            Assert.AreEqual(0, Turn.Instance.Coins);
            Assert.AreEqual(1, Turn.Instance.Actions);
            Assert.AreEqual(0, Turn.Instance.Trashes);
            ReInitTurn();

            A = new ActionSmithy();
            A.play();
            Assert.AreEqual(1, Turn.Instance.Buys);
            Assert.AreEqual(0, Turn.Instance.Coins);
            Assert.AreEqual(1, Turn.Instance.Actions);
            Assert.AreEqual(0, Turn.Instance.Trashes);
            Assert.AreEqual(8, Turn.Instance.getActivePlayer().getHandSize());
            ReInitTurn();

            A = new ActionSpy();
            A.play();
            Assert.AreEqual(1, Turn.Instance.Buys);
            Assert.AreEqual(0, Turn.Instance.Coins);
            Assert.AreEqual(2, Turn.Instance.Actions);
            Assert.AreEqual(0, Turn.Instance.Trashes);
            ReInitTurn();

            A = new ActionThief();
            A.play();
            Assert.AreEqual(1, Turn.Instance.Buys);
            Assert.AreEqual(0, Turn.Instance.Coins);
            Assert.AreEqual(1, Turn.Instance.Actions);
            Assert.AreEqual(0, Turn.Instance.Trashes);
            ReInitTurn();

            A = new ActionThroneRoom();
            A.play();
            Assert.AreEqual(1, Turn.Instance.Buys);
            Assert.AreEqual(0, Turn.Instance.Coins);
            Assert.AreEqual(1, Turn.Instance.Actions);
            Assert.AreEqual(0, Turn.Instance.Trashes);
            ReInitTurn();

            //5 coin cost cards
            A = new ActionCouncilRoom();
            A.play();
            Assert.AreEqual(2, Turn.Instance.Buys);
            Assert.AreEqual(0, Turn.Instance.Coins);
            Assert.AreEqual(1, Turn.Instance.Actions);
            Assert.AreEqual(0, Turn.Instance.Trashes);
            Assert.AreEqual(9, Turn.Instance.getActivePlayer().getHandSize());
            ReInitTurn();

            A = new ActionFestival();
            A.play();
            Assert.AreEqual(2, Turn.Instance.Buys);
            Assert.AreEqual(2, Turn.Instance.Coins);
            Assert.AreEqual(3, Turn.Instance.Actions);
            Assert.AreEqual(0, Turn.Instance.Trashes);
            ReInitTurn();

            A = new ActionLaboratory();
            A.play();
            Assert.AreEqual(1, Turn.Instance.Buys);
            Assert.AreEqual(0, Turn.Instance.Coins);
            Assert.AreEqual(2, Turn.Instance.Actions);
            Assert.AreEqual(0, Turn.Instance.Trashes);
            Assert.AreEqual(7, Turn.Instance.getActivePlayer().getHandSize());
            ReInitTurn();

            A = new ActionLibrary();
            A.play();
            Assert.AreEqual(1, Turn.Instance.Buys);
            Assert.AreEqual(0, Turn.Instance.Coins);
            Assert.AreEqual(1, Turn.Instance.Actions);
            Assert.AreEqual(0, Turn.Instance.Trashes);
            Assert.AreEqual(7, Turn.Instance.getActivePlayer().getHandSize());
            ReInitTurn();

            A = new ActionMarket();
            A.play();
            Assert.AreEqual(2, Turn.Instance.Buys);
            Assert.AreEqual(1, Turn.Instance.Coins);
            Assert.AreEqual(2, Turn.Instance.Actions);
            Assert.AreEqual(0, Turn.Instance.Trashes);
            Assert.AreEqual(6, Turn.Instance.getActivePlayer().getHandSize());
            ReInitTurn();

            A = new ActionMine();
            A.play();
            Assert.AreEqual(1, Turn.Instance.Buys);
            Assert.AreEqual(0, Turn.Instance.Coins);
            Assert.AreEqual(1, Turn.Instance.Actions);
            Assert.AreEqual(0, Turn.Instance.Trashes);
            ReInitTurn();

            A = new ActionWitch();
            A.play();
            Assert.AreEqual(1, Turn.Instance.Buys);
            Assert.AreEqual(0, Turn.Instance.Coins);
            Assert.AreEqual(1, Turn.Instance.Actions);
            Assert.AreEqual(0, Turn.Instance.Trashes);
            Assert.AreEqual(7, Turn.Instance.getActivePlayer().getHandSize());
            ReInitTurn();

            //6 coin cost cards
            A = new ActionAdventure();
            A.play();
            Assert.AreEqual(1, Turn.Instance.Buys);
            Assert.AreEqual(0, Turn.Instance.Coins);
            Assert.AreEqual(1, Turn.Instance.Actions);
            Assert.AreEqual(0, Turn.Instance.Trashes);
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
