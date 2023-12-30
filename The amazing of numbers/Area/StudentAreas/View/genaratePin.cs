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
    public partial class genaratePin : Form
    {
        public genaratePin()
        {
            InitializeComponent();
        }

        private void modelEffect_Timer_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            int y = ProfileEdition.parentY += 3;
            this.Location = new Point(ProfileEdition.parentX + 220, ProfileEdition.parentX + 220);
            if (y >= 1)
            {
                modelEffect_Timer.Stop();
            }
        }
        int i;
        private void genaratePin_Load(object sender, EventArgs e)
        {
            i = ProfileEdition.parentY + 150;
            this.Location = new Point(ProfileEdition.parentX + 100, ProfileEdition.parentY + 150);
        }
    }
}
