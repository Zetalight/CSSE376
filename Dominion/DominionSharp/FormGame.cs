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
            tabsPlayers.TabPages.Clear();
        }

        public int getPlayerTabCount()
        {
            return tabsPlayers.TabCount;
        }

        public List<Player> getPlayers()
        {
            return players;
        }

        public String getLabel3Text()
        {
            return Label3.Text;
        }

        public String getLabel2Text()
        {
            return Label2.Text;
        }

        public String getLabel1Text()
        {
            return Label1.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActionCard test = (ActionCard) startHand1;
            test.play();
        }
    }
}
