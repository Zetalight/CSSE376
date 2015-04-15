﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public class Player
    {
        public int coins = 0;
        public int actions = 1;
        public int buys = 1;

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
