namespace Spalsh
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.t1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.Authentification = new DevComponents.DotNetBar.LabelX();
            this.button1 = new System.Windows.Forms.Button();
            this.t2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // t1
            // 
            // 
            // 
            // 
            this.t1.Border.Class = "TextBoxBorder";
            this.t1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.t1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t1.Location = new System.Drawing.Point(111, 71);
            this.t1.Margin = new System.Windows.Forms.Padding(4);
            this.t1.Multiline = true;
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(380, 65);
            this.t1.TabIndex = 0;
            this.t1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t1.WatermarkColor = System.Drawing.SystemColors.ControlText;
            this.t1.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(111, 251);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(340, 26);
            this.labelX1.TabIndex = 3;
            // 
            // Authentification
            // 
            this.Authentification.BackColor = System.Drawing.Color.Transparent;
            this.Authentification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            // 
            // 
            // 
            this.Authentification.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Authentification.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Authentification.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Authentification.Location = new System.Drawing.Point(111, 0);
            this.Authentification.Margin = new System.Windows.Forms.Padding(4);
            this.Authentification.Name = "Authentification";
            this.Authentification.Size = new System.Drawing.Size(321, 50);
            this.Authentification.TabIndex = 4;
            this.Authentification.Text = "\r\nenter the mail and password\r\n";
            this.Authentification.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Authentification.Click += new System.EventHandler(this.Authentification_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(186, 295);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 88);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // t2
            // 
            // 
            // 
            // 
            this.t2.Border.Class = "TextBoxBorder";
            this.t2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.t2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t2.Location = new System.Drawing.Point(111, 172);
            this.t2.Margin = new System.Windows.Forms.Padding(4);
            this.t2.Multiline = true;
            this.t2.Name = "t2";
            this.t2.PasswordChar = '*';
            this.t2.Size = new System.Drawing.Size(380, 62);
            this.t2.TabIndex = 5;
            this.t2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t2.WatermarkColor = System.Drawing.SystemColors.ControlText;
            this.t2.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(547, 415);
            this.Controls.Add(this.Authentification);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.t1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX t1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX Authentification;
        private System.Windows.Forms.Button button1;
        private DevComponents.DotNetBar.Controls.TextBoxX t2;
    }
}