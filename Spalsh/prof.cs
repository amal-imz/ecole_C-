using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spalsh
{
    public partial class Prof : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=etudiant");
        //MySqlCommand cmd;
        string sex;
        string clas;
        //private string Query;
       

        public Prof()
        {
            InitializeComponent();
        }

      

        private void Prof_Load(object sender, EventArgs e)
        {
            Grid();

        }


        public void Grid()
        {//affiche grid
           MySqlCommand cmd = new MySqlCommand ("Select * From prof",con);
            DataTable table = new DataTable();
            MySqlDataAdapter adpter = new MySqlDataAdapter(cmd);
            adpter.Fill(table);
            Grprf.DataSource = table;
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


    
        private void Ajouter_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            picture1.Image.Save(ms, picture1.Image.RawFormat);
            byte[] img = ms.ToArray();
            

            //DataGridViewImageColumn DGi = new DataGridViewImageColumn();
            //DGi.HeaderText = "Image";
            //DGi.ImageLayout = DataGridViewImageCellLayout.Stretch;
            //Grprf.Columns.Add(DGi);
            //DataGridViewTextBoxColumn gdb = new DataGridViewTextBoxColumn();
            //gdb.HeaderText = "ID";
            //Grprf.Columns.Add(gdb);
            //Grprf.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Grprf.RowTemplate.Height = 20;
            //Grprf.AllowUserToAddRows = false;

           
            //string insertQuery = "INSERT INTO prof(id,nom,pre,tel,mail,sex,sub,clas,img)VALUES('" + t1.Text + "','" + t2.Text + "','" + t3.Text + "','" + t4.Text + "','" + t5.Text + "','" + sex + "','" + c1.Text + "','" + clas + "','" +picture1+ "')";

           MySqlCommand cmd=new MySqlCommand ("INSERT INTO prof(id,nom,pre,tel,mail,sex,sub,clas,img)VALUES(@ id  , @ tnom  , @ pre , @ tel ,@ mail , @sex , + @sub , @ clas,@ img )");
           cmd.Parameters.Add("id",MySqlDbType.VarChar).Value=t1.Text;
           cmd.Parameters.Add("nom", MySqlDbType.VarChar).Value = t2.Text;
           cmd.Parameters.Add("tel", MySqlDbType.VarChar).Value = t3.Text;
           cmd.Parameters.Add("mail", MySqlDbType.VarChar).Value = t4.Text;
           cmd.Parameters.Add("sex", MySqlDbType.VarChar).Value = sex;
           cmd.Parameters.Add("sub", MySqlDbType.VarChar).Value = c1.Text;
           cmd.Parameters.Add("clas", MySqlDbType.VarChar).Value = clas;
           cmd.Parameters.Add("img", MySqlDbType.Blob).Value = picture1;
           executeQuery(cmd, "DATA INSERTED");
            Grid();
            
        }

        private void executeQuery(MySqlCommand cmd, string p)
        {
            //try
            //{
            //    openConnection();
            //    cmd = new MySqlCommand(Query, con);
            //    if (cmd.ExecuteNonQuery() == 1)
            //    { MessageBox.Show("executed Query"); }
            //    else { MessageBox.Show("executed not Query"); }


            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);

            //}

            //finally
            //{
            //    ClosedConnection();
            //}

        }

        

        private void parcourir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Chose Image(*.jpg; *.png; *.gif)|*.jpg; -.png; *.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            { picture1.Image = Image.FromFile(ofd.FileName); }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            sex = "F";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            sex = "M";
        }

        private void checkBoxX1_CheckedChanged(object sender, EventArgs e)
        {
            clas = "TC";

        }

        private void checkBoxX2_CheckedChanged(object sender, EventArgs e)
        {
            clas = "1Bac";
        }

        private void checkBoxX3_CheckedChanged(object sender, EventArgs e)
        {
            clas = "2Bac";
        }

        private void c1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(c1.Text);

        }

        private void c1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Grprf_MouseClick(object sender, MouseEventArgs e)
        {
            t1.Text = Grprf.CurrentRow.Cells[0].Value.ToString();
            t2.Text = Grprf.CurrentRow.Cells[1].Value.ToString();
            t3.Text = Grprf.CurrentRow.Cells[2].Value.ToString();
            t4.Text = Grprf.CurrentRow.Cells[3].Value.ToString();
            t5.Text = Grprf.CurrentRow.Cells[4].Value.ToString();
            sex=  Grprf.CurrentRow.Cells[5].Value.ToString();
             c1.Text=  Grprf.CurrentRow.Cells[6].Value.ToString();
             clas=  Grprf.CurrentRow.Cells[7].Value.ToString();
             //byte[] img = (byte[])Grprf.CurrentRow.Cells[8];
        }

      









    }
}
