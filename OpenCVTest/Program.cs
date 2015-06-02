using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Blob;
using OpenCvSharp.CPlusPlus;
using OpenCvSharp.Extensions;
using OpenCVTest.Properties;

namespace OpenCVTest
{
    class Program
    {
        static void Main(string[] args)
        {
            /*IplImage src = new IplImage("photo.jpg", LoadMode.Color);
            IplImage binary = new IplImage(src.Size, BitDepth.U8, 1);

            Cv.CvtColor(src, binary, ColorConversion.BgrToGray);
            Cv.Threshold(binary, binary, 150, 151, ThresholdType.Binary); 

            CvBlobs blobs = new CvBlobs();
            blobs.Label(binary);

            IplImage platetemp = new IplImage(src.Size, BitDepth.U8, 3);
            platetemp.FloodFill(new CvPoint(1, 1), new CvScalar(255, 255, 255));

            foreach (var item in blobs)
            {
                int label = item.Key;
                platetemp.Rectangle(item.Value.Rect, new CvScalar(0, 0, 0), 2, LineType.Link4);
            }


           // IplImage render = new IplImage(src.Size, BitDepth.U8, 3);
            
            //blobs.RenderBlobs(src, render);

            Bitmap bitmap = platetemp.ToBitmap();

            Form form = new Form
            {
                Text = "Display IplImage in PictureBox",
                ClientSize = bitmap.Size,
            };


            PictureBox pictureBox = new PictureBox
            {
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = bitmap,
            };


            form.Controls.Add(pictureBox);
            form.ShowDialog();*/

            PictureBlobs pb = new PictureBlobs("photo.png");

            Bitmap blobs = pb.GetBlobsBitmap(100);
            Bitmap pictureBlobs = pb.GetPictureBlobsBitmap(100);


            Form form2= new Form
            {
                Text = "Display IplImage in PictureBox",
                ClientSize = pictureBlobs.Size,
            };
            PictureBox pictureBox2 = new PictureBox
            {
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = pictureBlobs,
            };
            form2.Controls.Add(pictureBox2);
            form2.ShowDialog();

            /*****/
            Form form = new Form
            {
                Text = "Display IplImage in PictureBox",
                ClientSize = blobs.Size,
            };
            PictureBox pictureBox = new PictureBox
            {
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = blobs,
            };
            form.Controls.Add(pictureBox);
            form.ShowDialog();


        }
    }
}
