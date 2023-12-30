namespace The_amazing_of_numbers.Area.Lecturer.View
{
    partial class Teacher_course
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher_course));
            this.panelchild = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.advancedWebClient1 = new Leaf.xNet.AdvancedWebClient();
            this.RegisterTeachButton = new Guna.UI2.WinForms.Guna2Button();
            this.RegisterClassButton = new Guna.UI2.WinForms.Guna2Button();
            this.panelchild.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelchild
            // 
            this.panelchild.Controls.Add(this.RegisterClassButton);
            this.panelchild.Controls.Add(this.RegisterTeachButton);
            this.panelchild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelchild.FillColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelchild.FillColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelchild.FillColor3 = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelchild.FillColor4 = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelchild.Location = new System.Drawing.Point(0, 0);
            this.panelchild.Name = "panelchild";
            this.panelchild.Size = new System.Drawing.Size(1050, 983);
            this.panelchild.TabIndex = 0;
            this.panelchild.Paint += new System.Windows.Forms.PaintEventHandler(this.panelchild_Paint);
            // 
            // advancedWebClient1
            // 
      /*      this.advancedWebClient1.AllowReadStreamBuffering = false;
            this.advancedWebClient1.AllowWriteStreamBuffering = false;*/
            this.advancedWebClient1.BaseAddress = "";
            this.advancedWebClient1.CachePolicy = null;
            this.advancedWebClient1.Credentials = null;
            this.advancedWebClient1.DecompressionMethods = ((System.Net.DecompressionMethods)((System.Net.DecompressionMethods.GZip | System.Net.DecompressionMethods.Deflate)));
            this.advancedWebClient1.Encoding = ((System.Text.Encoding)(resources.GetObject("advancedWebClient1.Encoding")));
            this.advancedWebClient1.Headers = ((System.Net.WebHeaderCollection)(resources.GetObject("advancedWebClient1.Headers")));
            this.advancedWebClient1.QueryString = ((System.Collections.Specialized.NameValueCollection)(resources.GetObject("advancedWebClient1.QueryString")));
            this.advancedWebClient1.ReadWriteTimeout = 10000;
            this.advancedWebClient1.ServerCertificateValidation = false;
            this.advancedWebClient1.Timeout = 10000;
            this.advancedWebClient1.UseDefaultCredentials = false;
            // 
            // RegisterTeachButton
            // 
            this.RegisterTeachButton.AutoRoundedCorners = true;
            this.RegisterTeachButton.BorderRadius = 40;
            this.RegisterTeachButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RegisterTeachButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RegisterTeachButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RegisterTeachButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RegisterTeachButton.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Bold);
            this.RegisterTeachButton.ForeColor = System.Drawing.Color.White;
            this.RegisterTeachButton.Location = new System.Drawing.Point(237, 60);
            this.RegisterTeachButton.Name = "RegisterTeachButton";
            this.RegisterTeachButton.Size = new System.Drawing.Size(197, 83);
            this.RegisterTeachButton.TabIndex = 0;
            this.RegisterTeachButton.Text = "Register Teach";
            this.RegisterTeachButton.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // RegisterClassButton
            // 
            this.RegisterClassButton.AutoRoundedCorners = true;
            this.RegisterClassButton.BorderRadius = 40;
            this.RegisterClassButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RegisterClassButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RegisterClassButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RegisterClassButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RegisterClassButton.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Bold);
            this.RegisterClassButton.ForeColor = System.Drawing.Color.White;
            this.RegisterClassButton.Location = new System.Drawing.Point(505, 60);
            this.RegisterClassButton.Name = "RegisterClassButton";
            this.RegisterClassButton.Size = new System.Drawing.Size(197, 83);
            this.RegisterClassButton.TabIndex = 1;
            this.RegisterClassButton.Text = "Register Class";
            this.RegisterClassButton.Click += new System.EventHandler(this.RegisterClassButton_Click);
            // 
            // Teacher_course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 983);
            this.Controls.Add(this.panelchild);
            this.Name = "Teacher_course";
            this.Text = "Teacher_course";
            this.panelchild.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelchild;
        private Leaf.xNet.AdvancedWebClient advancedWebClient1;
        private Guna.UI2.WinForms.Guna2Button RegisterClassButton;
        private Guna.UI2.WinForms.Guna2Button RegisterTeachButton;
    }
}