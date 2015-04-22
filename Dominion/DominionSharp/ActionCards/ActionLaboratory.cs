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
            this.picture = null; //TODO: Add Picture
        }
        public override void play(ref List<Player> targets)
        {
            Console.WriteLine("Laboratory Played");
        }
    }
}
