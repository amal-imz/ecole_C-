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
    public partial class maps : Form
    {
        public maps()
        {
            InitializeComponent();
        }

        private void searsh_Click(object sender, EventArgs e)
        {
            string Country = t1.Text;
            string City = t2.Text;
            string Street = t3.Text;
            string Zip = t4.Text;   

            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("http://maps.google.com/maps?q=");
                if (Country != string.Empty)
                { sb.Append(Country + "," + "+"); }

                if (City != string.Empty)
                { sb.Append(City + "," + "+"); }

                if (Street != string.Empty)
                { sb.Append(Street + "," + "+"); }

                if (Zip != string.Empty)
                { sb.Append(Zip + "," + "+"); }
                webBrowser1.Navigate(sb.ToString());

            }

            catch(Exception ex)
            { MessageBox.Show(ex.Message.ToString(),"ERROR"); }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
