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
    public partial class parent : Form
    {
        public parent()
        {
            InitializeComponent();
        }

        private void bacToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
      
        
        private void classe1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void etudiantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prof pf = new Prof();
            pf.Show();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void francaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void arabeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void bacToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void etudiantsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           student el = new student();
            el.Show();
        }

        private void quitteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void archiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
        }

        private void stageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //stage st = new stage();
            //st.show();
        }

        private void parent_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            calcul cl = new calcul();
            cl.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
                    label1.Text=DateTime.Now.ToString("HH:mm:ss");



        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            maps mp = new maps();
            mp.Show();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();

        }

        private void activiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            elv el = new elv();
            el.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
            else if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
            }
            else if (pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
            }
            else if (pictureBox4.Visible == true)
            {
                pictureBox4.Visible = false;
                pictureBox1.Visible = true;
            }


        }

        private void faceBookToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void wathsappToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void instegramToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gams gm = new gams();
            gm.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            help hl = new help();
            hl.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inscriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            maps mp = new maps();
            mp.Show();
        }

        private void inscriptionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //student st = new student();
            //st.Show();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calcul cl = new calcul();
            cl.Show();
        }

        private void inscriptionToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            student st = new student();
            st.Show();
        }
    }
}
