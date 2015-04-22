using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public class ActionMoat : ActionCard
    {
        public ActionMoat()
        {
            this.name = "Moat";
            this.cost = 2;
            this.picture = null ; //TODO: Add Picture
        }
        public override void play()
        {
            Console.WriteLine("Moat Played");
        }
    }
}
