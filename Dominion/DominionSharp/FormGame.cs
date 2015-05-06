﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DominionSharp
{
    public partial class FormGame : Form
    {
        private const int CARD_WIDTH = 128;
        private const int CARD_HEIGHT = 200;
        private int emptyPiles;
        private List<Pile> piles = new List<Pile>();
        private List<Pile> victories = new List<Pile>();
        private List<Pile> treasures = new List<Pile>();

        public FormGame()
        {
            InitializeComponent();
        }

        public void setPlayerCount(int count)
        {
            List<Player> players = new List<Player>();
            if (count >= 2 && count <= 4)
            {
                tabsPlayers.TabPages.Clear();
                for (int i = 0; i < count; i++)
                {
                    Player p = new Player();
                    players.Add(p);
                    tabsPlayers.TabPages.Add("Player" + (i + 1));
                    tabsPlayers.TabPages[i].AutoScroll = true;
                }
                Turn.Instance.instantiate(players);
                updateCardButtons();
            }
            else
            {
                throw new Exception("INVALID PLAYER COUNT");
            }
            createPiles();
            createTreasures();
            createVictories();
            updateSupplyButtons();
        }

        public void updateCardButtons()
        {
            List<Player> players = Turn.Instance.Players;
            for (int i = 0; i < players.Count; i++)
            {
                tabsPlayers.TabPages[i].Controls.Clear();
                Player p = players[i];
                var n = 0;
                foreach (Card card in p.getHand())
                {
                    Button cardButton = new Button();
                    //cardButton.Text = card.Name;
                    cardButton.Location = new Point(4 + n * (CARD_WIDTH + 8), 16);
                    cardButton.Size = new Size(CARD_WIDTH, CARD_HEIGHT);
                    cardButton.BackgroundImage = card.Picture;
                    cardButton.BackgroundImageLayout = ImageLayout.Stretch;
                    cardButton.Click += (sender, args) =>
                    {
                        if (p.Equals(Turn.Instance.getActivePlayer()))
                        {
                            if ((card is ActionCard && Turn.Instance.Phase.Equals(Turn.Phases.Action)) ||
                                (card is TreasureCard && Turn.Instance.Phase.Equals(Turn.Phases.Buy)))
                            {
                                if (card is ActionCard)
                                    Turn.Instance.Actions--;
                                p.playCard(card);
                                cardButton.Dispose();
                                updateCardButtons();
                                updateLabels();
                            }
                        }
                    };
                    n++;
                    tabsPlayers.TabPages[i].Controls.Add(cardButton);
                }
            }
        }

        public void updateSupplyButtons()
        {
            List<Player> players = Turn.Instance.Players;
            for (int i = 0; i < players.Count; i++)
            {
                groupBoxSupply.Controls.Clear();
                Player p = players[i];
                var n = 0;
                foreach (Pile pile in piles)
                {
                    Card card = pile.getCard();
                    Button cardButton = new Button();
                    //cardButton.Text = card.Name;
                    cardButton.Location = new Point(4 + n * (CARD_WIDTH + 8), 16);
                    cardButton.Size = new Size(CARD_WIDTH, CARD_HEIGHT);
                    cardButton.BackgroundImage = card.Picture;
                    cardButton.BackgroundImageLayout = ImageLayout.Stretch;
                    cardButton.Click += (sender, args) =>
                    {
                        if (p.Equals(Turn.Instance.getActivePlayer()))
                        {
                            if (Turn.Instance.Buys > 0 &&
                                Turn.Instance.Phase.Equals(Turn.Phases.Buy) && Turn.Instance.Coins >= card.Cost)
                            {
                                if (!pile.draw())
                                {
                                    cardButton.Dispose();
                                    emptyPiles++;
                                    if (card is VictoryProvince || emptyPiles >= 3)
                                        endGame();
                                }
                                Turn.Instance.Buys--;
                                p.gainCard(card);
                                Turn.Instance.Coins -= card.Cost;
                                updateSupplyButtons();
                                updateLabels();
                            }
                        }
                    };
                    n++;
                    groupBoxSupply.Controls.Add(cardButton);
                }
            }
        }

        private void updateLabels()
        {
            lbl_phase.Text = "Phase: " + Turn.Instance.Phase.ToString();
            lblActions.Text = "Actions: " + Turn.Instance.Actions;
            lblBuys.Text = "Buys: " + Turn.Instance.Buys;
            lblCoins.Text = "Coins: " + Turn.Instance.Coins;
        }

        public int getPlayerTabCount()
        {
            return tabsPlayers.TabCount;
        }

        public int getCardButtonCount(int player)
        {
            return tabsPlayers.TabPages[player].Controls.Count;
        }

        public String getCoinsText()
        {
            return lblCoins.Text;
        }

        public String getBuysText()
        {
            return lblBuys.Text;
        }

        public String getActionsText()
        {
            return lblActions.Text;
        }

        private void FormGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnNextPhase_Click(object sender, EventArgs e)
        {
            Turn.Instance.nextPhase();
            updateLabels();
            updateCardButtons();
            updateSupplyButtons();
        }
        private void createPiles()
        {
            //Number of Piles to create
            int numberOfPiles = 10;
            //List of all Cards
            List<Card> randomDeck = new List<Card>() { new ActionAdventure(),
                new ActionBureaucrat(), new ActionCellar(), new ActionChancellor(), 
                new ActionChapel(), new ActionCouncilRoom(), new ActionFeast(), 
                new ActionFestival(), new ActionLaboratory(), new ActionLibrary(), 
                new ActionMarket(), new ActionMilitia(), new ActionMine(), 
                new ActionMoat(), new ActionMoneylender(), new ActionRemodel(), 
                new ActionSmithy(), new ActionSpy(), new ActionThief(), 
                new ActionThroneRoom(), new ActionVillage(), new ActionWitch(), 
                new ActionWoodcutter(), new ActionWoodcutter(), new ActionWorkshop(), 
                new VictoryGardens()};
            //Add distinct cards to the pile.
            for (int i = 0; i < numberOfPiles; i++)
            {
                Random rng = new Random();
                int index = rng.Next(randomDeck.Count);
                Card c = randomDeck[index];
                piles.Add(new Pile(c));
                randomDeck.RemoveAt(index);
            }
        }
        public void createVictories()
        {
            int numberOfVictories;
            if (getPlayerTabCount() == 2)
            {
                numberOfVictories = 8;
            }
            else
            {
                numberOfVictories = 12;
            }
            victories.Add(new Pile(new VictoryEstate(), numberOfVictories));
            victories.Add(new Pile(new VictoryDuchy(), numberOfVictories));
            victories.Add(new Pile(new VictoryProvince(), numberOfVictories));
            victories.Add(new Pile(new VictoryCurse(), (10 * (getPlayerTabCount() - 1))));
        }
        public void createTreasures()
        {
            treasures.Add(new Pile(new TreasureCopper(), 60 - (7 * getPlayerTabCount())));
            treasures.Add(new Pile(new TreasureSilver(), 40));
            treasures.Add(new Pile(new TreasureGold(), 30));
        }
        public List<Pile> getPiles()
        {
            return piles;
        }
        public List<Pile> getVictories()
        {
            return victories;
        }
        public List<Pile> getTreasures()
        {
            return treasures;
        }

        public int endGame()
        {
            int maxind = 0;
            int max = 0;
            int score;
            for (int i = 0; i < Turn.Instance.Players.Count(); i++)
            {
                Player p = Turn.Instance.Players[i];
                List<Card> all = new List<Card>();
                all.AddRange(p.getDeck());
                all.AddRange(p.getHand());
                all.AddRange(p.getDiscard());
                all.AddRange(p.getWumbo());
                score = 0;
                foreach (Card c in all)
                {
                    if (c is VictoryCard)
                    {
                        VictoryCard c2 = (VictoryCard)c;
                        score += c2.VictoryPoints;
                    }
                    if (c is VictoryGardens)
                        score += (int)(all.Count / 10);
                }
                if (score > max)
                    maxind = i;
            }
            return maxind;
        }
    }
}
