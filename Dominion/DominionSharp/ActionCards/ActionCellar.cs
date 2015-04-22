using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public class ActionCellar : ActionCard
    {
        public ActionCellar()
        {
            this.name = "Cellar";
            this.cost = 2;
            this.picture = null; //TODO: Add picture
            this.actions = 1;
        }
        public override void play()
        {
            base.play();
            Console.WriteLine("Cellar Played");
            //TODO: Discard any number of cards.
            //+1 Card per card discarded.
        }
    }
}
