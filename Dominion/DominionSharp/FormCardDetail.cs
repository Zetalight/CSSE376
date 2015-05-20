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
    public partial class FormCardDetail : Form
    {
        Card card;
        public FormCardDetail(Card c, bool canConfirm, int n)
        {
            InitializeComponent();
            this.card = c;
            this.picbox_card.BackgroundImage = card.Picture;
            if (!canConfirm)
            {
                this.btn_confirm.Enabled = false;
            }

            this.lbl_count.Text = "" + n;
        }

        public FormCardDetail(Card c, bool canConfirm)
        {
            InitializeComponent();
            this.card = c;
            this.picbox_card.BackgroundImage = card.Picture;
            if (!canConfirm)
            {
                this.btn_confirm.Enabled = false;
            }
        }

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

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }
    }
}
