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
        private bool throneRoom;
        public enum Phases { Action, Buy, Cleanup, Draw };
        private Phases phase;

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

        public void instantiate(List<Player> plist)
        {
            instance.players = plist;
            instance.activePlayer = plist[0];
            instance.currentPlayerIndex = 0;
            instance.reInitVals();
            instance.phase = Phases.Action;
        }

        public Phases Phase
        {
            get
            {
                return phase;
            }
            set
            {
                phase = value;
            }
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

        public List<Player> Players
        {
            get
            {
                return players;
            }
            set
            {
                players = value;
            }
        }

        public bool getThroneRoom()
        {
            return Instance.throneRoom;
        }
        public void setThroneRoom(bool value)
        {
            instance.throneRoom = value;
        }
        public void nextTurn()
        {
            instance.activePlayer.endTurn();
            instance.currentPlayerIndex = (instance.currentPlayerIndex + 1) % instance.players.Count;
            instance.activePlayer = instance.players[instance.currentPlayerIndex];
            instance.reInitVals();
        }

        public Phases getPhase()
        {
            return phase;
        }

        public void nextPhase()
        {
            switch (phase)
            {
                case Phases.Action:
                    phase = Phases.Buy;
                    break;
                case Phases.Buy:
                    phase = Phases.Cleanup;
                    break;
                case Phases.Cleanup:
                    phase = Phases.Draw;
                    break;
                case Phases.Draw:
                    nextTurn();
                    phase = Phases.Action;
                    break;
                default:
                    phase = Phases.Action;
                    break;
            }
        }

        public void reInitVals()
        {
            instance.coins = 0;
            instance.buys = 1;
            instance.actions = 1;
            instance.trashes = 0;
            instance.phase = Phases.Action;
            instance.setThroneRoom(false);
        }

        public int getActivePlayerIndex()
        {
            return currentPlayerIndex;
        }
    }
}
