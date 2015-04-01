using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public class ActionChapel:ActionCard
    {
        public ActionChapel()
        {
            this.name = "Chapel";
            this.cost = 2;
            this.picture = global::DominionSharp.Properties.Resources.chapel; ;
        }
        public void play()
        {

        }
    }
}
