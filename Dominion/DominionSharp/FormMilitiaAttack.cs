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
    public partial class FormMilitiaAttack : Form
    {
        Player player;
        List<Card> cards;
        List<Card> newHand = new List<Card>();
        public FormMilitiaAttack(Player p, int num)
        {
            InitializeComponent();

            player = p;
            cards = player.getHand();
            foreach (Card c in cards)
            {
                ckls_cards.Items.Add(c.Name);
            }
            this.Text += "" + (num + 1);
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            List<Player> players = Turn.Instance.Players;
            for (int i = 0; i < players.Count; i++)
            {
                if (player.Equals(players[i]))
                {
                    Turn.Instance.Players[i].setHand(newHand);
                }
            }
            this.Close();
        }

        private void ckls_cards_SelectedIndexChanged(object sender, EventArgs e) { }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private void ckls_cards_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int checkCount = ckls_cards.CheckedItems.Count;
            if (e.NewValue == CheckState.Checked)
            {
                checkCount++;
            }
            else
            {
                checkCount--;
            }
            if (checkCount == 3)
            {
                btn_ok.Enabled = true;
                newHand.Clear();
                for (int i = 0; i < ckls_cards.Items.Count; i++)
                {
                    if (ckls_cards.GetItemChecked(i) || (i == e.Index && e.NewValue == CheckState.Checked))
                    {
                        newHand.Add(cards[i]);
                    }
                }
            }
            else
            {
                btn_ok.Enabled = false;
            }
        }
    }
}
