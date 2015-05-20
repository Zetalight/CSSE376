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
        private int number;
        private bool hidden = true;
        
        // list of cards that have been played for the 
        // current turn, but not yet discarded
        private List<Card> wumbo = new List<Card>();

        public Player(int number = -1)
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

            shuffleDeck();

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

        public void discardFromDeck(Card c)
        {
            for (int i = 0; i < deck.Count; i++)
            {
                if (deck[i].Equals(c))
                {
                    discard.Add(deck[i]);
                    deck.RemoveAt(i);
                    break;
                }
            }
        }

        public int getNumber()
        {
            return number;
        }

        // takes a random card from the deck and places it into the player's hand
        public Card drawCard()
        {
            Card c = new TreasureCopper();
            if (deck.Count == 0 && discard.Count != 0)
            {
                deck.AddRange(discard);
                discard.Clear();
                shuffleDeck();
            }
            if (deck.Count > 0)
            {
                hand.Add(deck[0]);
                c = deck[0];
                deck.RemoveAt(0);
            }
            return c;
        }

        public Card libraryDraw()
        {
            Card c;
            if (deck.Count == 0 && discard.Count != 0)
            {
                deck.AddRange(discard);
                discard.Clear();
                shuffleDeck();
            }
            c = deck[0];
            deck.RemoveAt(0);
            return c;
        }

        //reveals the top "n" cards of the deck
        public List<Card> revealTopDeck(int n)
        {
            List<Card> result = new List<Card>();
            for (int i = 1; i <= n; i++)
			{
                if (deck.Count < i) 
                {
                    deck.Clear();
                    deck.AddRange(discard);
                    discard.Clear();
                    shuffleDeck();
                    deck.InsertRange(0, result);
                    result.Add(deck[i - 1]);
                }
                else
                {
                    result.Add(deck[i - 1]);
                }
			}
            return result;
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

        public bool isHidden()
        {
            return this.hidden;
        }

        public void hide(bool hidden)
        {
            this.hidden = hidden;
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
            if (Turn.Instance.getThroneRoom() == true)
            {
                c.play();
                Turn.Instance.setThroneRoom(false);
            }
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
