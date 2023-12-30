using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_amazing_of_numbers.Area.Student.View
{
    public partial class StudentForm_CourseButton : Form
    {
        public StudentForm_CourseButton()
        {
            InitializeComponent();
        }
        //Panel child content 
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            CoursePanel.Controls.Add(childForm);
            CoursePanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RegisterSchedule());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AlreadyhaveClass());  
        }
    }
}
