namespace The_amazing_of_numbers.Area.AcademicAffair.View
{
    partial class ViewStudentProfile
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
            this.components = new System.ComponentModel.Container();
            this.panelchild = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.ClassesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.CoursesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DepartBtn = new Guna.UI2.WinForms.Guna2Button();
            this.LecturesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.MyProfileBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBUniversityDataSet = new The_amazing_of_numbers.DBUniversity1DataSet();
            this.studentTableAdapter = new The_amazing_of_numbers.DBUniversity1DataSetTableAdapters.StudentTableAdapter();
            this.panelchild.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUniversityDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panelchild
            // 
            this.panelchild.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelchild.Controls.Add(this.label16);
            this.panelchild.Controls.Add(this.ClassesBtn);
            this.panelchild.Controls.Add(this.CoursesBtn);
            this.panelchild.Controls.Add(this.DepartBtn);
            this.panelchild.Controls.Add(this.LecturesBtn);
            this.panelchild.Controls.Add(this.MyProfileBtn);
            this.panelchild.Controls.Add(this.label6);
            this.panelchild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelchild.FillColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelchild.FillColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelchild.FillColor3 = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelchild.FillColor4 = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelchild.Location = new System.Drawing.Point(0, 0);
            this.panelchild.Name = "panelchild";
            this.panelchild.Size = new System.Drawing.Size(1084, 761);
            this.panelchild.TabIndex = 1;
            this.panelchild.Paint += new System.Windows.Forms.PaintEventHandler(this.panelchild_Paint);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label16.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label16.Location = new System.Drawing.Point(275, 64);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(559, 39);
            this.label16.TabIndex = 119;
            this.label16.Text = "_________________________________________________________________________________" +
    "___________\r\n\r\n\r\n";
            // 
            // ClassesBtn
            // 
            this.ClassesBtn.Animated = true;
            this.ClassesBtn.BackColor = System.Drawing.Color.Transparent;
            this.ClassesBtn.BorderRadius = 20;
            this.ClassesBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ClassesBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ClassesBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ClassesBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ClassesBtn.FillColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClassesBtn.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Bold);
            this.ClassesBtn.ForeColor = System.Drawing.Color.Black;
            this.ClassesBtn.IndicateFocus = true;
            this.ClassesBtn.Location = new System.Drawing.Point(840, 12);
            this.ClassesBtn.Name = "ClassesBtn";
            this.ClassesBtn.Size = new System.Drawing.Size(225, 39);
            this.ClassesBtn.TabIndex = 118;
            this.ClassesBtn.Text = "Classes infomations!";
            this.ClassesBtn.UseTransparentBackground = true;
            this.ClassesBtn.Click += new System.EventHandler(this.ClassesBtn_Click);
            // 
            // CoursesBtn
            // 
            this.CoursesBtn.Animated = true;
            this.CoursesBtn.BackColor = System.Drawing.Color.Transparent;
            this.CoursesBtn.BorderRadius = 20;
            this.CoursesBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CoursesBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CoursesBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CoursesBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CoursesBtn.FillColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CoursesBtn.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Bold);
            this.CoursesBtn.ForeColor = System.Drawing.Color.Black;
            this.CoursesBtn.IndicateFocus = true;
            this.CoursesBtn.Location = new System.Drawing.Point(609, 12);
            this.CoursesBtn.Name = "CoursesBtn";
            this.CoursesBtn.Size = new System.Drawing.Size(225, 39);
            this.CoursesBtn.TabIndex = 117;
            this.CoursesBtn.Text = "Courses infomations!";
            this.CoursesBtn.UseTransparentBackground = true;
            this.CoursesBtn.Click += new System.EventHandler(this.CoursesBtn_Click);
            // 
            // DepartBtn
            // 
            this.DepartBtn.Animated = true;
            this.DepartBtn.BackColor = System.Drawing.Color.Transparent;
            this.DepartBtn.BorderRadius = 20;
            this.DepartBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DepartBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DepartBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DepartBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DepartBtn.FillColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DepartBtn.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Bold);
            this.DepartBtn.ForeColor = System.Drawing.Color.Black;
            this.DepartBtn.IndicateFocus = true;
            this.DepartBtn.Location = new System.Drawing.Point(340, 12);
            this.DepartBtn.Name = "DepartBtn";
            this.DepartBtn.Size = new System.Drawing.Size(263, 39);
            this.DepartBtn.TabIndex = 116;
            this.DepartBtn.Text = "Departments infomations!";
            this.DepartBtn.UseTransparentBackground = true;
            this.DepartBtn.Click += new System.EventHandler(this.DepartBtn_Click);
            // 
            // LecturesBtn
            // 
            this.LecturesBtn.Animated = true;
            this.LecturesBtn.BackColor = System.Drawing.Color.Transparent;
            this.LecturesBtn.BorderRadius = 20;
            this.LecturesBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LecturesBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LecturesBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LecturesBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LecturesBtn.FillColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LecturesBtn.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Bold);
            this.LecturesBtn.ForeColor = System.Drawing.Color.Black;
            this.LecturesBtn.IndicateFocus = true;
            this.LecturesBtn.Location = new System.Drawing.Point(144, 12);
            this.LecturesBtn.Name = "LecturesBtn";
            this.LecturesBtn.Size = new System.Drawing.Size(181, 39);
            this.LecturesBtn.TabIndex = 115;
            this.LecturesBtn.Text = "Lectures Profile!";
            this.LecturesBtn.UseTransparentBackground = true;
            this.LecturesBtn.Click += new System.EventHandler(this.LecturesBtn_Click);
            // 
            // MyProfileBtn
            // 
            this.MyProfileBtn.Animated = true;
            this.MyProfileBtn.BackColor = System.Drawing.Color.Transparent;
            this.MyProfileBtn.BorderRadius = 20;
            this.MyProfileBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MyProfileBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MyProfileBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MyProfileBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MyProfileBtn.FillColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.MyProfileBtn.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Bold);
            this.MyProfileBtn.ForeColor = System.Drawing.Color.Black;
            this.MyProfileBtn.IndicateFocus = true;
            this.MyProfileBtn.Location = new System.Drawing.Point(12, 12);
            this.MyProfileBtn.Name = "MyProfileBtn";
            this.MyProfileBtn.Size = new System.Drawing.Size(126, 39);
            this.MyProfileBtn.TabIndex = 114;
            this.MyProfileBtn.Text = "My Profile!";
            this.MyProfileBtn.UseTransparentBackground = true;
            this.MyProfileBtn.Click += new System.EventHandler(this.MyProfileBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label6.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(499, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 37);
            this.label6.TabIndex = 113;
            this.label6.Text = "Student!";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.dBUniversityDataSet;
            // 
            // dBUniversityDataSet
            // 
            this.dBUniversityDataSet.DataSetName = "DBUniversityDataSet";
            this.dBUniversityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // ViewStudentProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 761);
            this.Controls.Add(this.panelchild);
            this.Name = "ViewStudentProfile";
            this.Text = "ViewStudentProfile";
            this.panelchild.ResumeLayout(false);
            this.panelchild.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUniversityDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelchild;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2Button ClassesBtn;
        private Guna.UI2.WinForms.Guna2Button CoursesBtn;
        private Guna.UI2.WinForms.Guna2Button DepartBtn;
        private Guna.UI2.WinForms.Guna2Button LecturesBtn;
        private Guna.UI2.WinForms.Guna2Button MyProfileBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private DBUniversity1DataSet dBUniversityDataSet;
        private DBUniversity1DataSetTableAdapters.StudentTableAdapter studentTableAdapter;
    }
}