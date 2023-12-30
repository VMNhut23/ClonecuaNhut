using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_amazing_of_numbers.Area.AcademicAffair.View;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Area.AcademicAffair.Controllers
{
    internal class AcademicAffairController
    {
        dbUniversityDataContext db = new dbUniversityDataContext();
        private User cur_user;
        public class ProgressStudent
        {
            public The_amazing_of_numbers.Model.Student stu_info;
            public int learningscore; //quatrinh
            public int trainingscore; //renluyen
            public int numVio;
        }
        public void AcademicAffairHomeView(User user_model)
        {
            cur_user = user_model;
            new AcademicAffairMainForm(cur_user).Show();
        }
        public Academic_Affair infoDetail(string id)
		{
            Academic_Affair aff = db.Academic_Affairs.Where(s => s.id == id).FirstOrDefault();
            return aff;
		}
        public void UpdateCourse(string course_id, string course_name, string dpt_id, int credits, int cost)
        {
            Subject_ sub = db.Subject_s.FirstOrDefault(s => s.course_id == course_id);
            if (sub != null)
            {
                sub.course_id = course_id;
                sub.course_name = course_name;
                sub.department_id = dpt_id;
                sub.credits = credits;
                sub.cost = cost;
                db.SubmitChanges();
            }
        }
        public void DeleteCourse(string id)
        {
            Subject_ sub = db.Subject_s.FirstOrDefault(s => s.course_id == id);
            db.Subject_s.DeleteOnSubmit(sub);
            db.SubmitChanges();
        }
        public void UpdateLecture(string id, string email, string name, string sex, string dob, string phone, string dpt_id, string status, int teach_E, string academicRank, string assignedSubject)
        {
            Lecture lt = db.Lectures.FirstOrDefault(l => l.id == id);
            if (lt != null)
            {
                lt.id = id;
                lt.email = email;
                lt.name_ = name;
                lt.sex = sex;
                lt.dob = dob;
                lt.phone = phone;
                lt.department_id = dpt_id;
                lt.status_ = status;
                lt.Teaching_Experience = teach_E;
                lt.Academic_rank = academicRank;
                lt.assigned_subjects = assignedSubject;
                db.SubmitChanges();
            }
        }
        public void DeleteLecture(string id)
        {
            Lecture lt = db.Lectures.FirstOrDefault(l => l.id == id);
            db.Lectures.DeleteOnSubmit(lt);
            db.SubmitChanges();
        }
        public void UpdateStudent(string id, string name, string sex, string school_year, string dob, string phone, string dpt_id, string status)
        {
			The_amazing_of_numbers.Model.Student st = db.Students.FirstOrDefault(s => s.id == id);
            if (st != null)
            {
                st.id = id;
                st.name_ = name;
                st.sex = sex;
                st.school_year = school_year;
                st.dob = dob;
                st.phone_num = phone;
                st.department_id = dpt_id;
                st.status_ = status;
                db.SubmitChanges();
            }
        }
        public void DeleteStudent(string id)
        {
            The_amazing_of_numbers.Model.Student st = db.Students.FirstOrDefault(s => s.id == id);
            db.Students.DeleteOnSubmit(st);
            db.SubmitChanges();
        }
        public Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }
        public byte[] ImageToByteArray(PictureBox picture)
        {
            MemoryStream memoryStream = new MemoryStream();
            picture.Image.Save(memoryStream, picture.Image.RawFormat);
            return memoryStream.ToArray();
        }

        public List<The_amazing_of_numbers.Model.Student> allStudent(string student_year)
        {
            List<The_amazing_of_numbers.Model.Student> lst = new List<The_amazing_of_numbers.Model.Student>();
            if (student_year == "1")
            {
                lst = db.Students.Where(x => x.school_year == "2022-2026").ToList();
            }
            else if (student_year == "2")
            {
                lst = db.Students.Where(x => x.school_year == "2021-2025").ToList();
            }
            else if (student_year == "3")
            {
                lst = db.Students.Where(x => x.school_year == "2020-2024").ToList();
            }
            else if (student_year == "4")
            {
                lst = db.Students.Where(x => x.school_year == "2019-2023").ToList();
            }
            else
            {
                lst = db.Students.ToList();
            }
            return lst;
        }
        public List<ProgressStudent> resultStudentEachSemester(List<The_amazing_of_numbers.Model.Student> allstudent)
        {
            List<ProgressStudent> lst = new List<ProgressStudent>();
            foreach (The_amazing_of_numbers.Model.Student items in allstudent)
            {
                int tmp_learningscore = 0;
                int tmp_trainingscore = 0;
                int countsemester = 1;
                ProgressStudent currentStudent = new ProgressStudent();

                List<ProgressScore> lst_ProgressScore = db.ProgressScores.Where(x => x.id == items.id).ToList();
                //Console.WriteLine("Count = " + lst_ProgressScore.Count);
                //liệt kê tất cả các HK của sinh viên đó
                if (lst_ProgressScore.Count != 0)
                {
                    countsemester = 0;
                }
                foreach (ProgressScore allProgressScore in lst_ProgressScore)
                {
                    //Console.WriteLine(allProgressScore.id);
                    if (allProgressScore.learning_score != null)
                    {
                        tmp_learningscore += (int)allProgressScore.learning_score;
                    }
                    tmp_trainingscore += (int)allProgressScore.score;
                    countsemester++;
                }
                currentStudent.stu_info = items;
                currentStudent.learningscore = tmp_learningscore / countsemester;
                currentStudent.trainingscore = tmp_trainingscore / countsemester;
                currentStudent.numVio = db.StudentVios.Where(x => x.id == items.id).Count();
                //Console.WriteLine(tmp_trainingscore);
                lst.Add(currentStudent);
            }
            return lst;
        }
        public List<ProgressStudent> sortStudent(List<ProgressStudent> sortdata, bool isAsc, string sortType)
        {
            List<ProgressStudent> lst = new List<ProgressStudent>();
            if (sortType == "1") //1 = learningscore
            {
                if (isAsc)
                {
                    lst = sortdata.OrderBy(x => x.learningscore).ToList();
                }
                else
                {
                    lst = sortdata.OrderByDescending(x => x.learningscore).ToList();
                }
            }
            if (sortType == "2") //2 = trainingscore == score
            {
                if (isAsc)
                {
                    lst = sortdata.OrderBy(x => x.trainingscore).ToList();
                }
                else
                {
                    lst = sortdata.OrderByDescending(x => x.trainingscore).ToList();
                }

            }
            if (sortType == "3") //3 = numVio
            {
                if (isAsc)
                {
                    lst = sortdata.OrderBy(x => x.numVio).ToList();
                }
                else
                {
                    lst = sortdata.OrderByDescending(x => x.numVio).ToList();
                }
            }
            if (sortType == "Top10")
            {
                lst = sortdata.OrderByDescending(x => x.learningscore).OrderByDescending(x => x.trainingscore).OrderBy(x => x.numVio).Take(10).ToList();
            }
            return lst;
        }
        public List<The_amazing_of_numbers.Model.Student> applySort(List<The_amazing_of_numbers.Model.Student> students, List<ProgressStudent> lastSort)
        {
            List<The_amazing_of_numbers.Model.Student> lst = new List<The_amazing_of_numbers.Model.Student>();

            foreach (ProgressStudent allProgressStudent in lastSort)
            {
                The_amazing_of_numbers.Model.Student findStudent = db.Students.Where(x => x.id == allProgressStudent.stu_info.id).FirstOrDefault();
                if (findStudent != null)
                {
                    lst.Add(findStudent);
                }
            }

            return lst;
        }
    }
}
