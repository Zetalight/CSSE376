using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public class Turn
    {
        private static Turn instance;
        private Player activePlayer;
        private List<Player> players;
        private int currentPlayerIndex;
        private int coins;
        private int actions;
        private int buys;
        private int trashes;

        private Turn()
        {
        }

        public static Turn Instance
        {
            get
            {
                if (instance == null)
                    instance = new Turn();
                return instance;
            }
        }

        public void instantiate(ref List<Player> plist)
        {
            instance.players = plist;
            instance.activePlayer = plist[0];
            instance.currentPlayerIndex = 0;
            instance.reInitVals();
        }

        public int Actions
        {
            get
            {
                return actions;
            }
            set
            {
                actions = value;
            }
        }

        public int Buys
        {
            get
            {
                return buys;
            }
            set
            {
                buys = value;
            }
        }

        public int Coins
        {
            get
            {
                return coins;
            }
            set
            {
                coins = value;
            }
        }

        public int Trashes
        {
            get
            {
                return trashes;
            }
            set
            {
                trashes = value;
            }
        }

        public Player getActivePlayer()
        {
            return instance.activePlayer;
        }

        public void nextTurn()
        {
            instance.currentPlayerIndex = (instance.currentPlayerIndex + 1) % instance.players.Count;
            instance.activePlayer = instance.players[instance.currentPlayerIndex];
            instance.reInitVals();
        }

        public void reInitVals()
        {
            instance.coins = 0;
            instance.buys = 1;
            instance.actions = 1;
            instance.trashes = 0;
        }
    }
}
