using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public class AttackMilitia : AttackCard
    {
        public AttackMilitia()
        {
            this.name = "Militia";
            this.cost = 4;
            this.picture = global::DominionSharp.Properties.Resources.militia; //TODO: Add Picture
            this.coins = 2;
        }

        protected override void attack(int playerNum)
        {
            throw new NotImplementedException();
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
