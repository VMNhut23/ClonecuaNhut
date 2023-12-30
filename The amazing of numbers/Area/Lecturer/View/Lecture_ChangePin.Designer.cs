namespace The_amazing_of_numbers.Area.Lecturer.View
{
    partial class Lecture_ChangePin
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
            this.modelEffect_Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // modelEffect_Timer
            // 
            this.modelEffect_Timer.Tick += new System.EventHandler(this.modelEffect_Timer_Tick);
            // 
            // Lecture_ChangePin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Lecture_ChangePin";
            this.Text = "Lecture_ChangePin";
            this.Load += new System.EventHandler(this.Lecture_ChangePin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer modelEffect_Timer;
    }
}