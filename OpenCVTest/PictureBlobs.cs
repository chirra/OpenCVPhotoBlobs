using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;
using OpenCvSharp.Blob;
using OpenCvSharp.Extensions;

namespace OpenCVTest
{
    public class PictureBlobs
    {

        private int minThreshold;
        public int MinThreshold
        {
            get { return minThreshold;}
            set
            {
                if (value < 0) minThreshold = 0;
                else if (value > 255) minThreshold = 255;
                else minThreshold = value;
            } 
        }


        private int maxThreshold;
        public int MaxThreshold
        {
            get { return maxThreshold; }
            set
            {
                if (value < 0) maxThreshold = 0;
                else if (value > 255) maxThreshold = 255;
                else maxThreshold = value;
            }
        }


        private IplImage image;
    

        public PictureBlobs(string pathToImage)
        {
            minThreshold = 150;
            maxThreshold = 255;
            image = new IplImage(pathToImage, LoadMode.Color);
        }


        private CvBlobs GetBlobs()
        {
            IplImage binary = new IplImage(image.Size, BitDepth.U8, 1);
            IplImage tmpImage = image.Clone();

            Cv.CvtColor(tmpImage, binary, ColorConversion.BgrToGray);
            Cv.Threshold(binary, binary, MinThreshold, MaxThreshold, ThresholdType.Binary);

            CvBlobs blobs = new CvBlobs();
            blobs.Label(binary);
            return blobs;
        }


        public Bitmap GetBlobsBitmap(int minBlobThreshold)
        {
            var blobs = GetBlobs();

            IplImage platetemp = new IplImage(image.Size, BitDepth.U8, 3);
            platetemp.FloodFill(new CvPoint(1, 1), new CvScalar(255, 255, 255));

            foreach (var item in blobs)
            {
                if ((item.Value.Rect.Width > minBlobThreshold) && (item.Value.Rect.Height > minBlobThreshold))
                    platetemp.Rectangle(item.Value.Rect, new CvScalar(0, 0, 0), 2, LineType.Link4);
            }

          Bitmap bitmap = platetemp.ToBitmap();

          return bitmap;
        }


        public Bitmap GetPictureBlobsBitmap(int minBlobThreshold)
        {
            var blobs = GetBlobs();
            IplImage tmpImage = image.Clone();

            foreach (var item in blobs)
            {
                if ((item.Value.Rect.Width > minBlobThreshold) && (item.Value.Rect.Height > minBlobThreshold))
                    tmpImage.Rectangle(item.Value.Rect, new CvScalar(0, 0, 0), 2, LineType.Link4);
            }

            Bitmap bitmap = tmpImage.ToBitmap();

            return bitmap;
        }

    }
}
