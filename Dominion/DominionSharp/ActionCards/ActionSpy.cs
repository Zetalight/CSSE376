﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public class ActionSpy : ActionCard
    {
        public ActionSpy()
        {
            this.name = "Spy";
            this.cost = 4;
            this.picture = null; //TODO: Add Picture
            this.cards = 1;
            this.actions = 1;
        }
        public override void play()
        {
            base.play();
            Console.WriteLine("Spy Played");
            //TODO: Each player (including you) 
            //reveals the top card of his deck and 
            //either discards it or puts it back, 
            //your choice.
        }
    }
}
