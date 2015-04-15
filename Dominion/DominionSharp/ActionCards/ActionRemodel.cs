using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public class ActionRemodel : ActionCard
    {
        public ActionRemodel()
        {
            this.name = "Remodel";
            this.cost = 4;
            this.picture = null; //TODO: Add Picture
        }
        public override void play()
        {
            Console.WriteLine("Remodel Played");
        }
    }
}