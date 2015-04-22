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
        private int coins;
        private int actions;
        private int buys;
        private int trashes;

        public Turn(ref List<Player> plist)
        {
            this.players = plist;
            activePlayer = plist[1];
        }

        public int getActions()
        {
            return this.actions;
        }
        public int getBuys()
        {
            return this.buys;
        }
        public int getCoins()
        {
            return this.coins;
        }
        public Player getActivePlayer()
        {
            return this.activePlayer;
        }
        public void nextTurn()
        {

        }
    }
}
