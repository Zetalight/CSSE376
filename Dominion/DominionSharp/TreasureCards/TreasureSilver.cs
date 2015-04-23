using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public class TreasureSilver : TreasureCard
    {
        public TreasureSilver()
        {
            this.name = "Silver";
            this.cost = 3;
            this.value = 2;
            this.picture = global::DominionSharp.Properties.Resources.silver;
        }
    }
}
