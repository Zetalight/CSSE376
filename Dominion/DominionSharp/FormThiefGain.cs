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
    public partial class FormThiefGain : Form
    {
        public FormThiefGain()
        {
            InitializeComponent();
            foreach (TreasureCard tc in AttackThief.trashedTreasures)
            {
                ckls_cards.Items.Add(tc.Name);
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            List<Player> players = Turn.Instance.Players;
            foreach(int i in ckls_cards.CheckedIndices)
            {
                
                Turn.Instance.Players[Turn.Instance.getActivePlayerIndex()]
                    .gainCard(AttackThief.trashedTreasures[i]);
            }
            this.Close();
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
        }
    }
}
