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
    public partial class FormCreate : Form
    {

        public FormCreate()
        {
            InitializeComponent();
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            FormGame game = new FormGame(Convert.ToInt32(comboNumPlayers.SelectedItem.ToString()));
            game.Show();
            this.Hide();
        }
    }
}
