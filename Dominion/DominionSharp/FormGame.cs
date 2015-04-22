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
        public Card startHand1;

        public List<Player> players = new List<Player>();

        public FormGame()
        {
            InitializeComponent();
            startHand1 = new ActionChapel(); //Make this general
            button4.Image = startHand1.Picture;
        }

        public void setPlayerCount(int count)
        {
            players.Clear();
            if (count >= 2 && count <= 4)
            {
                int cardWidth = (tabsPlayers.Size.Width - 48) / 5;
                int cardHeight = (tabsPlayers.Size.Height) - 32;
                tabsPlayers.TabPages.Clear();
                for (int i = 0; i < count; i++)
                {
                    Player p = new Player();
                    players.Add(p);
                    tabsPlayers.TabPages.Add("Player" + (i + 1));

                    var n = 0;
                    foreach (Card card in p.getHand())
                    {
                        Button cardButton = new Button();
                        cardButton.Text = card.Name;
                        cardButton.Location = new Point(4 + n * (cardWidth + 8), 0);
                        cardButton.Size = new Size(cardWidth, cardHeight);
                        n++;
                        tabsPlayers.TabPages[i].Controls.Add(cardButton);
                    }

                }
            }
            else
            {
                throw new Exception("INVALID PLAYER COUNT");
            }
        }

        public int getPlayerTabCount()
        {
            return tabsPlayers.TabCount;
        }

        public List<Player> getPlayers()
        {
            return players;
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

        private void button4_Click(object sender, EventArgs e)
        {
            ActionCard test = (ActionCard) startHand1;
        }

        private void FormGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
