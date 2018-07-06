using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spalsh
{
    public partial class ident : Form
    {
        //MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=etudiant");
        //MySqlDataAdapter adptr;
        //DataTable table = new DataTable();
        public ident()
        {
            InitializeComponent();
        }

       
      

        private void ident_Load(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
        //    adptr = new MySqlDataAdapter("SELECT `user`,`pass` From `login` WHERE `user`='" + t1.Text + "' and  `pass` ='" + t2.Text + "'", con);
        //    adptr.Fill(table);

        //    if (table.Rows.Count <= 0)
        //    {
        //        //panel1.Height = 0;
        //        //label_m.ForeColor = Color.Red;
        //        //label_m.Text = "user and pass are invalid";
        //        //timer1.Start();
        //        panel1.Height = 0;
        //        label_m.ForeColor = Color.Green;
        //        label_m.Text = "login successfuly";
        //        timer1.Start();

        //    }
        //    else
        //    {

        //        MessageBox.Show("invalid");
        //    }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if(panel1.Height !=100 )
            //{
            //    panel1.Height = panel1.Height + 5;
            //     if(panel1.Height == 100)
            //     { timer1.Stop(); }
          
            //}
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (panel1.Height != 0)
            {
                panel1.Height = panel1.Height - 5;
                if (panel1.Height == 0)
                { timer2.Stop(); }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //timer2.Start();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBox1.Checked)
            //    {
            //        t2.UseSystemPasswordChar=true;
            //    }
            //    else
            //    {
            //        t2.UseSystemPasswordChar=false;
            //    }

        }

        private void log_Click(object sender, EventArgs e)
        {
            //adptr = new MySqlDataAdapter("SELECT `user`,`pass` From `login` WHERE `user`='" + t1.Text + "' and  `pass` ='" + t2.Text + "'", con);
            //adptr.Fill(table);
            // if (table.Rows.Count <= 0)
            //{
            //        panel1.Height = 0;
            //        label_m.ForeColor = Color.Red;
            //        label_m.Text = "user and pass are invalid";
            //        timer1.Start();
            // }

            // else
            // {
            //     panel1.Height = 0;
            //     label_m.ForeColor = Color.Green;
            //     label_m.Text = "login successfuly";
            //     timer1.Start();
            // }




        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            
        }
    }
}
