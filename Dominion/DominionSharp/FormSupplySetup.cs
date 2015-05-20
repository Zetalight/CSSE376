using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DominionSharp
{
    public partial class FormSupplySetup : Form
    {
        private List<Card> cards = new List<Card>() { new ActionAdventure(),
                new AttackBureaucrat(), new ActionCellar(), new ActionChancellor(), 
                new ActionChapel(), new ActionCouncilRoom(), new ActionFeast(), 
                new ActionFestival(), new ActionLaboratory(), new ActionLibrary(), 
                new ActionMarket(), new AttackMilitia(), new ActionMine(), 
                new ActionMoat(), new ActionMoneylender(), new ActionRemodel(), 
                new ActionSmithy(), new AttackSpy(), new AttackThief(), 
                new ActionThroneRoom(), new ActionVillage(), new AttackWitch(), 
                new ActionWoodcutter(), new ActionWoodcutter(), new ActionWorkshop(), 
                new VictoryGardens()};

        private List<Card> supply = new List<Card>();
        private int numPlayers;

        public FormSupplySetup(int numPlayers)
        {
            InitializeComponent();
            this.numPlayers = numPlayers;
            foreach (Card c in cards)
            {
                ckls_cards.Items.Add(c.Name);
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            foreach (int i in ckls_cards.CheckedIndices)
            {
                supply.Add(cards[i]);
            }
            Console.WriteLine(supply.Count);
            FormGame game = new FormGame();
            game.setPlayerCount(numPlayers, supply);
            game.Show();
            this.Hide();
        }

        private void ckls_cards_SelectedIndexChanged(object sender, EventArgs e) { }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private void ckls_cards_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int checkCount = ckls_cards.CheckedItems.Count;
            if (e.NewValue == CheckState.Checked)
            {
                checkCount++;
            }
            else
            {
                checkCount--;
            }

            if (checkCount == 10)
            {
                btn_ok.Enabled = true;
            }
            else
            {
                btn_ok.Enabled = false;
            }
        }

        private void btn_randomize_Click(object sender, EventArgs e)
        {
            foreach (int i in ckls_cards.CheckedIndices)
            {
                ckls_cards.SetItemChecked(i, false);
            }
            List<int> uncheckedIndices = new List<int>();
            for (int i = 0; i < ckls_cards.Items.Count; i++)
            {
                uncheckedIndices.Add(i);
            }
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                int ck = r.Next(uncheckedIndices.Count);
                ckls_cards.SetItemChecked(uncheckedIndices[ck], true);
                uncheckedIndices.RemoveAt(ck);
            }
            /*
            FormGame game = new FormGame();
            game.setPlayerCount(numPlayers);
            game.Show();
            */
        }
    }
}
