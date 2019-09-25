using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slideshow1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] image = { "\\image\\watch1.jpg", "\\image\\watch2.jpg", "\\image\\watch3.jpg", "\\image\\watch4.jpg", "\\image\\watch5.jpg" };
            for(int i = 0; i <= 4; i++)
            {
                image[i] = System.IO.Directory.GetCurrentDirectory() + image[i];
            }
            pictureB1.Image = Image.FromFile(image[0]);
            pictureB1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureB2.Image = Image.FromFile(image[1]);
            pictureB2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureB3.Image = Image.FromFile(image[2]);
            pictureB3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureB4.Image = Image.FromFile(image[3]);
            pictureB4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureB5.Image = Image.FromFile(image[4]);
            pictureB5.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
        }
        int i=0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            string[] image = { "\\image\\watch1.jpg", "\\image\\watch2.jpg", "\\image\\watch3.jpg", "\\image\\watch4.jpg", "\\image\\watch5.jpg" };
            //vòng for chạy để lấy địa chỉ tương đối của ảnh
            for (int j = 0; j <= 4; j++)
            {
                image[j] = System.IO.Directory.GetCurrentDirectory() + image[j];
            }
            pictureBox1.Image = Image.FromFile(image[i]);
            i++;
            //nêu i vượt quá số ảnh thì reset lại i=0
            if (i == 5)
                i = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
