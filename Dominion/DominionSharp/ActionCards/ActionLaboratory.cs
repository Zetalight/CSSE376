using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public class ActionLaboratory : ActionCard
    {
        public ActionLaboratory()
        {
            this.name = "Laboratory";
            this.cost = 5;
            this.picture = global::DominionSharp.Properties.Resources.laboratory; //TODO: Add Picture
            this.cards = 2;
            this.actions = 1;
        }
        public override void play()
        {
            base.play();
            Console.WriteLine("Laboratory Played");
        }
    }
}
