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

        private void picture_loader()
        {
            var picture = new PictureBox
            {
                Name = "pictureBox",
                Size = new Size(16, 16),
                Location = new Point(100, 100),
                Image = Image.FromFile("hello.jpg"),

            };
            this.Controls.Add(picture);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Image image = Image.FromFile("spurdo.jpg");
            // Set the PictureBox image property to this image.
            // ... Then, adjust its height and width properties.
            pictureBox1.Image = image;
            pictureBox1.Height = image.Height;
            pictureBox1.Width = image.Width;

            this.Height = image.Height + 100;
            this.Width = image.Width + 100;

            image.Save("johnny.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);


        }
    }
}
