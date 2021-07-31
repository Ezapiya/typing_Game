using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Typing_game
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuser_name.Text.CompareTo("Admin") == 0 && txtpassword.Text.CompareTo("123") == 0)
            {
                flash_form ff = new flash_form();
                ff.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Password");
                txtuser_name.Text = "";
                txtpassword.Text = "";
                txtuser_name.Focus();
            }
        }
    }
}
