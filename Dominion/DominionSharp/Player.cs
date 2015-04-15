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
        private List<Card> deck;
        private List<Card> hand;

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
