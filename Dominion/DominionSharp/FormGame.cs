using System;
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

        public FormGame(int playerNum)
        {
            InitializeComponent();
            setPlayerCount(playerNum);
        }

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
                    Player p = new Player(i);
                    players.Add(p);
                    tabsPlayers.TabPages.Add("Player" + (i + 1));
                    tabsPlayers.TabPages[i].AutoScroll = true;
                    hideHand(p);
                }
                tabPiles.TabPages.Clear();
                tabPiles.TabPages.Add("Supply");
                tabPiles.TabPages[0].AutoScroll = true;
                tabPiles.TabPages.Add("Victories");
                tabPiles.TabPages[1].AutoScroll = true;
                tabPiles.TabPages.Add("Treasures");
                tabPiles.TabPages[2].AutoScroll = true;
                tabsPlayers.Selected += (sender, args) =>
                {
                    Player p = Turn.Instance.Players[tabsPlayers.SelectedIndex];
                    hideHand(p);
                    p.hide(true);                    
                };

                Turn.Instance.instantiate(players);
            }
            else
            {
                throw new Exception("INVALID PLAYER COUNT");
            }
            createPiles();
            createTreasures();
            createVictories();
            updateSupplyButtons();
            updateVictoryButtons();
            updateTreasureButtons();
        }
        public void setPlayerCount(int count, List<Card> cards)
        {
            List<Player> players = new List<Player>();
            if (count >= 2 && count <= 4)
            {
                tabsPlayers.TabPages.Clear();
                for (int i = 0; i < count; i++)
                {
                    Player p = new Player(i);
                    players.Add(p);
                    tabsPlayers.TabPages.Add("Player" + (i + 1));
                    tabsPlayers.TabPages[i].AutoScroll = true;
                    hideHand(p);
                }
                tabPiles.TabPages.Clear();
                tabPiles.TabPages.Add("Supply");
                tabPiles.TabPages[0].AutoScroll = true;
                tabPiles.TabPages.Add("Victories");
                tabPiles.TabPages[1].AutoScroll = true;
                tabPiles.TabPages.Add("Treasures");
                tabPiles.TabPages[2].AutoScroll = true; 
                tabsPlayers.Selected += (sender, args) =>
                {
                    Player p = Turn.Instance.Players[tabsPlayers.SelectedIndex];
                    hideHand(p);
                    p.hide(true);
                };

                Turn.Instance.instantiate(players);
            }
            else
            {
                throw new Exception("INVALID PLAYER COUNT");
            }
            createPiles(cards);
            createTreasures();
            createVictories();
            updateSupplyButtons();
            updateVictoryButtons();
            updateTreasureButtons();
        }
        public void updateCardButtons(Player p, int begIndex = 0)
        {
            tabsPlayers.TabPages[p.getNumber()].Controls.Clear();
            for (int i = begIndex; i < p.getHand().Count(); i++)
            {
                Card card = p.getHand()[i];
                Button cardButton = new Button();
                //cardButton.Text = card.Name;
                cardButton.Location = new Point(4 + i * (CARD_WIDTH + 8), 16);
                cardButton.Size = new Size(CARD_WIDTH, CARD_HEIGHT);
                cardButton.BackgroundImage = card.Picture;
                cardButton.BackgroundImageLayout = ImageLayout.Stretch;
                cardButton.Click += (sender, args) =>
                {
                    cardUpdateFunctionMaker(p, i, card, cardButton);
                };
                tabsPlayers.TabPages[p.getNumber()].Controls.Add(cardButton);
            }

        }

        private void cardUpdateFunctionMaker(Player p, int i, Card card, Button cardButton)
        {
            if (p.Equals(Turn.Instance.getActivePlayer()))
            {
                if ((card is ActionCard && Turn.Instance.Actions > 0 && Turn.Instance.Phase.Equals(Turn.Phases.Action)) ||
                    (card is TreasureCard && Turn.Instance.Phase.Equals(Turn.Phases.Buy)))
                {
                    if (card is ActionCard)
                        Turn.Instance.Actions--;
                    p.playCard(card);
                    cardButton.Dispose();
                    if (card is AttackCard)
                    {
                        List<Player> players = Turn.Instance.Players;
                        for (int j = 0; j < getPlayerTabCount(); j++)
                        {
                            updateCardButtons(players[j], 0);
                        }
                    }
                    else
                    {
                        updateCardButtons(p, 0);
                    }
                    updateLabels();
                }
            }
        }

        public void updateSupplyButtons()
        {
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
                cardButton.Name = pile.getCount().ToString();
                cardButton.Click += (sender, args) =>
                {
                    supplyUpdateFunctionMaker(card, pile, cardButton);
                };
                n++;
                tabPiles.TabPages[0].Controls.Add(cardButton);
            }
        }

        private void supplyUpdateFunctionMaker(Card card, Pile pile, Button cardButton)
        {
            Player p = Turn.Instance.getActivePlayer();
            if (Turn.Instance.Buys > 0 &&
                Turn.Instance.Phase.Equals(Turn.Phases.Buy) && Turn.Instance.Coins >= card.Cost)
            {
                if (!pile.draw())
                {
                    cardButton.Dispose();
                    emptyPiles++;
                    piles.Remove(pile);
                    updateSupplyButtons();
                }
                Turn.Instance.Buys--;
                p.gainCard(card);
                Turn.Instance.Coins -= card.Cost;
                updateLabels();
                Console.WriteLine(card.Name + " BOUGHT");
            }
        }

        public void updateVictoryButtons()
        {
            List<Player> players = Turn.Instance.Players;
            for (int i = 0; i < players.Count; i++)
            {
                Player p = players[i];
                tabPiles.TabPages[1].Controls.Clear();
                var n = 0;
                foreach (Pile pile in victories)
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
                        victoryUpdateFunctionMaker(card, pile, cardButton);
                    };
                    n++;
                    tabPiles.TabPages[1].Controls.Add(cardButton);
                }
            }
        }

        private void victoryUpdateFunctionMaker(Card card, Pile pile, Button cardButton)
        {
            Player p = Turn.Instance.getActivePlayer();
                if (Turn.Instance.Buys > 0 &&
                    Turn.Instance.Phase.Equals(Turn.Phases.Buy) && Turn.Instance.Coins >= card.Cost)
                {
                    if (!pile.draw())
                    {
                        cardButton.Dispose();
                        victories.Remove(pile);
                        emptyPiles++;
                        updateVictoryButtons();
                        if (card is VictoryProvince || emptyPiles >= 3)
                            endGame();
                    }
                    Turn.Instance.Buys--;
                    p.gainCard(card);
                    Turn.Instance.Coins -= card.Cost;
                    updateLabels();
                }
        }

        public void updateTreasureButtons(int begIndex = 0)
        {
            List<Player> players = Turn.Instance.Players;
            for (int i = begIndex; i < players.Count; i++)
            {
                Player p = players[i];
                tabPiles.TabPages[2].Controls.Clear();
                var n = 0;
                for (int j = 0; j < treasures.Count(); j++)
                {
                    treasureUpdateFunctionMaker(j, n);
                    n++;
                }
            }
        }

        private void treasureUpdateFunctionMaker(int j, int n)
        {
            Pile pile = treasures[j];
            Card card = pile.getCard();
            Button cardButton = new Button();
            //cardButton.Text = card.Name;
            cardButton.Location = new Point(4 + n * (CARD_WIDTH + 8), 16);
            cardButton.Size = new Size(CARD_WIDTH, CARD_HEIGHT);
            cardButton.BackgroundImage = card.Picture;
            cardButton.BackgroundImageLayout = ImageLayout.Stretch;
            cardButton.Click += (sender, args) =>
            {
                Player p = Turn.Instance.getActivePlayer();
                if (Turn.Instance.Buys > 0 &&
                        Turn.Instance.Phase.Equals(Turn.Phases.Buy) && Turn.Instance.Coins >= card.Cost)
                {
                    if (!pile.draw())
                    {
                        cardButton.Dispose();
                        emptyPiles++;
                        treasures.Remove(pile);
                        updateTreasureButtons(j);
                    }
                    Turn.Instance.Buys--;
                    p.gainCard(card);
                    Turn.Instance.Coins -= card.Cost;
                    updateLabels();
                }
            };
            tabPiles.TabPages[2].Controls.Add(cardButton);
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
            int prevPlayerTurn = Turn.Instance.getActivePlayerIndex();
            Player temp = Turn.Instance.getActivePlayer();
            Turn.Instance.nextPhase();
            updateLabels();
            updateCardButtons(temp);
            if (prevPlayerTurn != Turn.Instance.getActivePlayerIndex())
            {
                tabsPlayers.SelectedIndex = Turn.Instance.getActivePlayerIndex();
            }
        }

        private void createPiles(List<Card> cards = null)
        {
            if(cards==null)
            {
                cards = new List<Card>();
            }
            //Number of Piles to create
            int numberOfPiles = 10-cards.Count;
            //List of all Cards
            List<Card> randomDeck = new List<Card>() { new ActionAdventure(),
                new AttackBureaucrat(), new ActionCellar(), new ActionChancellor(), 
                new ActionChapel(), new ActionCouncilRoom(), new ActionFeast(), 
                new ActionFestival(), new ActionLaboratory(), new ActionLibrary(), 
                new ActionMarket(), new AttackMilitia(), new ActionMine(), 
                new ActionMoat(), new ActionMoneylender(), new ActionRemodel(), 
                new ActionSmithy(), new AttackSpy(), new AttackThief(), 
                new ActionThroneRoom(), new ActionVillage(), new AttackWitch(), 
                new ActionWoodcutter(), new ActionWoodcutter(), new ActionWorkshop(), 
                new VictoryGardens()};
            foreach (Card c in cards)
            {
                randomDeck.Remove(c);
                piles.Add(new Pile(c));
            }
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
                {
                    max = score;
                    maxind = i;
            }
            }
            return maxind;
        }

        private void btnHideRevealHand_Click(object sender, EventArgs e)
        {
            var tab = tabsPlayers.SelectedIndex;
            Player p = Turn.Instance.Players[tab];
            if (p.isHidden())
            {
                updateCardButtons(p);
            }
            else
            {
                hideHand(p);
            }
            p.hide(!p.isHidden());
        }
        private void hideHand(Player p)
        {
            tabsPlayers.TabPages[p.getNumber()].Controls.Clear();
            var n = 0;
            foreach (Card card in p.getHand())
            {
                Button cardButton = new Button();
                //cardButton.Text = card.Name;
                cardButton.Location = new Point(4 + n * (CARD_WIDTH + 8), 16);
                cardButton.Size = new Size(CARD_WIDTH, CARD_HEIGHT);
                cardButton.BackgroundImage = global::DominionSharp.Properties.Resources.back;
                cardButton.BackgroundImageLayout = ImageLayout.Stretch;
                tabsPlayers.TabPages[p.getNumber()].Controls.Add(cardButton);
                n++;
            }
        }
    }
}
