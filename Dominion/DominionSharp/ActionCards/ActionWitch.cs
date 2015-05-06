using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DominionSharp
{
    public class ActionWitch:ActionCard
    {
        public ActionWitch()
        {
            this.name = "Witch";
            this.cost = 5;
            this.picture = global::DominionSharp.Properties.Resources.witch;
            this.cards = 2;
        }
        public override void play()
        {
            base.play();
            Console.WriteLine("Witch Played");
            //TODO: give everyone one curse card if they dont have a moat
            List<Player> players = Turn.Instance.Players;
            for(int i = 0; i < players.Count; i++)
            {
                Player p = players[i];
                if (!p.Equals(Turn.Instance.getActivePlayer()))
                {
                    if (p.hasMoatInHand())
                    {
                        DialogResult prompt = MessageBox.Show(
                            "Would you like to defend with your Moat card?", "Player" + (i + 1), MessageBoxButtons.YesNo);
                        if (prompt == DialogResult.No)
                        {
                            p.gainCard(new VictoryCurse());
                        }
                    }
                    else
                    {
                        p.gainCard(new VictoryCurse());
                    }
                }
            }
        }
    }
}
