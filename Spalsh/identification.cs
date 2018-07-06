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
    public partial class identification : Form
    {
        //MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=etudiant");
        //MySqlDataAdapter adptr;
        //DataTable table = new DataTable();
        public identification()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            //adptr = new MySqlDataAdapter("SELECT `user`,`pass` From `login` WHERE `user`='" + t1.Text + "' and  `pass` ='" + t2.Text + "'", con);
            //adptr.Fill(table);

            //if(table.Rows.Count<0)
            //{
            //    panel1.Height = 0;
            //    label.ForeColor = Color.Red;
            //    label.Text = "user and pass are invalid";
            //    timer1.Start();
            //}


            //if (table.Rows.Count <= 0)
            //{
            //    panel1.Height = 0;
            //    panel1.ForeColor = Color.Green;
            //    label.Text = "login successfuly";
            //    timer1.Start();
            //}
          
        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        ////    if (panel1.Height != 100)
        ////    {
        ////        panel1.Height = panel1.Height + 5;
        ////        if (panel1.Height == 100)
        ////        { timer1.Stop(); }

        ////    }
        //}

    //    private void timer2_Tick(object sender, EventArgs e)
    //   {
    //    //     if (panel1.Height != 0)
    //    //    {
    //    //        panel1.Height = panel1.Height - 5;
    //    //        if (panel1.Height == 0)
    //    //        { timer2.Stop(); }
    //    //}
    //}

        private void identification_Load(object sender, EventArgs e)
        {

        }
}
}

