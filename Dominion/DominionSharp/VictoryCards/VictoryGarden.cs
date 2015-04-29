using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp.VictoryCards
{
    public class VictoryGardens : VictoryCard
    {
        public VictoryGardens()
        {
            this.name = "Gardens";
            this.cost = 0;
            this.victoryPoints = 0;
            this.picture = global::DominionSharp.Properties.Resources.garden;
        }
    }
}
