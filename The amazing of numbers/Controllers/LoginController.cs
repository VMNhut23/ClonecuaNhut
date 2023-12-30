using System;
using System.Collections.Generic;
using System.Data;
using System.Deployment.Application;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_amazing_of_numbers.Area.AcademicAffair.Controllers;
using The_amazing_of_numbers.Area.AdminArea.Controllers;
using The_amazing_of_numbers.Area.AdminArea.View;
using The_amazing_of_numbers.Area.Lecturer.Controllers;
using The_amazing_of_numbers.Area.StudentAreas.Controllers;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Controller
{
    //Declare db here
    //UniversityDataContext db = new UniversityDataContext();
    internal class LoginController
    {
        dbUniversityDataContext db = new dbUniversityDataContext();
        private Dictionary<char, char> mp;
        private User user_model = new User();
        public LoginController()
        {
            mp = new Dictionary<char, char>();
            mp.Add('0', '7');
            mp.Add('9', '6');
            mp.Add('8', '5');
            mp.Add('7', '4');
            mp.Add('6', '3');
            mp.Add('5', '2');
            mp.Add('4', '1');
            mp.Add('3', 'z');
            mp.Add('2', 'y');
            mp.Add('1', 'x');
            mp.Add('z', 'w');
            mp.Add('y', 'v');
            mp.Add('x', 'u');
            mp.Add('w', 't');
            mp.Add('v', 's');
            mp.Add('u', 'r');
            mp.Add('t', 'q');
            mp.Add('s', 'p');
            mp.Add('r', 'o');
            mp.Add('q', 'n');
            mp.Add('p', 'm');
            mp.Add('o', 'l');
            mp.Add('n', 'k');
            mp.Add('m', 'j');
            mp.Add('l', 'i');
            mp.Add('k', 'h');
            mp.Add('j', 'g');
            mp.Add('i', 'f');
            mp.Add('h', 'e');
            mp.Add('g', 'd');
            mp.Add('f', 'c');
            mp.Add('e', 'b');
            mp.Add('d', 'a');
            mp.Add('c', '0');
            mp.Add('b', '9');
            mp.Add('a', '8');
        }

        //Login view will send data to this function
        public bool CheckValid(string user_id, string password, ref string user_role)
        {
            try
            {
                User cur_user = db.Users.Where(i => i.id == user_id).FirstOrDefault();
                if (cur_user != null)
                {
                    string decoded_pass = Decode(cur_user.password_);
                    if (password == cur_user.password_)
                    {
                        user_model = cur_user;
                        user_role = cur_user.role_;
                        return true;
                    }
                    return false;
                }
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
        public bool CheckValidPIN(string PIN, ref string user_role)
        {
            try
            {
                User cur_user = db.Users.Where(i => i.pin == PIN).FirstOrDefault();
                if (cur_user != null)
                {
                    user_model = cur_user;
                    user_role = cur_user.role_;
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }



        public string Decode(string edcodedPass)
        {
            string decodedPass = "";
            for (int i = 0; i < edcodedPass.Length; i++)
            {
                decodedPass += mp[edcodedPass[i]];
            }
            return decodedPass;
        }

        public void DirectDifferentAutorization(string user_role, Login cur_form)
        {
            cur_form.Hide();
            switch (user_role.ToLower())
            {
                case ("admin"):
                    AdminController adminController = new AdminController();
                    adminController.AdminHomeView(user_model);
                    break;
                case ("student"):
                    StudentAreasController studentController = new StudentAreasController();
                    studentController.StudentHomeView(user_model);
                    break;
                case ("lecture"):
                    LecturerController lecturerController = new LecturerController();
                    lecturerController.LecturerHomeView(user_model);
                    break;
                case ("academic affair"):
                    AcademicAffairController academicAffairController = new AcademicAffairController();
                    academicAffairController.AcademicAffairHomeView(user_model);
                    break;
                default:
                    break;
            }
        }

    }
}
