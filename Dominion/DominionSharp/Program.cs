using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DominionSharp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new FormCreate());
            /*
            Player test = new Player();
            List<Card> cards = new List<Card>();
            cards.Add(new ActionChapel());
            cards.Add(new TreasureCopper());
            cards.Add(new TreasureGold());
            cards.Add(new VictoryDuchy());
            cards.Add(new ActionFeast());
            cards.Add(new ActionVillage());
            cards.Add(new TreasureSilver());
            test.setHand(cards);
            List<Player> players = new List<Player>();
            players.Add(test);
            Turn.Instance.instantiate(players);
            Application.Run(new FormMilitiaAttack(test, 0));
            test = Turn.Instance.getActivePlayer();
            foreach (Card c in test.getHand())
            {
                Console.WriteLine(c.Name);
            }
            */
        }
    }
}
