using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public abstract class TreasureCard : Card
    {
        protected int value;

        public int Value
        {
            get
            {
                return value;
            }
        }

        public override void play()
        {
            Turn.Instance.Coins += value;
        }
    }
}
