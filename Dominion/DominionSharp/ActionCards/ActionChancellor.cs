using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public class ActionChancellor : ActionCard
    {
        public ActionChancellor()
        {
            this.name = "Chancellor";
            this.cost = 3;
            this.picture = null; //TODO: Add Picture
        }
        public override void play(ref List<Player> targets)
        {
            Console.WriteLine("Chancellor Played");
        }
    }
}
