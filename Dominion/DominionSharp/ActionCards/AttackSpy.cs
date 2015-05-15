using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DominionSharp
{
    public class AttackSpy : AttackCard
    {
        public AttackSpy()
        {
            this.name = "Spy";
            this.cost = 4;
            this.picture = global::DominionSharp.Properties.Resources.spy; //TODO: Add Picture
            this.cards = 1;
            this.actions = 1;
        }

        protected override void attack(int playerNum)
        {
            DialogResult dr = MessageBox.Show(reveal(playerNum) 
                + " was revealed.\nPress \"Yes\" to discard or \"No\" to put it back.",
                "Player" + (playerNum + 1) + " reveals the top card of their deck...",
                MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Turn.Instance.Players[playerNum].discardTopCardOfDeck();
            }
        }

        protected String reveal(int playerNum)
        {
            Player p = Turn.Instance.Players[playerNum];
            Card rev = p.revealTopDeck(1)[0];
            return rev.Name;
        }

        public override void play()
        {
            base.play();
            Console.WriteLine("Spy Played");
            //TODO: Each player (including you) 
            //reveals the top card of his deck and 
            //either discards it or puts it back, 
            //your choice.
            int i = Turn.Instance.getActivePlayerIndex();
            if (Turn.Instance.getActivePlayer().hasMoatInHand())
            {
                if (!defend(i))
                {
                    attack(i);
                }
            }
        }
    }
}
