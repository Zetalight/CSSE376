using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public class ActionLibrary : ActionCard
    {
        public ActionLibrary()
        {
            this.name = "Library";
            this.cost = 5;
            this.picture = global::DominionSharp.Properties.Resources.library; //TODO: Add Picture
        }
        public override void play()
        {
            base.play();
            Console.WriteLine("Library Played");
            //TODO: Draw until you have 7 cards in hand.
            //You may set aside any Action cards drawn this way, 
            //as you draw them; discard the
            //set aside cards after you finish drawing.
            while (Turn.Instance.getActivePlayer().getHandSize() < 7)
            {
                Turn.Instance.getActivePlayer().drawCard();
            }
        }
    }
}
