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
    public partial class calcul : Form
    {

       Double res = 0;
        String Oper = "";
        bool ent_val = false;



        public calcul()
        {
            InitializeComponent();
        }

        private void calcul_Load(object sender, EventArgs e)
        {
            this.Width = 274;
            t1.Width = 248;

        }

        private void standarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 274;
            t1.Width = 248;


        }

        private void sientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 532;
            t1.Width = 508;
        }

       
        private void boutton_Clik(object sender, EventArgs e)
        {
            if ((t1.Text == "0") || (ent_val))
           
                t1.Text = "";
                ent_val = false;

                Button num = (Button)sender;


                if (num.Text == ".")
                {
                    if (!t1.Text.Contains("."))
                    { t1.Text = t1.Text + num.Text; }
                }
                else
                t1.Text = t1.Text + num.Text; 
           


        }

        private void bt18_Click(object sender, EventArgs e)
        {
            t1.Text = "0";
            lbShow.Text = "";
        }

        private void bt19_Click(object sender, EventArgs e)
        {
            t1.Text = "0";
            lbShow.Text = "";
        }

        private void bt17_Click(object sender, EventArgs e)
        {
            if(t1.Text.Length>0)
            { t1.Text=t1.Text.Remove(t1.Text.Length -1,1);}
            if (t1.Text=="")
            {t1.Text="0";}
        }

        private void arithmitique(object sender, EventArgs e)
        {

            Button num = (Button)sender;
            Oper = num.Text;
            res = Double.Parse(t1.Text);
            t1.Text = "0";
            lbShow.Text=System.Convert.ToString(res)+ " "+ Oper;

        }

        private void bt3_Click(object sender, EventArgs e)
        {
            lbShow.Text = "";
            switch(Oper)
            {
                case "+":
                    t1.Text=(res + Double.Parse(t1.Text)).ToString();
                    break;
                case "-":
                    t1.Text=(res - Double.Parse(t1.Text)).ToString();
                    break;
                case "*":
                    t1.Text=(res *Double.Parse(t1.Text)).ToString();
                    break;

                case"/":
                            t1.Text=(res/Double.Parse(t1.Text)).ToString();
                            break;

                case "mod":
                            t1.Text = (res % Double.Parse(t1.Text)).ToString();
                            break;
                case "exp":
                            double a = Double.Parse(t1.Text);
                    double b;
                    b=(res);
                    t1.Text=Math.Exp(a*Math.Log(b*4)).ToString();
                break;


            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            t1.Text = "3.141692653589976323";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double lg = Double.Parse(t1.Text);
            lg = Math.Log10(lg);
            t1.Text = System.Convert.ToString(lg);
            lbShow.Text=System.Convert.ToString("Log" + "(" + (t1.Text) +")");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double sq = Double.Parse(t1.Text);
            sq = Math.Sqrt(sq);
            t1.Text = System.Convert.ToString(sq);
            lbShow.Text = System.Convert.ToString("Sqrt" + "(" + (t1.Text) + ")");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double snh = Double.Parse(t1.Text);
            snh = Math.Sinh(snh);
            t1.Text = System.Convert.ToString(snh);
            lbShow.Text = System.Convert.ToString("Sinh" + "(" + (t1.Text) + ")");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double sn = Double.Parse(t1.Text);
            sn = Math.Sin(sn);
            t1.Text = System.Convert.ToString(sn);
            lbShow.Text = System.Convert.ToString("Sin" + "(" + (t1.Text) + ")");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double csh = Double.Parse(t1.Text);
            csh = Math.Cosh(csh);
            t1.Text = System.Convert.ToString(csh);
            lbShow.Text = System.Convert.ToString("Cosh" + "(" + (t1.Text) + ")");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            double cs = Double.Parse(t1.Text);
            cs= Math.Cos(cs);
            t1.Text = System.Convert.ToString(cs);
            lbShow.Text = System.Convert.ToString("Cos" + "(" + (t1.Text) + ")");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double tgh = Double.Parse(t1.Text);
            tgh = Math.Tanh(tgh);
            t1.Text = System.Convert.ToString(tgh);
            lbShow.Text = System.Convert.ToString("Tanh" + "(" + (t1.Text) + ")");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double tg= Double.Parse(t1.Text);
            tg= Math.Tan(tg);
            t1.Text = System.Convert.ToString(tg);
            lbShow.Text = System.Convert.ToString("Tan" + "(" + (t1.Text) + ")");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int a = int.Parse(t1.Text);
            t1.Text = System.Convert.ToString(a, 2);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int a = int.Parse(t1.Text);
            t1.Text = System.Convert.ToString(a);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a = int.Parse(t1.Text);
            t1.Text = System.Convert.ToString(a, 16);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(t1.Text);
            t1.Text = System.Convert.ToString(a,8 );
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Double a;
            a= Convert.ToDouble(t1.Text)*Convert.ToDouble(t1.Text);
            t1.Text=System.Convert.ToString(a);
        }

        private void button13_Click(object sender, EventArgs e)
        {
              Double a;
            a= Convert.ToDouble(t1.Text)*Convert.ToDouble(t1.Text)*Convert.ToDouble(t1.Text);
            t1.Text=System.Convert.ToString(a);
        }

        private void button9_Click(object sender, EventArgs e)
        {
                        Double a;
            a= Convert.ToDouble(1.0/ Convert.ToDouble(t1.Text));
            t1.Text=System.Convert.ToString(a);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            double lg = Double.Parse(t1.Text);
            lg = Math.Log(lg);
            t1.Text = System.Convert.ToString(lg);
            lbShow.Text=System.Convert.ToString("Ln" + "(" + (t1.Text) +")");
        }

        private void button1_Click(object sender, EventArgs e)
        {
               Double a;
            a= Convert.ToDouble(t1.Text)/Convert.ToDouble(100);
            t1.Text=System.Convert.ToString(a);
        }

        private void quitteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
