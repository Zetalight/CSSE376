using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public class ActionFeast : ActionCard
    {
        public ActionFeast()
        {
            this.name = "Feast";
            this.cost = 4;
            this.picture = null; //TODO: Add Picture
        }
        public override void play()
        {
            base.play();
            Console.WriteLine("Feast Played");
            //TODO:Trash this for a card up to 5 coins;
        }
    }
}
