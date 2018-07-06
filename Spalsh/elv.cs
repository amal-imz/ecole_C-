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

namespace Spalsh
{
    public partial class elv : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=etudiant");
        MySqlCommand cmd;
        
        public elv()
        {
            InitializeComponent();
        }

        private void elv_Load(object sender, EventArgs e)
        {
            string selectQuery = "Select *From eleve";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, con);
            adapter.Fill(table);



            G_stu.DataSource = table;

            Grid();
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


        public void executeQuery(string Query)
        {
            try
            {
                openConnection();
                cmd = new MySqlCommand(Query, con);
                if (cmd.ExecuteNonQuery() == 1)
                { MessageBox.Show("executed Query"); }
                else { MessageBox.Show("executed not Query"); }


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

        private void buttonX8_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            picture1.Image.Save(ms, picture1.Image.RawFormat);
            byte[] img = ms.ToArray();


            DataGridViewImageColumn DGi = new DataGridViewImageColumn();
            DGi.HeaderText = "Image";
            DGi.ImageLayout = DataGridViewImageCellLayout.Stretch;
            G_stu.Columns.Add(DGi);
            DataGridViewTextBoxColumn gdb = new DataGridViewTextBoxColumn();
            gdb.HeaderText = "ID";
            G_stu.Columns.Add(gdb);
            G_stu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            G_stu.RowTemplate.Height = 20;
            G_stu.AllowUserToAddRows = false;


            //string insertQuery = "INSERT INTO prof(id,nom,pre,tel,mail,sex,sub,clas,img)VALUES('" + t1.Text + "','" + t2.Text + "','" + t3.Text + "','" + t4.Text + "','" + t5.Text + "','" + sex + "','" + c1.Text + "','" + clas + "','" +picture1+ "')";

            MySqlCommand cmd = new MySqlCommand("INSERT INTO eleve(id,nom,prenom,datNais,mail,sex,clas,img)VALUES(@ id  , @ nom  , @ prenom , @ datNais ,@ mail , @sex ,@sub , @ clas,@ img )");
            cmd.Parameters.Add("id", MySqlDbType.VarChar).Value = c3.Text;
            cmd.Parameters.Add("nom", MySqlDbType.VarChar).Value = t2.Text;
            cmd.Parameters.Add("prenom", MySqlDbType.VarChar).Value = t3.Text;
            cmd.Parameters.Add("datNais", MySqlDbType.VarChar).Value = t4.Text;
            cmd.Parameters.Add("mail", MySqlDbType.VarChar).Value = t5.Text;
            cmd.Parameters.Add("sex", MySqlDbType.VarChar).Value = c1.Text;
            cmd.Parameters.Add("clas", MySqlDbType.VarChar).Value = c3.Text;
            cmd.Parameters.Add("img", MySqlDbType.Blob).Value = picture1;
            executeQuery(cmd, "DATA INSERTED");
            Grid();
        }
        public void Grid()
        {//affiche grid
            MySqlCommand cmd = new MySqlCommand("Select * From prof", con);
            DataTable table = new DataTable();
            MySqlDataAdapter adpter = new MySqlDataAdapter(cmd);
            adpter.Fill(table);
            G_stu.DataSource = table;
        }
        private void executeQuery(MySqlCommand cmd, string Query)
        {
            try
            {
                openConnection();
                cmd = new MySqlCommand(Query, con);
                if (cmd.ExecuteNonQuery() == 1)
                { MessageBox.Show("executed Query"); }
                else { MessageBox.Show("executed not Query"); }


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

        private void buttonX3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Chose Image(*.jpg; *.png; *.gif)|*.jpg; -.png; *.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            { picture1.Image = Image.FromFile(ofd.FileName); }

            //if(openFileDialog1.ShowDialog()==DialogResult.OK)
            //{ picture1.Load(openFileDialog1.FileName); }
        }

       
    }
}
