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
            //Mat mat = new Mat("foobar.jpg", LoadMode.Color);
            IplImage src = new IplImage("photo.png", LoadMode.Color);
            IplImage binary = new IplImage(src.Size, BitDepth.U8, 1);

            Cv.CvtColor(src, binary, ColorConversion.BgrToGray);
            Cv.Threshold(binary, binary, 150, 151, ThresholdType.Binary); 



            CvBlobs blobs = new CvBlobs();
            blobs.Label(binary);

           // IplImage pimg = new IplImage(src.Size, BitDepth.U8, 3);
            IplImage platetemp = new IplImage(src.Size, BitDepth.U8, 3);

            //CvPoint cvp = new CvPoint(1, 1);
            //var cvpi = new []{new CvPoint(1,1)};
            platetemp.FloodFill(new CvPoint(1, 1), new CvScalar(255, 255, 255));

            //foreach (KeyValuePair<int, CvBlob> item in blobs)
            foreach (var item in blobs)
            {
                int label = item.Key;
                //item.Value.SetImageRoiToBlob(src);

                //platetemp = new IplImage(new CvSize(src.ROI.Width, src.ROI.Height), src.Depth,src.NChannels);

                platetemp.Rectangle(item.Value.Rect, new CvScalar(0, 0, 0), 2, LineType.Link4);
                //plate.Add(platetemp);

                //blob.SetImageRoiToBlob(render);


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
            form.ShowDialog();
        }
    }
}
