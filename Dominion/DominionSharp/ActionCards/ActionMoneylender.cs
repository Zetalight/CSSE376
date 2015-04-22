using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public class ActionMoneylender : ActionCard
    {
        public ActionMoneylender()
        {
            this.name = "Moneylender";
            this.cost = 4;
            this.picture = null; //TODO: Add Picture
        }
        public override void play(ref List<Player> targets)
        {
            Console.WriteLine("Moneylender Played");
        }
    }
}
