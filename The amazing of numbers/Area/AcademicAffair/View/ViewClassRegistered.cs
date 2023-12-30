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

namespace The_amazing_of_numbers.Area.AcademicAffair.View
{
    public partial class ViewClassRegistered : Form
    {
        private User cur_user;
        public ViewClassRegistered(User user)
        {
            InitializeComponent();
            cur_user = user;
        }
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
            PanelChild.Controls.Add(childForm);
            PanelChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewInfomations(cur_user));

        }

        private void StudentProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewStudentProfile(cur_user));

        }

        private void LectureProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewLectureProfile(cur_user));

        }

        private void DepartBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewDepartment(cur_user));

        }

        private void CourseBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewCourse(cur_user));

        }
    }
}
