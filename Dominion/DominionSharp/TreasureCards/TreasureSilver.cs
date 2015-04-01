using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    class TreasureSilver : TreasureCard
    {
        public TreasureSilver()
        {
            this.name = "Silver";
            this.cost = 2;
            this.value = this.cost;
            this.picture = null;
        }
    }
}
