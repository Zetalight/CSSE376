using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DominionSharp
{
    public class ActionMoneylender : ActionCard
    {
        public ActionMoneylender()
        {
            this.name = "Moneylender";
            this.cost = 4;
            this.picture = global::DominionSharp.Properties.Resources.moneylender; //TODO: Add Picture
        }
        public override void play()
        {
            base.play();
            Console.WriteLine("Moneylender Played");
            //TODO: Trash copper for +3 coins
            List<Card> hand = Turn.Instance.getActivePlayer().getHand();
            foreach (Card c in hand)
            {
                if (c is TreasureCopper)
                {
                    bool tc = trashCopper();
                    if (tc)
                    {
                        hand.Remove(c);
                        Turn.Instance.getActivePlayer().setHand(hand);
                        Turn.Instance.Coins += 3;
                    }
                    break;
                }
            }
        }

        protected virtual bool trashCopper()
        {
            DialogResult dr = MessageBox.Show("Money Lender", "Would you like to trash a copper card?", MessageBoxButtons.YesNo);
            return dr == DialogResult.Yes;
        }
    }
}
