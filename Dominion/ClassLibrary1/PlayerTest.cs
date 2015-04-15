using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibrary1
{
    [TestClass()]
    public class PlayerTest
    {
        [TestMethod()]
        public void TestThatPlayerInitializes()
        {
            Player p = new Player();
        }
    }
}
