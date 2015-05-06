using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public class AttackSpy : AttackCard
    {
        public AttackSpy()
        {
            this.name = "Spy";
            this.cost = 4;
            this.picture = global::DominionSharp.Properties.Resources.spy; //TODO: Add Picture
            this.cards = 1;
            this.actions = 1;
        }

        protected override void attack(int playerNum)
        {
            throw new NotImplementedException();
        }

        public override void play()
        {
            base.play();
            Console.WriteLine("Spy Played");
            //TODO: Each player (including you) 
            //reveals the top card of his deck and 
            //either discards it or puts it back, 
            //your choice.
        }
    }
}
