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
    public partial class FormCellar : Form
    {
        List<Card> discarded = new List<Card>();
        List<Card> newHand = new List<Card>();
        List<Card> hand = new List<Card>();

        public FormCellar()
        {
            InitializeComponent();
            hand = Turn.Instance.getActivePlayer().getHand();
            for (int i = 0; i < hand.Count; i++)
            {
                ckls_hand.Items.Add(hand[i].Name);
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            int i = Turn.Instance.getActivePlayerIndex();
            Turn.Instance.Players[i].setHand(newHand);
            foreach (Card c in discarded)
            {
                Turn.Instance.Players[i].gainCard(c);
                Turn.Instance.Players[i].drawCard();
            }
        }

        private void ckls_hand_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            newHand.Clear();
            discarded.Clear();
            for (int i = 0; i < ckls_hand.Items.Count; i++)
            {
                if (ckls_hand.GetItemChecked(i) || (i == e.Index && e.NewValue == CheckState.Checked))
                {
                    discarded.Add(hand[i]);
                }
                else
                {
                    newHand.Add(hand[i]);
                }
            }
        }
    }
}
