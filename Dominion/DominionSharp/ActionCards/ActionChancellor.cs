﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public class ActionChancellor : ActionCard
    {
        public ActionChancellor()
        {
            this.name = "Chancellor";
            this.cost = 3;
            this.picture = global::DominionSharp.Properties.Resources.chancellor; //TODO: Add Picture
            this.coins = 2;
        }
        public override void play()
        {
            base.play();
            Console.WriteLine("Chancellor Played");
            //TODO: You may immediately put your deck into your discard pile.
            Player current = Turn.Instance.getActivePlayer();
            List<Card> newDiscard = current.getDiscard();
            newDiscard.AddRange(current.getDeck());
            typeof(Player)
                .GetField("discard", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                .SetValue(Turn.Instance.getActivePlayer(), newDiscard);
            typeof(Player)
                .GetField("deck", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                .SetValue(Turn.Instance.getActivePlayer(), new List<Card>());
        }
    }
}
