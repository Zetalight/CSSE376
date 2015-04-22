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
            this.picture = null; //TODO: Add Picture
        }
        public override void play(ref List<Player> targets)
        {
            Console.WriteLine("Adventure Played");
        }
    }
}
