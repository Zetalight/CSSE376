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
        FormGame game;

        public FormCreate()
        {
            InitializeComponent();
            game = new FormGame();
            game.Hide();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            game.Show();
            game.setPlayerCount(Convert.ToInt32(comboNumPlayers.SelectedItem.ToString()));
            this.Hide();
        }
    }
}
