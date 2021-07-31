using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlServerCe;



using System.Windows.Forms;


namespace Typing_game
{
    public partial class Form1 : Typing_game.Base_form.Base_form
    {
        SqlCeConnection conn;
        SqlCeCommand cmd;
        SqlCeDataReader res;
        DataTable word_dt = new DataTable();
        Random ren = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            load_word_data_table();
           // cmd.CommandText = "select max(id) as maxid from " + cmblanguage.Text.ToLower();
            //rs = cmd.ExecuteReader();

            load_word_in_text_box(txtdata1);
            load_word_in_text_box(txtdata2);
            load_word_in_text_box(txtdata3);
            load_word_in_text_box(txtdata4);
            load_word_in_text_box(txtdata5);
            load_word_in_text_box(txtdata6);
            load_word_in_text_box(txtdata7);
            load_word_in_text_box(txtdata8);
            load_word_in_text_box(txtdata9);
            load_word_in_text_box(txtdata10);
            txt_type_text.Focus();
        }
        private void load_word_in_text_box(TextBox tb)
        {
            int j = 0;
           
            j = ren.Next(0, word_dt.Rows.Count-1);
            tb.Text = Convert.ToString( word_dt.Rows[j][0]);
        }
        private void load_word_data_table()
        {

            conn = new SqlCeConnection(@"Data Source=|DataDirectory|\Game_database.sdf");
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "select eng from data_table where  eng like '__' or eng like '_'";
            res = cmd.ExecuteReader();
            word_dt.Load(res);
            res.Close();

        }
        private void start_timer()
        {
            int i = 0;
            Random ren = new Random();
            i = ren.Next(1, 10);
            //MessageBox.Show(Convert.ToString(i));
            switch(i)
            {
                case 1:
                    timer1.Enabled = true;
                    load_word_in_text_box(txtdata1);
                    break;
                case 2:
                    timer2.Enabled = true;
                    load_word_in_text_box(txtdata2);
                    break;
                case 3:
                    timer3.Enabled = true;
                    load_word_in_text_box(txtdata3);
                    break;
                case 4:
                    timer4.Enabled = true;
                    load_word_in_text_box(txtdata4);
                    break;
                case 5:
                    timer5.Enabled = true;
                    load_word_in_text_box(txtdata5);
                    break;
                case 6:
                    timer6.Enabled = true;
                    load_word_in_text_box(txtdata6);
                    break;
                case 7:
                    timer7.Enabled = true;
                    load_word_in_text_box(txtdata7);
                    break;
                case 8:
                    timer8.Enabled = true;
                    load_word_in_text_box(txtdata8);
                    break;
                case 9:
                    timer9.Enabled = true;
                    load_word_in_text_box(txtdata9);
                    break;
                case 10:
                    timer10.Enabled = true;
                    load_word_in_text_box(txtdata10);
                    break;
                
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            txtdata1.Top = txtdata1.Top + 2;
            //txtdata1.Text = Convert.ToString(txtdata1.Top);
            if (txtdata1.Top >= 350)
            {
                txtdata1.Top = 0;
                timer1.Enabled = false;
                start_timer();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            txtdata2.Top = txtdata2.Top + 2;
            //txtdata1.Text = Convert.ToString(txtdata1.Top);
            if (txtdata2.Top >= 350)
            {
                txtdata2.Top = 0;
                timer2.Enabled = false;
                start_timer();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            txtdata3.Top = txtdata3.Top + 2;
            //txtdata1.Text = Convert.ToString(txtdata1.Top);
            if (txtdata3.Top >= 350)
            {
                txtdata3.Top = 0;
                timer3.Enabled = false;
                start_timer();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            txtdata4.Top = txtdata4.Top + 2;
            //txtdata1.Text = Convert.ToString(txtdata1.Top);
            if (txtdata4.Top >= 350)
            {
                txtdata4.Top = 0;
                timer4.Enabled = false;
                start_timer();
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            txtdata5.Top = txtdata5.Top + 2;
            //txtdata1.Text = Convert.ToString(txtdata1.Top);
            if (txtdata5.Top >= 350)
            {
                txtdata5.Top = 0;
                timer5.Enabled = false;
                start_timer();
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            txtdata6.Top = txtdata6.Top + 2;
            //txtdata1.Text = Convert.ToString(txtdata1.Top);
            if (txtdata6.Top >= 350)
            {
                txtdata6.Top = 0;
                timer6.Enabled = false;
                start_timer();
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            txtdata7.Top = txtdata7.Top + 2;
            //txtdata1.Text = Convert.ToString(txtdata1.Top);
            if (txtdata7.Top >= 350)
            {
                txtdata7.Top = 0;
                timer7.Enabled = false;
                start_timer();
            }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            txtdata8.Top = txtdata8.Top + 2;
            //txtdata1.Text = Convert.ToString(txtdata1.Top);
            if (txtdata8.Top >= 350)
            {
                txtdata8.Top = 0;
                timer8.Enabled = false;
                start_timer();
            }
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            txtdata9.Top = txtdata9.Top + 2;
            //txtdata1.Text = Convert.ToString(txtdata1.Top);
            if (txtdata9.Top >= 350)
            {
                txtdata9.Top = 0;
                timer9.Enabled = false;
                start_timer();
            }
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            txtdata10.Top = txtdata10.Top + 2;
            //txtdata1.Text = Convert.ToString(txtdata1.Top);
            if (txtdata10.Top >= 350)
            {
                txtdata10.Top = 0;
                timer10.Enabled = false;
                start_timer();
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void change_leavel()
        {
            MessageBox.Show("You reach next level");
            labtotal_paint.Text = "0";
            if (optlevel_1.Checked == true)
            {
                optlevel_1.Checked = false;
                optlevel_2.Checked = true;
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\Game_database.sdf");
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "select eng from data_table where eng like '____' or eng like '___' or eng like '__' or eng like '_'";
                res = cmd.ExecuteReader();
                word_dt.Load(res);
                res.Close();
                goto abc;
            }
            if (optlevel_2.Checked == true)
            {
                optlevel_2.Checked = false;
                optlevel_3.Checked = true;
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\Game_database.sdf");
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "select eng from data_table where eng like '______' or eng like '_____' or eng like '____' or eng like '___' or eng like '__' or eng like '_'";
                res = cmd.ExecuteReader();
                word_dt.Load(res);
                res.Close();
            }

            if (optlevel_3.Checked == true)
            {
                optlevel_3.Checked = false;
                optlevel_4.Checked = true;
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\Game_database.sdf");
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "select eng from data_table where eng like '_______' or '______' or eng like '_____' or eng like '____' or eng like '___' or eng like '__' or eng like '_'";
                res = cmd.ExecuteReader();
                word_dt.Load(res);
                res.Close();
            }
            if (optlevel_4.Checked == true)
            {
                optlevel_4.Checked = false;
                optlevel_5.Checked = true;
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\Game_database.sdf");
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "select eng from data_table where eng like '________' or '_______' or '______' or eng like '_____' or eng like '____' or eng like '___' or eng like '__' or eng like '_'";
                res = cmd.ExecuteReader();
                word_dt.Load(res);
                res.Close();
            }
            if (optlevel_5.Checked == true)
            {
                optlevel_5.Checked = false;
                optlevel_6.Checked = true;
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\Game_database.sdf");
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "select eng from data_table where eng like '_________' or  '________' or '_______' or '______' or eng like '_____' or eng like '____' or eng like '___' or eng like '__' or eng like '_'";
                res = cmd.ExecuteReader();
                word_dt.Load(res);
                res.Close();
            }
            if (optlevel_6.Checked == true)
            {
                optlevel_6.Checked = false;
                optlevel_7.Checked = true;
                conn = new SqlCeConnection(@"Data Source=|DataDirectory|\Game_database.sdf");
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "select eng from data_table where eng like '__________' or  '_________' or  '________' or '_______' or '______' or eng like '_____' or eng like '____' or eng like '___' or eng like '__' or eng like '_'";
                res = cmd.ExecuteReader();
                word_dt.Load(res);
                res.Close();
            }


        abc: ;
        }
        private void txt_type_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            int kcode = Convert.ToInt16(e.KeyChar);
           // MessageBox.Show(Convert.ToString(kcode));
            if (kcode == 32)
            {
                foreach (Control ctr in panel7.Controls)
                {
                    TextBox tb;
                    tb = (TextBox)ctr;
                    if (tb.Top > 5)
                    {
                        if (tb.Text.CompareTo(txt_type_text.Text) == 0)
                        {
                            tb.Top = 0;
                            int po = tb.Text.Length;
                            po = po * 5;
                            int tpo = Convert.ToInt16(labtotal_paint.Text);
                            tpo = tpo + po;
                            if (tpo > 500)
                            {
                                change_leavel();
                                labtotal_paint.Text = "0";
                                goto abc;
                            }
                           
                            
                            labtotal_paint.Text = Convert.ToString(tpo);
                        abc: ;
                            txt_type_text.Text = "";
                            start_timer();
                            e.Handled = true ;
                        }
                    }
                
                }



               
            }
        }

        private void optlevel_1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_type_text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
