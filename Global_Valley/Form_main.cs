using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Global_Valley
{
    public partial class Form_main : Form
    {
        private CVClass Cv = new CVClass();
        public Form_main()
        {
            InitializeComponent();
        }
        
        private void button_imgSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                using (Bitmap bmp = new Bitmap(open.FileName))
                {
                    pictureBox_org.Image = Cv.ToGray(new Bitmap(bmp, ExpandToBound(bmp.Size, pictureBox_org.Size)));
                }

                this.Text = open.FileName;
            }
        }

        private static Size ExpandToBound(Size image, Size boundingBox)
        {
            double widthScale = 0, heightScale = 0;
            if (image.Width != 0)
                widthScale = (double)boundingBox.Width / (double)image.Width;
            if (image.Height != 0)
                heightScale = (double)boundingBox.Height / (double)image.Height;

            double scale = Math.Min(widthScale, heightScale);

            Size result = new Size((int)(image.Width * scale),
                                (int)(image.Height * scale));
            return result;
        }

        private void button_Convert_Click(object sender, EventArgs e)
        {
            int threshold = 0;
            pictureBox_tran.Image = Cv.GlobalValley((Bitmap)pictureBox_org.Image, out threshold);
            Cv.ShowHistogram((Bitmap)pictureBox_org.Image, threshold);
        }
    }
}
