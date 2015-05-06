using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public class Pile
    {
        private Card card;
        private int count;

        public Pile(Card card, int count)
        {
            this.card = card;
            this.count = count;
        }
        public Pile(Card card)
        {
            this.card = card;
            this.count = 10;
        }
        private void setCard(Card card){
            this.card = card;
        }
        public Card getCard()
        {
            return this.card;
        }
        private void setCount(int count)
        {
            this.count = count;
        }
        public int getCount()
        {
            return this.count;
        }
        public bool draw()
        {
            count--;
            return this.count > 0;
        }
    }
}
