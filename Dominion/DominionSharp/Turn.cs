using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public class Turn
    {
        private Player activePlayer;
        private List<Player> players;
        private int currentPlayerIndex;
        private int coins;
        private int actions;
        private int buys;
        private int trashes;

        public Turn(ref List<Player> plist)
        {
            this.players = plist;
            this.currentPlayerIndex = 0;
            activePlayer = plist[0];
            this.reInitVals();
        }

        public int getActions()
        {
            return this.actions;
        }

        public void setActions(int i)
        {
            this.actions = i;
        }

        public int getBuys()
        {
            return this.buys;
        }

        public void setBuys(int i)
        {
            this.buys = i;
        }

        public int getCoins()
        {
            return this.coins;
        }

        public void setCoins(int i)
        {
            this.coins = i;
        }

        public int getTrashes()
        {
            return this.trashes;
        }

        public void setTrashes(int i)
        {
            this.trashes = i;
        }

        public Player getActivePlayer()
        {
            return this.activePlayer;
        }

        public void nextTurn()
        {
            this.currentPlayerIndex = (this.currentPlayerIndex + 1) % this.players.Count;
            this.activePlayer = this.players[this.currentPlayerIndex];
            this.reInitVals();
        }

        public void reInitVals()
        {
            this.coins = 0;
            this.buys = 1;
            this.actions = 1;
            this.trashes = 0;
        }
    }
}
