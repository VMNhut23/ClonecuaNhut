using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Area.Student.View
{
    public partial class StudentAchievements : Form
    {
        private User user;
        public StudentAchievements()
        {
            InitializeComponent();
        }
        /*Setting multi panel child content*/
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
            StudentAchiev.Controls.Add(childForm);
            StudentAchiev.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void AchievementButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StudentForm_Progess(user));
        }
    }
}
