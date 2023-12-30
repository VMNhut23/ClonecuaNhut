using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_amazing_of_numbers.Area.AdminArea.View;
using The_amazing_of_numbers.Area.Lecturer.View;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Area.Lecturer.Controllers
{
    internal class LecturerController
    {
        dbUniversityDataContext db = new dbUniversityDataContext();
        private User cur_user;
        public void LecturerHomeView(User user_model)
        {
            cur_user = user_model;
            new LecturerMainForm(cur_user).Show();
        }
        public Lecture infoDetails(string id)
        {
            Lecture lt = db.Lectures.Where(l => l.id == id).FirstOrDefault();
            return lt;
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
