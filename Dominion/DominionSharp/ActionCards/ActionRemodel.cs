using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public class ActionRemodel : ActionCard
    {
        public ActionRemodel()
        {
            this.name = "Remodel";
            this.cost = 4;
            this.picture = global::DominionSharp.Properties.Resources.remodel; //TODO: Add Picture
        }
        public override void play()
        {
            base.play();
            Console.WriteLine("Remodel Played");
            //TODO: Trash a card from your hand. 
            //Gain a card costing up to $2 
            //more than the trashed card.
        }
    }
}