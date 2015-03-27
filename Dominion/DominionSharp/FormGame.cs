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
    public partial class FormGame : Form
    {
        public FormGame()
        {
            InitializeComponent();
        }

        public String getLabel3Text()
        {
            return Label3.Text;
        }

        public String getLabel2Text()
        {
            return Label2.Text;
        }

        public String getLabel1Text()
        {
            return Label1.Text;
        }
    }
}
