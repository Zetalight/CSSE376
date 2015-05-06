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
                        if ((card is ActionCard && Turn.Instance.Phase.Equals(Turn.Phases.Action)) ||
                            (card is TreasureCard && Turn.Instance.Phase.Equals(Turn.Phases.Buy)))
                        {
                            p.playCard(card);
                            cardButton.Dispose();
                            updateCardButtons();
                            updateLabels();
                        }
                    };
                    n++;
                    tabsPlayers.TabPages[i].Controls.Add(cardButton);
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
        }
    }
}
