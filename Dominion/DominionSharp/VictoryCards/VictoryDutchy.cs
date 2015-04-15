using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public class VictoryDutchy : VictoryCard
    {
        public VictoryDutchy()
        {
            this.name = "Dutchy";
            this.cost = 5;
            this.victoryPoints = 3;
            this.picture = null;
        }
    }
}
