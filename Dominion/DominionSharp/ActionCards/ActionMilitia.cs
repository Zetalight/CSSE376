using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public class ActionMilitia : ActionCard
    {
        public ActionMilitia()
        {
            this.name = "Militia";
            this.cost = 4;
            this.picture = global::DominionSharp.Properties.Resources.militia; //TODO: Add Picture
            this.coins = 2;
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
