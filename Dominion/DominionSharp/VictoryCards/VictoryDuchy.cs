using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public class VictoryDuchy : VictoryCard
    {
        public VictoryDuchy()
        {
            this.name = "Duchy";
            this.cost = 5;
            this.victoryPoints = 3;
            this.picture = global::DominionSharp.Properties.Resources.duchy;
        }
    }
}
