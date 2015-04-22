using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DominionSharp
{
    public class Player
    {
        private List<Card> deck = new List<Card>();
        private List<Card> hand = new List<Card>();
        private List<Card> discard = new List<Card>();
        
        // list of cards that have been played for the 
        // current turn, but not yet discarded
        private List<Card> wumbo = new List<Card>();

        public Player()
        {
            // set initial deck cards (7 coppers, 3 estates)
            for (int i = 0; i < 7; i++)
            {
                deck.Add(new TreasureCopper());
            }
            for (int i = 0; i < 3; i++)
            {
                deck.Add(new VictoryEstate());
            }

            // draw initial hand of 5 cards
            for (int i = 0; i < 5; i++)
            {
                drawCard();
            }
        }

        // takes a random card from the deck and places it into the player's hand
        public void drawCard()
        {
            if (deck.Count == 0 && discard.Count != 0)
            {
                deck.AddRange(discard);
                discard.Clear();
            }
            if (deck.Count > 0)
            {
                Random rng = new Random();
                int index = rng.Next(deck.Count);
                Card c = deck[index];
                hand.Add(c);
                deck.RemoveAt(index);
            }
        }

        public List<Card> getDeck()
        {
            return deck;
        }

        public List<Card> getHand()
        {
            return hand;
        }

        public List<Card> getDiscard()
        {
            return discard;
        }

        public List<Card> getWumbo()
        {
            return wumbo;
        }

        public void endTurn()
        {
            discard.AddRange(wumbo);
            wumbo.Clear();
        }

        public void playCard(Card c)
        {
            hand.Remove(c);
            wumbo.Add(c);
            c.play();
        }

        public int getDeckSize()
        {
            return this.deck.Count;
        }

        public int getHandSize()
        {
            return this.hand.Count;
        }
    }
}
