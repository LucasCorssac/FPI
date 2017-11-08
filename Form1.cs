using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fpi_trab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Image picture_loader(string picture_name)
        {
            Image image = Image.FromFile(picture_name);
            var picture = new PictureBox
            {
                Name = "pictureBox",
                Size = new Size(16, 16),
                Location = new Point(100, 100),
                Image = image,

            };
            this.Controls.Add(picture);
            return image;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Image image = picture_loader("spurdo.jpg");
            // Set the PictureBox image property to this image.
            this.Controls.   pictureBox.Image = image;
            pictureBox.Height = image.Height;
            pictureBox.Width = image.Width;

            this.Height = image.Height + 100;
            this.Width = image.Width + 100;

            image.Save("johnny.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);


        }
    }
}
