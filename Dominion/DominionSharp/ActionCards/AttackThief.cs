using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public class AttackThief : AttackCard
    {
        public AttackThief()
        {
            this.name = "Thief";
            this.cost = 4;
            this.picture = global::DominionSharp.Properties.Resources.thief; //TODO: Add Picture
        }

        protected override void attack(int playerNum)
        {
            throw new NotImplementedException();
        }

        public override void play()
        {
            base.play();
            Console.WriteLine("Thief Played");
            //TODO: Each other player reveals the top 2 cards of his deck. 
            //If they revealed any Treasure cards, 
            //they trash one of them that you choose. 
            //You may gain any or all of these trashed cards. 
            //They discard the other revealed cards.
        }
    }
}
