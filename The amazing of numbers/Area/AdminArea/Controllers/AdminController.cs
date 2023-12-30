using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_amazing_of_numbers.Area.AdminArea.View;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Area.AdminArea.Controllers
{
    internal class AdminController
    {
        dbUniversityDataContext db = new dbUniversityDataContext();
        private User cur_user;
        public void AdminHomeView(User user_model)
        {
            cur_user = user_model;
            new AdminMainForm(cur_user).Show();
        }
        public void AddingPIN(string PIN, string id)
        {
            //Console.WriteLine("User id: " + id);
            try {
                var user_model = db.Users.Where(user => user.id == id).FirstOrDefault();
                if (user_model != null)
                {
                    user_model.pin = PIN;
                    db.SubmitChanges();
                }
                
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void UpdateRule(int id, string name, string punishment, string object_)
        {
            Violate vio = db.Violates.FirstOrDefault(u => u.rules_id == id);
            if (vio != null)
            {
                vio.rules_id = id;
                vio.rules_name = name;
                vio.rules_punishment = punishment;
                vio.object_ = object_;
                db.SubmitChanges();
            }
        }
        public void DeleteRule(int id)
        {
            Violate vio = db.Violates.FirstOrDefault(s => s.rules_id == id);
            db.Violates.DeleteOnSubmit(vio);
            db.SubmitChanges();
        }
        public void UpdateInfoAcademicAff(string id, string email, string name, string sex, string dob, string phone, string dpt_id)
        {
            Academic_Affair academic = db.Academic_Affairs.FirstOrDefault(a => a.id == id);
            if (academic != null)
            {
                academic.id = id;
                academic.username = email;
                academic.name_ = name;
                academic.sex = sex;
                academic.dob = dob;
                academic.phone_num = phone;
                academic.department_id = dpt_id;
                db.SubmitChanges();
            }
        }
        public void DeleteAcademicAff(string id)
        {
            Academic_Affair academic = db.Academic_Affairs.FirstOrDefault(a => a.id == id);
            db.Academic_Affairs.DeleteOnSubmit(academic);
            db.SubmitChanges();
        }
        public Admin infoDetail(string id)
		{
            Admin admin = db.Admins.Where(s => s.id == id).FirstOrDefault();
            return admin;
        }
        public byte[] ImageToByteArray(PictureBox picture)
        {
            MemoryStream memoryStream = new MemoryStream();
            picture.Image.Save(memoryStream, picture.Image.RawFormat);
            return memoryStream.ToArray();
        }
        public Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }
    }
}
