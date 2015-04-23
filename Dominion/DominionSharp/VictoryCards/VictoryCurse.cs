using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public class VictoryCurse : VictoryCard
    {
        public VictoryCurse()
        {
            this.name = "Curse";
            this.cost = 0;
            this.victoryPoints = -1;
            this.picture = global::DominionSharp.Properties.Resources.curse;
        }
    }
}
