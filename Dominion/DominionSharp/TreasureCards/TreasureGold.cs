using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public class TreasureGold : TreasureCard
    {
        public TreasureGold()
        {
            this.name = "Gold";
            this.cost = 6;
            this.value = 3;
            this.picture = null;
        }
    }
}