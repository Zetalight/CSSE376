using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public class Player
    {
        private int coins = 0;
        private int actions = 1;
        private int buys = 1;
        private List<Card> deck = new List<Card>();
        private List<Card> hand = new List<Card>();

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
        public Card drawCard()
        {
            Random rng = new Random();
            int index = rng.Next(deck.Count);
            Card c = deck[index];
            hand.Add(c);
            deck.RemoveAt(index);
            return c;
        }

        public List<Card> getDeck()
        {
            return deck;
        }

        public List<Card> getHand()
        {
            return hand;
        }

        public int getCoins()
        {
            return this.coins;
        }

        public int getActions()
        {
            return this.actions;
        }

        public int getBuys()
        {
            return this.buys;
        }

        public void setCoins(int c)
        {
            this.coins = c;
        }

        public void setActions(int a)
        {
            this.actions = a;
        }

        public void setBuys(int b)
        {
            this.buys = b;
        }
    }
}
