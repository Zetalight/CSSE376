using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public class ActionMarket : ActionCard
    {
        public ActionMarket()
        {
            this.name = "Market";
            this.cost = 5;
            this.picture = null; //TODO: Add Picture
            this.coins = 1;
            this.cards = 1;
            this.actions = 1;
            this.buys = 1;
        }
        public override void play()
        {
            base.play()
            Console.WriteLine("Market Played");
        }
    }
}
