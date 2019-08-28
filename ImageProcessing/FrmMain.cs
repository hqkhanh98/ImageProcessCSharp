using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class FrmMain : Form
    {
        private Boolean stateChooseImage = false;
        private int offset = 3;
        private Bitmap bmSave, bmGraySave;
        public FrmMain()
        {
            InitializeComponent();
            btn3x3.Visible = false;
            btn5x5.Visible = false;
            imageGrayScaleToolStripMenuItem.Enabled = false;
            imageRGBToolStripMenuItem.Enabled = false;
            convertToGrayToolStripMenuItem.Enabled = false;
            convertToSEPIAToolStripMenuItem.Enabled = false;
            filterToolStripMenuItem.Enabled = false;
        }
        /**
         * @ Author : Huỳnh Quốc Khánh
         * @ Date Create : 25/8/2019
         * @ Project : Image Processing
         */
        //Thay đổi kích cỡ ảnh
        public Image resizeImage(Image img, int width, int height)
        {
            // Tạo mới bitmap
            Bitmap bitmap = new Bitmap(width, height);
            //Tải image xử lý
            Graphics graphics = Graphics.FromImage((Image)bitmap);
            // Xuất
            graphics.DrawImage(img, 0, 0, width, height);
            graphics.Dispose();
            //Trả về ảnh
            return (Image)bitmap;
        }

        OpenFileDialog openfile = new OpenFileDialog();

        private void btnChoose_Click(object sender, EventArgs e)
        {
            //Tiêu đề
            openfile.Title = "Chọn File Ảnh ";
            //openfile.InitialDirectory = @"c:\Program Files";//Thư mục mặc định khi mở
            //Lọc file cần tìm
            openfile.Filter = "Image Files(*.jpg,*.png,*.tiff,*.bmp,*.gif)|*.jpg;*.png;*.tiff;*.bmp;*.gif";// Lọc ra những file cần hiển thị
            //openfile.FilterIndex = 1;//chúng ta có All files là 1,exe là 2
            openfile.RestoreDirectory = true;

            if (openfile.ShowDialog() == DialogResult.OK)
            {
                //Tải ảnh lên
                Image imgLoad = Image.FromFile(openfile.FileName);
                bmSave = (Bitmap)imgLoad;
                //Thay đổi kích thước ảnh cho phù hợp với chương trình
                imgLoad = resizeImage(imgLoad, picOrigin.Width, picOrigin.Height);

                //Tải ảnh lên pictureBox
                
                picOrigin.Image = imgLoad;

                imageRGBToolStripMenuItem.Enabled = true;
                convertToGrayToolStripMenuItem.Enabled = true;
                convertToSEPIAToolStripMenuItem.Enabled = true;
                filterToolStripMenuItem.Enabled = true;
                stateChooseImage = true;

                //txtHinh.Text = Path.GetFileName(openfile.FileName);
            }
        }

        private void btnMedian_Click(object sender, EventArgs e)
        {
            if (stateChooseImage == true)
            {
                btn3x3.Visible = true;
                btn5x5.Visible = true;
            }
            else
            {
                MessageBox.Show("Image was not choose !", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void process(int offset)
        {
                Bitmap result = (Bitmap)picOrigin.Image;
                Image imgResult = Filter.medianFilter(result, offset);
                MessageBox.Show("Process Complete!", "INFO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Load Image
                picResult.Image = imgResult;
        }


        private void btn3x3_Click(object sender, EventArgs e)
        {
            process(3);
        }
        private void btn5x5_Click(object sender, EventArgs e)
        {
            process(5);
        }

        private void btnAvg_Click(object sender, EventArgs e)
        {
            if (stateChooseImage == true)
            {
                Bitmap result = (Bitmap)picOrigin.Image;

                Image imgResult = Filter.averageFilter(result);
                MessageBox.Show("Process Complete!", "INFO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Load Image
                picResult.Image = imgResult;
            }
            else
            {
                MessageBox.Show("Image was not choose !", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void convertToGrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (stateChooseImage == true)
            {
                Bitmap result = (Bitmap)picOrigin.Image;

                Image imgResult = ProcessImage.convertRGBToGray(result);
                MessageBox.Show("Process Complete!", "INFO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Load Image
                picResult.Image = imgResult;
                bmGraySave = (Bitmap)imgResult;
                imageGrayScaleToolStripMenuItem.Enabled = true;
            }
            else
            {
                MessageBox.Show("Image was not choose !", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void convertToSEPIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (stateChooseImage == true)
            {
                Bitmap result = (Bitmap)picOrigin.Image;

                Image imgResult = ProcessImage.convertRGBToSepia(result);
                MessageBox.Show("Process Complete!", "INFO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Load Image
                picResult.Image = imgResult;
            }
            else
            {
                MessageBox.Show("Image was not choose !", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void imageGrayScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (stateChooseImage == true)
            {
                Bitmap result = (Bitmap)picOrigin.Image;

                Image imgResult = ProcessImage.getOffsetGrayScale(result);
                MessageBox.Show("Process Complete!", "INFO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Load Image
                picResult.Image = imgResult;
            }
            else
            {
                MessageBox.Show("Image was not choose !", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void imageRGBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (stateChooseImage == true)
            {
                Bitmap result = bmGraySave;

                Image imgResult = ProcessImage.getOffsetGrayScale(result);
                MessageBox.Show("Process Complete!", "INFO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Load Image
                picResult.Image = imgResult;
                picOrigin.Image = bmGraySave;
            }
            else
            {
                MessageBox.Show("Image was not choose !", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
