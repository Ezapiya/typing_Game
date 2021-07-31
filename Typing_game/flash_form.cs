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
    public partial class flash_form : Form
    {
        public flash_form()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Form1 mf = new Form1();
            mf.Show();
            this.Hide();
            timer1.Stop();
        }
    }
}
