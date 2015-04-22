using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public class ActionBureaucrat : ActionCard
    {
        public ActionBureaucrat()
        {
            this.name = "Bureaucrat";
            this.cost = 4;
            this.picture = null; //TODO: Add Picture
        }
        public override void play()
        {
            base.play();
            Console.WriteLine("Bureaucrat Played");
            //TODO: Gain a silver card; 
            //put it on top of your deck. 
            //Each other player reveals a Victory card 
            //from his hand and puts it on his deck 
            //(or reveals a hand with no Victory cards).
        }
    }
}
