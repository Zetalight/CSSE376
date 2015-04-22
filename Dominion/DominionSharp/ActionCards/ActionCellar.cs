using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public class ActionCellar : ActionCard
    {
        public ActionCellar()
        {
            this.name = "Cellar";
            this.cost = 2;
            this.picture = null; //TODO: Add picture
        }
        public override void play(ref List<Player> targets)
        {
            Console.WriteLine("Cellar Played");
        }
    }
}
