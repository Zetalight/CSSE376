using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public class ActionWitch:ActionCard
    {
        public ActionWitch()
        {
            this.name = "Witch";
            this.cost = 5;
            this.picture = null;
        }
        public override void play(ref List<Player> targets)
        {

        }
    }
}
