using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DominionSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibrary1
{
    [TestClass()]
    class TurnTest
    {
        [TestMethod()]
        public void TestThatTurnInitializes()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Player p3 = new Player();
            List<Player> plist = new List<Player> {p1, p2, p3};
            Turn target = new Turn(ref plist);
            
        }

        [TestMethod()]
        public void TestNextTurn()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Player p3 = new Player();
            List<Player> plist = new List<Player> { p1, p2, p3 };
            Turn target = new Turn(ref plist);
            target.nextTurn();
        }
    }
}
