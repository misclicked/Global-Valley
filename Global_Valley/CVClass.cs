using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global_Valley
{
    class CVClass
    {
        public Image ToGray(Bitmap bmp)
        {
            Image ret;
            using (Mat mat = BitmapConverter.ToMat(bmp))
            {
                using (Mat newImage = new Mat())
                {
                    Cv2.CvtColor(mat, newImage, ColorConversionCodes.BGR2GRAY);
                    ret = BitmapConverter.ToBitmap(newImage);
                }
            }
            return ret;
        }
        private int s(int u)
        {
            return u > 0 ? u : 0;
        }
        public Image GlobalValley(Bitmap bmp, bool useF, bool usemedianBlur, out int threshold)
        {
            Image ret;
            int[] hist = new int[256];
            int[] L = new int[256];
            int[] R = new int[256];
            using (Mat mat = BitmapConverter.ToMat(bmp))
            {
                if (usemedianBlur)
                {
                    using (Mat newMat = mat.MedianBlur(3))
                    {
                        for (int i = 0; i < newMat.Height; i++)
                        {
                            for (int j = 0; j < newMat.Width; j++)
                            {
                                hist[newMat.Get<Vec3b>(i, j).Item0]++;
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < mat.Height; i++)
                    {
                        for (int j = 0; j < mat.Width; j++)
                        {
                            hist[mat.Get<Vec3b>(i, j).Item0]++;
                        }
                    }
                }
                
                for (int i = 1; i <= 255; i++)
                {
                    if (hist[i] > L[i - 1])
                    {
                        L[i] = hist[i];
                    }
                    else
                    {
                        L[i] = L[i - 1];
                    }
                }
                for (int i = 254; i >= 0; i--)
                {
                    if (hist[i] > R[i + 1])
                    {
                        R[i] = hist[i];
                    }
                    else
                    {
                        R[i] = R[i + 1];
                    }
                }
                int max = 0;
                int Fi;
                threshold = 0;
                for (int i = 1; i < 255; i++)
                {
                    if(useF)
                        Fi = s(L[i - 1] - hist[i]) + s(R[i + 1] - hist[i]);
                    else
                        Fi = s(L[i - 1] - hist[i]) * s(R[i + 1] - hist[i]);
                    if (Fi > max)
                    {
                        max = Fi;
                        threshold = i;
                    }
                }
               
                using (Mat newImage = new Mat())
                {
                    Cv2.Threshold(mat, newImage, threshold, 255, ThresholdTypes.Binary);
                    ret = newImage.ToBitmap();
                }
            }
            return ret;
        }
        Window histoWindow;
        public void ShowHistogram(Bitmap img, int threshold, bool useM)
        {
            if(histoWindow == null)
            {
                histoWindow = new Window("Histogram", GetHistogram(img, threshold, useM));
            }
            else
            {
                Cv2.ImShow("Histogram", GetHistogram(img, threshold, useM));
            }
        } 
        public Mat GetHistogram(Bitmap img, int threshold, bool useM)
        {
            int[] hist = new int[256];
            int width = 800, height = 450;
            using (Mat mat = useM?BitmapConverter.ToMat(img).MedianBlur(3):BitmapConverter.ToMat(img))
            {
                for (int i = 0; i < mat.Height; i++)
                {
                    for (int j = 0; j < mat.Width; j++)
                    {
                        hist[mat.Get<Vec3b>(i, j).Item0]++;
                    }
                }
            }
            int MaxVal = hist[0];
            for(int i = 1; i < 256; i++)
            {
                MaxVal = Math.Max(MaxVal, hist[i]);
            }

            Mat render = new Mat(new OpenCvSharp.Size(width, height), MatType.CV_8UC3, Scalar.All(255));
            Scalar color = Scalar.All(100);
            int binW = width / 256;
            for (int j = 0; j < 256; ++j)
            {
                if(j == threshold)
                {
                    render.Rectangle(
                        new OpenCvSharp.Point(j * binW, render.Rows - (hist[j] / (double)MaxVal) * height),
                        new OpenCvSharp.Point((j + 1) * binW, render.Rows),
                        Scalar.Red,
                        -1);
                }
                else
                {
                    render.Rectangle(
                        new OpenCvSharp.Point(j * binW, render.Rows - (hist[j] / (double)MaxVal) * height),
                        new OpenCvSharp.Point((j + 1) * binW, render.Rows),
                        color,
                        -1);
                }
            }
            Cv2.ArrowedLine(render, new OpenCvSharp.Point((threshold + 0.5) * binW, 0),
                new OpenCvSharp.Point((threshold + 0.5) * binW, height * 0.3), Scalar.Red, binW/2);
            return render;
        }
    }
}
