using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public class ActionFestival : ActionCard
    {
        public ActionFestival()
        {
            this.name = "Festival";
            this.cost = 5;
            this.picture = global::DominionSharp.Properties.Resources.festival;
            this.actions = 2;
            this.buys = 1;
            this.coins = 2;
        }
        public override void play()
        {
            base.play();
            Console.WriteLine("Festival Played");
        }
    }
}
