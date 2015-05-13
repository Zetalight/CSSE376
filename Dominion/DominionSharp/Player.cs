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
        private int number = -1;
        
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

        public Player(int number)
        {
            this.number = number;
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

        public void discardTopCardOfDeck()
        {
            Card c = this.deck[0];
            this.deck.RemoveAt(0);
            this.discard.Add(c);
        }

        public int getNumber()
        {
            return number;
        }

        // takes a random card from the deck and places it into the player's hand
        public void drawCard()
        {
            if (deck.Count == 0 && discard.Count != 0)
            {
                deck.AddRange(discard);
                discard.Clear();
                shuffleDeck();
            }
            if (deck.Count > 0)
            {
                hand.Add(deck[0]);
                deck.RemoveAt(0);
            }
        }

        private void shuffleDeck()
        {
            Random rng = new Random();
            int n = deck.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card val = deck[k];
                deck[k] = deck[n];
                deck[n] = val;
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
            discard.AddRange(hand);
            discard.AddRange(wumbo);
            wumbo.Clear();
            hand.Clear();
            for (int i = 0; i < 5; i++)
            {
                drawCard();
            }
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

        public void gainCard(Card c)
        {
            discard.Add(c);
        }

        public bool hasMoatInHand()
        {
            foreach (Card c in hand)
            {
                if (c is ActionMoat)
                {
                    return true;
                }
            }
            return false;
        }

        public void placeCardFromHandOnDeck(int i)
        {
            Card c = hand[i];
            hand.RemoveAt(i);
            deck.Insert(0, c);
        }

        public void setHand(List<Card> cards)
        {
            hand = cards;
        }
    }
}
