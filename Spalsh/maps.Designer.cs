namespace Spalsh
{
    partial class maps
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(maps));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.searsh = new System.Windows.Forms.Button();
            this.Zip = new System.Windows.Forms.Label();
            this.Street = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.Label();
            this.Country = new System.Windows.Forms.Label();
            this.t4 = new System.Windows.Forms.TextBox();
            this.t3 = new System.Windows.Forms.TextBox();
            this.t2 = new System.Windows.Forms.TextBox();
            this.t1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Salmon;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.searsh);
            this.panel1.Controls.Add(this.Zip);
            this.panel1.Controls.Add(this.Street);
            this.panel1.Controls.Add(this.City);
            this.panel1.Controls.Add(this.Country);
            this.panel1.Controls.Add(this.t4);
            this.panel1.Controls.Add(this.t3);
            this.panel1.Controls.Add(this.t2);
            this.panel1.Controls.Add(this.t1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searsh
            // 
            this.searsh.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.searsh, "searsh");
            this.searsh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.searsh.Name = "searsh";
            this.searsh.UseVisualStyleBackColor = false;
            this.searsh.Click += new System.EventHandler(this.searsh_Click);
            // 
            // Zip
            // 
            resources.ApplyResources(this.Zip, "Zip");
            this.Zip.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Zip.Name = "Zip";
            // 
            // Street
            // 
            resources.ApplyResources(this.Street, "Street");
            this.Street.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Street.Name = "Street";
            // 
            // City
            // 
            resources.ApplyResources(this.City, "City");
            this.City.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.City.Name = "City";
            // 
            // Country
            // 
            resources.ApplyResources(this.Country, "Country");
            this.Country.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Country.Name = "Country";
            // 
            // t4
            // 
            resources.ApplyResources(this.t4, "t4");
            this.t4.Name = "t4";
            // 
            // t3
            // 
            resources.ApplyResources(this.t3, "t3");
            this.t3.Name = "t3";
            // 
            // t2
            // 
            resources.ApplyResources(this.t2, "t2");
            this.t2.Name = "t2";
            // 
            // t1
            // 
            resources.ApplyResources(this.t1, "t1");
            this.t1.Name = "t1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.webBrowser1);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // webBrowser1
            // 
            resources.ApplyResources(this.webBrowser1, "webBrowser1");
            this.webBrowser1.Name = "webBrowser1";
            // 
            // maps
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "maps";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button searsh;
        private System.Windows.Forms.Label Zip;
        private System.Windows.Forms.Label Street;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.Label Country;
        private System.Windows.Forms.TextBox t4;
        private System.Windows.Forms.TextBox t3;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button1;
    }
}