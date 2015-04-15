using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public abstract class VictoryCard : Card
    {
        protected int victoryPoints;

        public int VictoryPoints
        {
            get
            {
                return victoryPoints;
            }
        }
    }
}
