using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public class ActionThief : ActionCard
    {
        public ActionThief()
        {
            this.name = "Thief";
            this.cost = 4;
            this.picture = global::DominionSharp.Properties.Resources.thief; //TODO: Add Picture
        }
        public override void play()
        {
            base.play();
            Console.WriteLine("Thief Played");
            //TODO: Each other player reveals the top 2 cards of his deck. 
            //If they revealed any Treasure cards, 
            //they trash one of them that you choose. 
            //You may gain any or all of these trashed cards. 
            //They discard the other revealed cards.
        }
    }
}
