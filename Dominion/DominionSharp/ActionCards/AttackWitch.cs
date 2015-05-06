using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DominionSharp
{
    public class AttackWitch: AttackCard
    {
        public AttackWitch()
        {
            this.name = "Witch";
            this.cost = 5;
            this.picture = global::DominionSharp.Properties.Resources.witch;
            this.cards = 2;
        }

        protected override void attack(int playerNum)
        {
            Turn.Instance.Players[playerNum].gainCard(new VictoryCurse());
        }

        public override void play()
        {
            base.play();
            Console.WriteLine("Witch Played");
        }
    }
}
