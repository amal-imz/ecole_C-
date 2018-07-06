using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spalsh
{
    public partial class main : Form
    {
        public main()
        {

            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }

        public void SplashStart()
        {
            Application.Run(new splash());
        }
        private void main_Load(object sender, EventArgs e)
        {

        }

     

        private void buttonX1_Click(object sender, EventArgs e)
        {
            //login lg = new login();
            //lg.Show();

        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //label1.Text=DateTime.Now.ToString("HH:mm:ss");
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            calcul cal = new calcul();
            cal.Show();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            //Authentification at = new Authentification();
            //at.Show();

            parent pant = new parent();
            pant.Show();
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
          this.Close();
        }

       




    }

    }

