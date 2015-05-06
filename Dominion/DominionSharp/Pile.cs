using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    class Pile
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
        private Card getCard()
        {
            return this.card;
        }
        private void setCount(int count)
        {
            this.count = count;
        }
        private int getCount()
        {
            return this.count;
        }
        private void draw()
        {
            count--;
        }
    }
}
