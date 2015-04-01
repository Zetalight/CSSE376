using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public class VictoryEstate : VictoryCard
    {
        public VictoryEstate()
        {
            this.name = "Estate";
            this.cost = 2;
            this.victoryPoints = 1;
            this.picture = null;
        }
    }
}
