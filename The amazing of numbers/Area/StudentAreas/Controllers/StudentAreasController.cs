using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_amazing_of_numbers.Area.Student.View;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Area.StudentAreas.Controllers
{
    internal class StudentAreasController
    {
        dbUniversityDataContext db = new dbUniversityDataContext();
        private User cur_user;
        public void StudentHomeView(User user_model)
        {
            cur_user = user_model;
            new StudentMainForm(cur_user).Show();
        }
        public The_amazing_of_numbers.Model.Student infoDetail(string ID)
        {
            The_amazing_of_numbers.Model.Student st = db.Students.Where(s => s.id == ID).FirstOrDefault();
            return st;
        }
        public byte[] ImageToByteArray(PictureBox picture)
        {
            MemoryStream memoryStream = new MemoryStream();
            picture.Image.Save(memoryStream, picture.Image.RawFormat);
            return memoryStream.ToArray();
        }
    }
}
