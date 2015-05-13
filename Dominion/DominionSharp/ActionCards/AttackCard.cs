using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DominionSharp
{
    public abstract class AttackCard : ActionCard
    {
        public override void play()
        {
            base.play();
            tryAttackingOtherPlayers();
        }

        protected abstract void attack(int playerNum);

        private void tryAttackingOtherPlayers()
        {
            List<Player> players = Turn.Instance.Players;
            for (int i = 0; i < players.Count; i++)
            {
                Player p = players[i];
                if (!p.Equals(Turn.Instance.getActivePlayer()))
                {
                    bool hasMoat = p.hasMoatInHand();
                    if (hasMoat)
                    {
                        bool def = defend(i);
                        if (!def)
                        {
                            attack(i);
                        }
                    }
                    else
                    {
                        attack(i);
                    }
                }
            }
        }

        protected virtual bool defend(int playerNum)
        {
            Console.WriteLine("blah");
            DialogResult prompt = MessageBox.Show(
                "Would you like to defend with your Moat card?", "Player" + (playerNum + 1), MessageBoxButtons.YesNo);
            if (prompt == DialogResult.No)
            {
                return false;
            }
            return true;
        }

    }
}
