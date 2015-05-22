using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DominionSharp
{
    public class AttackBureaucrat : AttackCard
    {
        public AttackBureaucrat()
        {
            this.name = "Bureaucrat";
            this.cost = 4;
            this.picture = global::DominionSharp.Properties.Resources.bureaucrat; //TODO: Add Picture
        }

        protected override void attack(int playerNum)
        {
            MessageBox.Show(reveal(playerNum),
                "Player" + (playerNum + 1) + " reveals the following card(s):",
                MessageBoxButtons.OK);
        }

        protected String reveal(int playerNum)
        {
            String cards = "";
            Player p = Turn.Instance.Players[playerNum];
            for (int i = 0; i < p.getHand().Count; i++)
            {
                Card c = p.getHand()[i];
                if (c is VictoryCard)
                {
                    cards = c.Name + "\n";
                    Turn.Instance.Players[playerNum].placeCardFromHandOnDeck(i);
                    Console.WriteLine(playerNum);
                    break;
                }
                else
                {
                    cards += c.Name + "\n";
                }
            }
            return cards;
        }

        public override void play()
        {
            Console.WriteLine("Bureaucrat Played");
            //TODO: Gain a silver card; 
            //put it on top of your deck. 
            //Each other player reveals a Victory card 
            //from his hand and puts it on his deck 
            //(or reveals a hand with no Victory cards).
            Turn.Instance.getActivePlayer().placeCardOnDeck(new TreasureSilver());
            base.play();
        }
    }
}
