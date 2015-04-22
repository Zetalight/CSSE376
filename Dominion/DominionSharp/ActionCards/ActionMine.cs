using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public class ActionMine : ActionCard
    {
        public ActionMine()
        {
            this.name = "Mine";
            this.cost = 5;
            this.picture = null; //TODO: Add Picture
        }
        public override void play()
        {
            base.play();
            Console.WriteLine("Mine Played");
            //TODO: Trash a Treasure card from your hand.
            //Gain a Treasure card costing up to $3 more; 
            //put it into your hand.
        }
    }
}
