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
            this.name = "Estate";
            this.cost = 0;
            this.victoryPoints = -1;
            this.picture = null;
        }
    }
}
