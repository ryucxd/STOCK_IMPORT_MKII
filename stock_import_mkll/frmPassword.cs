using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock_import_mkll
{
    public partial class frmPassword : Form
    {

        public int _pass { get; set; }
        public frmPassword()
        {
            InitializeComponent();
        }

        private void Btn_confirm_Click(object sender, EventArgs e)
        {
            if (txt_password.Text == "m1lkman")
            {
                GlobalVariables.isVerified = true;
                _pass = 1;
                this.Close();
            }
            else
                MessageBox.Show("Incorrect password!", "401!", MessageBoxButtons.OK);
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
