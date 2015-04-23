using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public class ActionAdventure : ActionCard
    {
        public ActionAdventure()
        {
            this.name = "Adventure";
            this.cost = 6;
            this.picture = global::DominionSharp.Properties.Resources.adventurer;
        }
        public override void play()
        {
            base.play();
            Console.WriteLine("Adventure Played");
            //TODO: Reveal cards from your deck until you reveal 
            //2 Treasure cards. 
            //Put those Treasure cards in your hand and 
            //discard the other revealed cards.
        }
    }
}
