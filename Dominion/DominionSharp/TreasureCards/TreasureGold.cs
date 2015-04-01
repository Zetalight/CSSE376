using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    class TreasureGold : TreasureCard
    {
        public TreasureGold()
        {
            this.name = "Gold";
            this.cost = 3;
            this.value = this.cost;
            this.picture = null;
        }
    }
}