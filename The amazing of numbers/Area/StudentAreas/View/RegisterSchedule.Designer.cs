namespace The_amazing_of_numbers.Area.Student.View
{
    partial class RegisterSchedule
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
            this.label1 = new System.Windows.Forms.Label();
            this.EditInfoBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(394, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đăng ký môn đê";
            // 
            // EditInfoBtn
            // 
            this.EditInfoBtn.Animated = true;
            this.EditInfoBtn.AutoRoundedCorners = true;
            this.EditInfoBtn.BackColor = System.Drawing.Color.Transparent;
            this.EditInfoBtn.BorderRadius = 17;
            this.EditInfoBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.EditInfoBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EditInfoBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EditInfoBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EditInfoBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EditInfoBtn.Font = new System.Drawing.Font("Nunito", 11.25F, System.Drawing.FontStyle.Bold);
            this.EditInfoBtn.ForeColor = System.Drawing.Color.White;
            this.EditInfoBtn.Location = new System.Drawing.Point(49, 357);
            this.EditInfoBtn.Name = "EditInfoBtn";
            this.EditInfoBtn.Size = new System.Drawing.Size(93, 36);
            this.EditInfoBtn.TabIndex = 2;
            this.EditInfoBtn.Text = "Back";
            this.EditInfoBtn.UseTransparentBackground = true;
            this.EditInfoBtn.Click += new System.EventHandler(this.EditInfoBtn_Click);
            // 
            // RegisterSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1082, 741);
            this.Controls.Add(this.EditInfoBtn);
            this.Controls.Add(this.label1);
            this.Name = "RegisterSchedule";
            this.Text = "RegisterSchedule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button EditInfoBtn;
    }
}