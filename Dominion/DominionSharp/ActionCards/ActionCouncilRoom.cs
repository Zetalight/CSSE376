using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public class ActionCouncilRoom : ActionCard
    {
        public ActionCouncilRoom()
        {
            this.name = "Council Room";
            this.cost = 5;
            this.picture = global::DominionSharp.Properties.Resources.councilroom; //TODO: Add Picture
            this.cards = 4;
            this.buys = 1;
        }
        public override void play()
        {
            base.play();
            Console.WriteLine("Council Room Played");
            //TODO: All other players draw a card
            List<Player> players = Turn.Instance.Players;
            for (int i = 0; i < players.Count; i++)
            {
                if (!players[i].Equals(Turn.Instance.getActivePlayer()))
                {
                    players[i].drawCard();
                }
            }
            Turn.Instance.Players = players;
        }
    }
}
