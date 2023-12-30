namespace The_amazing_of_numbers.Area.AcademicAffair.View
{
    partial class ViewLectureProfile
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
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.ClassesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.CoursesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DepartBtn = new Guna.UI2.WinForms.Guna2Button();
            this.StudentsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.MyProfileBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lectureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBUniversityDataSet = new The_amazing_of_numbers.DBUniversity1DataSet();
            this.lectureTableAdapter = new The_amazing_of_numbers.DBUniversity1DataSetTableAdapters.LectureTableAdapter();
            this.panelchild = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbUniversityDataSet1 = new The_amazing_of_numbers.DBUniversity1DataSet();
            this.studentTableAdapter = new The_amazing_of_numbers.DBUniversity1DataSetTableAdapters.StudentTableAdapter();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUniversityDataSet)).BeginInit();
            this.panelchild.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbUniversityDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.guna2CustomGradientPanel1.Controls.Add(this.label16);
            this.guna2CustomGradientPanel1.Controls.Add(this.ClassesBtn);
            this.guna2CustomGradientPanel1.Controls.Add(this.CoursesBtn);
            this.guna2CustomGradientPanel1.Controls.Add(this.DepartBtn);
            this.guna2CustomGradientPanel1.Controls.Add(this.StudentsBtn);
            this.guna2CustomGradientPanel1.Controls.Add(this.MyProfileBtn);
            this.guna2CustomGradientPanel1.Controls.Add(this.label6);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.SystemColors.GradientInactiveCaption;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.SystemColors.GradientInactiveCaption;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1068, 722);
            this.guna2CustomGradientPanel1.TabIndex = 2;
            this.guna2CustomGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2CustomGradientPanel1_Paint);
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
            // StudentsBtn
            // 
            this.StudentsBtn.Animated = true;
            this.StudentsBtn.BackColor = System.Drawing.Color.Transparent;
            this.StudentsBtn.BorderRadius = 20;
            this.StudentsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.StudentsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.StudentsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.StudentsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.StudentsBtn.FillColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.StudentsBtn.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Bold);
            this.StudentsBtn.ForeColor = System.Drawing.Color.Black;
            this.StudentsBtn.IndicateFocus = true;
            this.StudentsBtn.Location = new System.Drawing.Point(144, 12);
            this.StudentsBtn.Name = "StudentsBtn";
            this.StudentsBtn.Size = new System.Drawing.Size(181, 39);
            this.StudentsBtn.TabIndex = 115;
            this.StudentsBtn.Text = "Students Profile!";
            this.StudentsBtn.UseTransparentBackground = true;
            this.StudentsBtn.Click += new System.EventHandler(this.StudentsBtn_Click);
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
            this.label6.Size = new System.Drawing.Size(132, 37);
            this.label6.TabIndex = 113;
            this.label6.Text = "Lectures!";
            // 
            // lectureBindingSource
            // 
            this.lectureBindingSource.DataMember = "Lecture";
            this.lectureBindingSource.DataSource = this.dBUniversityDataSet;
            // 
            // dBUniversityDataSet
            // 
            this.dBUniversityDataSet.DataSetName = "DBUniversityDataSet";
            this.dBUniversityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lectureTableAdapter
            // 
            this.lectureTableAdapter.ClearBeforeFill = true;
            // 
            // panelchild
            // 
            this.panelchild.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelchild.Controls.Add(this.guna2CustomGradientPanel1);
            this.panelchild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelchild.FillColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelchild.FillColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelchild.FillColor3 = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelchild.FillColor4 = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelchild.Location = new System.Drawing.Point(0, 0);
            this.panelchild.Name = "panelchild";
            this.panelchild.Size = new System.Drawing.Size(1068, 722);
            this.panelchild.TabIndex = 1;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.dbUniversityDataSet1;
            // 
            // dbUniversityDataSet1
            // 
            this.dbUniversityDataSet1.DataSetName = "DBUniversityDataSet";
            this.dbUniversityDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // ViewLectureProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 722);
            this.Controls.Add(this.panelchild);
            this.Name = "ViewLectureProfile";
            this.Text = "ViewLectureProfile";
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUniversityDataSet)).EndInit();
            this.panelchild.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbUniversityDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2Button ClassesBtn;
        private Guna.UI2.WinForms.Guna2Button CoursesBtn;
        private Guna.UI2.WinForms.Guna2Button DepartBtn;
        private Guna.UI2.WinForms.Guna2Button StudentsBtn;
        private Guna.UI2.WinForms.Guna2Button MyProfileBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource lectureBindingSource;
        private DBUniversity1DataSet dBUniversityDataSet;
        private DBUniversity1DataSetTableAdapters.LectureTableAdapter lectureTableAdapter;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelchild;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private DBUniversity1DataSet dbUniversityDataSet1;
        private DBUniversity1DataSetTableAdapters.StudentTableAdapter studentTableAdapter;
    }
}