using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Spalsh
{
    public partial class login : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=etudiant");

        //int i;
        private int x;


        public login()
        {
            InitializeComponent();
        }

    
      

      

        private void button1_Click_1(object sender, EventArgs e)
        {

            x = 0;

            con.Open();

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select *from login where user='" + t1.Text + "' and pass ='" + t2.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter mdp = new MySqlDataAdapter(cmd);
            mdp.Fill(dt);
            x = Convert.ToInt32(dt.Rows.Count.ToString());

            if (x == 0)
            {
                labelX1.Text = "Sorry Your User or Password Invalid";
            }
            else
            {
                this.Hide();
                student dir = new student();
                dir.Show();




            }



            con.Close();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void Authentification_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //if(checkBox1.Checked)
            //    t2.UseSystemPasswordChar=false;
            //else
            //     t2.UseSystemPasswordChar=true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

           // MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=etudiant");
           // con.Open();
           //SqlCommand cmd=new SqlCommand( "select *from login where user='" + t1.Text + "' and pass ='" + t2.Text + "'");
           //SqlDataReader dtr;
           //dtr = cmd.ExecuteReader();
           //int count = 0;
           // while(dtr.Read())
           // { count = +1; }
         
           // if(count==1)
           // { MessageBox.Show("ok");
           // elv el =new elv();
           //     el.Show();       }
           // else if(count >0)
           // { MessageBox.Show("duplcate user and pass"); }
           // else 

           // {MessageBox.Show("incorrect");}
           //t1.Clear();
           //    t2.Clear();
           


        }
        }

        }
  


