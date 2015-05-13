using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DominionSharp
{
    public class AttackMilitia : AttackCard
    {
        public AttackMilitia()
        {
            this.name = "Militia";
            this.cost = 4;
            this.picture = global::DominionSharp.Properties.Resources.militia;
            this.coins = 2;
        }

        protected override void attack(int playerNum)
        {
            Player p = Turn.Instance.Players[playerNum];
            if (p.getHand().Count > 3)
            {
                FormMilitiaAttack fma = new FormMilitiaAttack(p, playerNum);
                fma.ShowDialog();
            }
        }

        public override void play()
        {
            base.play();
            Console.WriteLine("Militia Played");
            //TODO: Each other player discards 
            //down to 3 cards in his hand.
        }
    }
}
