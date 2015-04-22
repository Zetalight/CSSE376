using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public class ActionCellar : ActionCard
    {
        public ActionCellar()
        {
            this.name = "Cellar";
            this.cost = 2;
            this.picture = null; //TODO: Add picture
        }
        public override void play()
        {
            Console.WriteLine("Cellar Played");
        }
    }
}
