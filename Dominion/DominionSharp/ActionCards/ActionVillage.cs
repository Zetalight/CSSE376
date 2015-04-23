using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public class ActionVillage:ActionCard
     {
        public ActionVillage()
        {
            this.name = "Village";
            this.cost = 3;
            this.picture = global::DominionSharp.Properties.Resources.village;
            this.cards = 1;
            this.actions = 2;
        }
        public override void play()
        {
            base.play();
        }
    }
}
