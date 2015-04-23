using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public class ActionMoat : ActionCard
    {
        public ActionMoat()
        {
            this.name = "Moat";
            this.cost = 2;
            this.picture = global::DominionSharp.Properties.Resources.moat ; //TODO: Add Picture
            this.cards = 2;
        }
        public override void play()
        {
            base.play();
            Console.WriteLine("Moat Played");

        }
    }
}
