using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_amazing_of_numbers.Area.AcademicAffair.Controllers;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Area.AcademicAffair.View
{
    public partial class ViewInfomations : Form
    {
        dbUniversityDataContext db = new dbUniversityDataContext();
        AcademicAffairController academicAffairController = new AcademicAffairController();
        private User cur_user;
        public ViewInfomations(User user)
        {
            InitializeComponent();
            this.cur_user = user;
            Academic_Affair aff = db.Academic_Affairs.Where(s => s.id == user.id).FirstOrDefault();
            ProfileAcademicAffair();
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
            panelchild.Controls.Add(childForm);
            panelchild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void ViewStudentinfo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewStudentProfile());
        }

        private void ViewLectureInfomations_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewLectureProfile());

        }

        private void ViewCourseInfomations_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewCourse());

        }

        private void ViewDepartmentsInfomations_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewDepartment());

        }

        private void ViewClassInfomations_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewClassRegistered());

        }
        private void ViewInfomations_Load(object sender, EventArgs e)
        {

        }
        private void ProfileAcademicAffair()
        {
            string adminID = cur_user.id;
            Academic_Affair aff= academicAffairController.infoDetail(adminID);
            if (aff != null)
            {
                label11.Text = aff.name_;
                guna2TextBox7.Text = aff.id;
                label13.Text = aff.sex;
                guna2TextBox5.Text = aff.phone_num;
                guna2TextBox2.Text = aff.department_id;
                guna2TextBox6.Text = aff.dob;
                guna2TextBox3.Text = aff.username;
            }
        }
    }
}
