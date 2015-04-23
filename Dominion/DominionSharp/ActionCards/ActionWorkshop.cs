using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public class ActionWorkshop : ActionCard
    {
        public ActionWorkshop()
        {
            this.name = "Workshop";
            this.cost = 3;
            this.picture = global::DominionSharp.Properties.Resources.workshop; //TODO: Add Picture
        }
        public override void play()
        {
            base.play();
            Console.WriteLine("Workshop Played");
            //TODO: Get 1 card that costs up to 4 coins
        }
    }
}
