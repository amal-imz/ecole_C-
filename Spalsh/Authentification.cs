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
    public partial class Authentification : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=etudiant");
        private MySqlCommand command;
        public Authentification()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       
        private void buttonX1_Click(object sender, EventArgs e)
        {
            
        }

        private void Authentification_Load(object sender, EventArgs e)
        {
          
            string selectQuery = "Select *From login";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, con);
            adapter.Fill(table); 

        }
      
        public void executeQuery(string Query)
        {
            try
            {
                openConnection();
                command = new MySqlCommand(Query, con);
                if (command.ExecuteNonQuery() == 1)
                { MessageBox.Show("WELCOME TO HIGH SCHOOL");


                //parent pant = new parent();
                //pant.Show();

                //login lo = new login();
                //lo.Show();

                }
                else { MessageBox.Show("SORRY YOUR MAIL INCORRECT"); }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            finally
            {
                ClosedConnection();
            }


        }


        public void openConnection()
        {
            if (con.State == ConnectionState.Closed)
            { con.Open(); }
        }
        public void ClosedConnection()
        {
            if (con.State == ConnectionState.Open)
            { con.Close(); }
        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO login(user,pass)VALUES('" + t1.Text + "','" + t2.Text + "')";
            executeQuery(insertQuery);
        }

        private void buttonX1_Click_1(object sender, EventArgs e)
        {
         
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        }

      
      

       
    }
     
  




}
