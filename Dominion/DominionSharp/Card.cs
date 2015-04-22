using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionSharp
{
    public abstract class Card
    {
        protected string name;
        protected int cost;
        protected Image picture;

        public string Name
        {
            get 
            {
                return name; 
            }
        }

        public int Cost
        {
            get
            {
                return cost;
            }
        }

        public Image Picture
        {
            get
            {
                return picture;
            }
        }
        public abstract void play();
    }
}
