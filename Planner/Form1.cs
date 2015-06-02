using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCVTest;

namespace Planner
{
    public partial class Planner : Form
    {

        
        private int minThresholdLevel;
        private string fileName;
        private Form pictureForm1 =  new Form();
        private PictureBox pictureBox1 = new PictureBox();
        private Form pictureForm2 = new Form();
        private PictureBox pictureBox2 = new PictureBox();
        private PictureBlobs pb;


        public Planner()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (dlgOpenImage.ShowDialog() == DialogResult.OK)
            {
                fileName = dlgOpenImage.FileName;
                LoadImage(trackBarMinThreshold.Value, trackBarPhiltre.Value);
                trackBarMinThreshold.Enabled = true;
                trackBarPhiltre.Enabled = true;
                btnSave.Enabled = true;
            }
        }


        private void LoadImage(int minThresholdLevel, int minBlobsLevel)
        {
            pb = new PictureBlobs(fileName);

            pb.MinThreshold = minThresholdLevel;
            //pb.MaxThreshold = maxThresholdLevel;

            Bitmap pictureBlobs = pb.GetPictureBlobsBitmap(minBlobsLevel);
            Bitmap blobs = pb.GetBlobsBitmap(minBlobsLevel);

            LoadContent(pictureForm1, pictureBox1, pictureBlobs);
            LoadContent(pictureForm2, pictureBox2, blobs);
        }


        private void LoadContent(Form form, PictureBox pictureBox, Bitmap bitmap)
        {
            form.Text = "Planner Picture";
            form.ClientSize = bitmap.Size;

            pictureBox.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = bitmap;

            form.Controls.Add(pictureBox);
            form.Show();
        }
  

        private void UpdateImage(int minThresholdLevel, int minBlobsLevel)
        {
            pb.MinThreshold = minThresholdLevel;
            //pb.MaxThreshold = 50;
            
            Bitmap pictureBlobs = pb.GetPictureBlobsBitmap(minBlobsLevel);
            Bitmap blobs = pb.GetBlobsBitmap(minBlobsLevel);

            pictureBox1.Image = pictureBlobs;
            pictureBox2.Update();

            pictureBox2.Image = blobs;
            pictureBox2.Update();
        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            UpdateImage(trackBarMinThreshold.Value, trackBarPhiltre.Value);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
          if (dlgSaveImage.ShowDialog() == DialogResult.OK)
            {
                ImageFormat format = ImageFormat.Jpeg;
                pictureBox2.Image.Save(dlgSaveImage.FileName, format);
            }
        }

       
    }
}
