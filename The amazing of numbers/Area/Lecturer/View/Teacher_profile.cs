using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_amazing_of_numbers.Area.Lecturer.Controllers;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Area.Lecturer.View
{
    public partial class Teacher_profile : Form
    {
        dbUniversityDataContext db = new dbUniversityDataContext();
        LecturerController lecturerController = new LecturerController();
        private User cur_user;
        public Teacher_profile(User user)
        {
            InitializeComponent();
            this.cur_user = user;
            Lecture lt = db.Lectures.Where(s => s.id == user.id).FirstOrDefault();
            ProfileLecture();
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
            Lecture_Profile.Controls.Add(childForm);
            Lecture_Profile.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {
            OpenChildForm(new Profile_Edit_Lec(cur_user));
        }


        private void EditBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Profile_Edit_Lec(cur_user));
        }
        private void ProfileLecture()
		{
            string lecID = cur_user.id;
            Lecture lt = lecturerController.infoDetails(lecID);
            UserName.Text = lt.name_;
            label11.Text = lt.name_;
            guna2TextBox3.Text = lt.email;
            guna2TextBox4.Text = lt.status_;
            guna2TextBox2.Text = lt.department_id;
            guna2TextBox7.Text = lt.id;
            label13.Text = lt.sex;
            guna2TextBox5.Text = lt.phone;
            guna2TextBox1.Text = Convert.ToString(lt.Teaching_Experience);
            guna2TextBox6.Text = lt.dob;
		}

		private void Lecture_Profile_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
