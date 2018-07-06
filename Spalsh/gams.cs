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
    public partial class gams : Form
    {
        bool tr = true; //true= tr X; false= tr X;
        int tr_count = 0;
        public gams()
        {
            InitializeComponent();
        }

        private void gams_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Amal-imeZzaGouane,TIC TAC TOE");
        }

        private void exirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void B_Clik(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (tr)
            { b.Text = "X"; }
            else { b.Text = "O"; }
            tr = !tr;
            b.Enabled = false;
            tr_count++;
            chekWiner();

        }

        private void chekWiner()
        {// horizontal
            bool there_is_a_Winner = false;
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
            { there_is_a_Winner = true; }
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
            { there_is_a_Winner = true; }
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            { there_is_a_Winner = true; }

              // vertical

            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            { there_is_a_Winner = true; }
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            { there_is_a_Winner = true; }
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            { there_is_a_Winner = true; }



            //dialogue
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            { there_is_a_Winner = true; }
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
            { there_is_a_Winner = true; }


            if (there_is_a_Winner)
            {
                desBoutn();
                String win = "";
                if (tr)
                    win = "O";
                else
                    win = "X";
               label2.Text= win +" "+ "win YaY :D";

            }
            else
            {
                if (tr_count == 9)
                    label2.Text="Draw Bummer!";
            }
        }



        private void desBoutn()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch
            { }


        }

     
     
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tr = true;
            tr_count = 0;

            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";

                }
            }
            catch { }

        }




    }
}