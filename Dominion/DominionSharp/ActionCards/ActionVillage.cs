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
            this.picture = null;
        }
        public override void play(ref List<Player> targets)
        {

        }
    }
}
