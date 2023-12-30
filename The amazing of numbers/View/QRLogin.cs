using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;
using ZXing;

namespace The_amazing_of_numbers
{
    public partial class QRLogin : Form
    {
        public QRLogin()
        {
            InitializeComponent();
            this.Opacity = 1;
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;

        private void QRLogin_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            
            foreach (FilterInfo filter in filterInfoCollection)
            {
                cboDevice.Items.Add(filter.Name);
            }
            if (cboDevice.Items.Count == 0)
            {
                string message = "Cannot find your camera";
                string title = "Notice";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.OK) //Reset password in DB
                {
                    this.Close();
                }
                else
                {
                    // Do something
                }
            }
            else
            {
                cboDevice.SelectedIndex = 0;
            }   
        }

        private void ScanBtn_Click(object sender, EventArgs e)
        {
            pictureBox.Visible = true;
            pictureBox.Enabled = true;
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cboDevice.SelectedIndex].MonikerString);
         
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void QRLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice != null && captureDevice.IsRunning)
            {
                captureDevice.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox.Image);
                if (result != null)
                {
                    string res = result.ToString();
                    string[] collection = res.Split('\n');
                    timer1.Stop();
                    if (captureDevice.IsRunning)
                    {
                        captureDevice.Stop();
                        try
                        {
                            if (collection[0] == "khoa123" && collection[1] == "5544321")
                            {
                                MessageBox.Show("Login Successfully!!!");
                            }
                            else
                            {
                                MessageBox.Show("Your ID or Password\nmay have been incorrect!!!");
                                captureDevice.Start();
                                timer1.Start();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Your ID or Password\nmay have been incorrect!!!");
                            captureDevice.Start();
                            timer1.Start();
                        }
                    }
                }
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
