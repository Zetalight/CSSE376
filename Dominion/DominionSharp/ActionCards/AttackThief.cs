using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DominionSharp
{
    public class AttackThief : AttackCard
    {
        private Dictionary<int, List<Card>> revealed = new Dictionary<int, List<Card>>();
        private Dictionary<int, List<TreasureCard>> treasures = new Dictionary<int, List<TreasureCard>>();
        public static List<TreasureCard> trashedTreasures = new List<TreasureCard>();

        public AttackThief()
        {
            this.name = "Thief";
            this.cost = 4;
            this.picture = global::DominionSharp.Properties.Resources.thief; //TODO: Add Picture
        }

        protected override void attack(int playerNum)
        {
            List<Card> rev = Turn.Instance.Players[playerNum].revealTopDeck(2);
            revealed.Add(playerNum, rev);
        }

        public override void play()
        {
            revealed.Clear();
            treasures.Clear();
            trashedTreasures.Clear();

            base.play();
            Console.WriteLine("Thief Played");
            //TODO: Each other player reveals the top 2 cards of his deck. 
            //If they revealed any Treasure cards, 
            //they trash one of them that you choose. 
            //You may gain any or all of these trashed cards. 
            //They discard the other revealed cards.
            String revNames = "";
            foreach (int i in revealed.Keys)
	        {
                revNames += "Player" + (i + 1) + " Revealed:\n";
                List<Card> rev = revealed[i];
                List<TreasureCard> tc = new List<TreasureCard>();
                foreach (Card c in rev)
                {
                    revNames += c.Name + "\n";
                    if (c is TreasureCard)
                    {
                        tc.Add((TreasureCard)c);
                    }
                }
                treasures.Add(i, tc);
	        }

            MessageBox.Show(revNames);

            foreach (int i in treasures.Keys)
            {
                revNames += "Player" + (i + 1) + " Revealed:\n";
                List<TreasureCard> tc = treasures[i];
                
                TreasureCard a = null;
                TreasureCard b = null;
                if (tc.Count >= 1)
                {
                    a = tc[0];
                    if (tc.Count >= 2)
                    {
                        b = tc[1];
                    }
                }
                FormThiefTrash ftt = new FormThiefTrash(i + 1, a, b);
                ftt.ShowDialog();
            }

            FormThiefGain ftg = new FormThiefGain();
            ftg.ShowDialog();
        }
    }
}
