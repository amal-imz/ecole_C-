using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing.Imaging;
namespace Spalsh
{
    public partial class student : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=etudiant");
        
        private MySqlCommand cmd;
     
   
        public student()
        {
            InitializeComponent();
        }

        private void student_Load(object sender, EventArgs e)
        {
            string selectQuery = "Select *From student";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, con);
            adapter.Fill(table);

            
        }


     
   
        private void Ajouter_Click(object sender, EventArgs e)
        {

            string insertQuery = "INSERT INTO student(id,nom,pre,datN,city,sex,niv,mail,phon)VALUES('" + c1.Text + "','" + t2.Text + "','" + t3.Text + "','" + t4.Text + "','" + t5.Text + "','" + c2.Text + "','" + c3.Text + "','" + t6.Text + "','" + t7.Text + "')";
            executeQuery(insertQuery);
           
        }

        public void executeQuery(string Query)
        {
            try
            {
                openConnection();
               cmd = new MySqlCommand(Query, con);
                if (cmd.ExecuteNonQuery() == 1)
                { Inscription.Text = "Exectuted Query Successful"; }
                else {  Inscription.Text ="Not Query Exectuted"; }


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

        private void search_Click(object sender, EventArgs e)
        {

            MySqlDataReader myred;
            String select = "SELECT * FROM student WHERE id= " + c1.Text;


            cmd = new MySqlCommand(select, con);
            openConnection();
            myred = cmd.ExecuteReader();
            if (myred.Read())
            {

                 t2.Text = myred.GetString("nom");
                 t3.Text = myred.GetString("pre");
                 t4.Text = myred.GetString("datN");
                 t5.Text = myred.GetString("city");
                 c2.Text = myred.GetString("sex"); 
                 c3.Text = myred.GetString("niv");
                 t6.Text = myred.GetString("mail");
                 t7.Text = myred.GetString("phon");
      
            }
            else
            {
                Inscription.Text="User not found";
                ClosedConnection();
            }
        }

        private void Delet_Click(object sender, EventArgs e)
        {

            string deletQuery = "DELETE FROM student WHERE id=" + int.Parse(c1.Text);
            executeQuery(deletQuery);
            
        }

        private void update_Click(object sender, EventArgs e)
        {
            //string con = "datasource=127.0.0.1;port=3306;username=root;password=;database=etudiant";
            string updatetQuery = ("UPDATE student SET  nom='" + t2.Text + "', pre='" + t3.Text + "',city=" + t4.Text + "',datN=" + t5.Text + "',sex=" + c2.Text + "',niv=" + c3.Text + "',mail=" + t6.Text + "',phon=" + t7.Text + "WHERE id=" + int.Parse(c1.Text));
            //MySqlConnection conbd = new MySqlConnection(con);
            //MySqlCommand cmd = new MySqlCommand(Query, conbd);
            //MySqlDataReader myred;
            executeQuery(updatetQuery);
            //try
            //{
            //    conbd.Open();
            //    myred = cmd.ExecuteReader();
            //    MessageBox.Show("edit");
            //    while (myred.Read())

            //    { }


            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);

            //}
            //conbd.Close();
            ////Grid1();
        }

        

        private void buttonX1_Click(object sender, EventArgs e)
        {
              clear();
        }

        public void clear()
        {
            c3.Text= " ";
            t2.Text = " ";
           t3.Text = " ";
            t4.Text = " ";
           t5.Text = " ";
           c1.Text = " ";
           c2.Text = " ";
           t6.Text = " ";
           t7.Text = " ";
          

        }
 

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
