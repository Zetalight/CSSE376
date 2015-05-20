using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DominionSharp
{
    public class ActionLibrary : ActionCard
    {
        List<ActionCard> actions = new List<ActionCard>();

        public ActionLibrary()
        {
            this.name = "Library";
            this.cost = 5;
            this.picture = global::DominionSharp.Properties.Resources.library; //TODO: Add Picture
        }
        public override void play()
        {
            base.play();
            Console.WriteLine("Library Played");
            //TODO: Draw until you have 7 cards in hand.
            //You may set aside any Action cards drawn this way, 
            //as you draw them; discard the
            //set aside cards after you finish drawing.
            actions.Clear();
            List<Card> hand = Turn.Instance.getActivePlayer().getHand();
            while (hand.Count < 7)
            {
                Card c = Turn.Instance.getActivePlayer().libraryDraw();
                if (c is ActionCard)
                {
                    if (setAside((ActionCard)c))
                    {
                        actions.Add((ActionCard) c);
                    }
                    else
                    {
                        hand.Add(c);
                        Turn.Instance.getActivePlayer().setHand(hand);
                    }
                }
            }
            foreach (ActionCard ac in actions)
            {
                Turn.Instance.getActivePlayer().gainCard(ac);
            }
        }

        protected virtual bool setAside(ActionCard c)
        {
            DialogResult dr = MessageBox.Show("Library", "Would you like to set aside " + c.Name + " to discard?", MessageBoxButtons.YesNo);
            return dr == DialogResult.Yes;
        }
    }
}
