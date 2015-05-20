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
    public partial class FormThiefTrash : Form
    {
        TreasureCard a, b;

        public FormThiefTrash(int playerNum, TreasureCard a, TreasureCard b)
        {
            InitializeComponent();
            this.a = a;
            this.b = b;
            this.Text += playerNum;

            if (a == null)
            {
                btn_trash1.Enabled = false;
                btn_trash1.Text = "None";
            }
            else
            {
                btn_trash1.Text = a.Name;
            }

            if (b == null)
            {
                btn_trash2.Enabled = false;
                btn_trash2.Text = "None";
            }
            else
            {
                btn_trash2.Text = b.Name;
            }
        }

        private void btn_none_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_trash1_Click(object sender, EventArgs e)
        {
            AttackThief.trashedTreasures.Add(a);
            this.Close();
        }

        private void btn_trash2_Click(object sender, EventArgs e)
        {
            AttackThief.trashedTreasures.Add(a);
            this.Close();
        }
    }
}
