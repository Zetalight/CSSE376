using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public class ActionThroneRoom : ActionCard
    {
        public ActionThroneRoom()
        {
            this.name = "Throne Room";
            this.cost = 4;
            this.picture = null; //TODO: Add Picture
        }
        public override void play()
        {
            Console.WriteLine("Throne Room Played");
        }
    }
}
