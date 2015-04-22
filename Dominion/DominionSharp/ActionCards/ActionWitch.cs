using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public class ActionWitch:ActionCard
    {
        public ActionWitch()
        {
            this.name = "Witch";
            this.cost = 5;
            this.picture = null;
            this.cards = 2;
        }
        public override void play()
        {
            base.play();
            Console.WriteLine("Witch Played");
            //TODO: give everyone one curse card if they dont have a moat
        }
    }
}
