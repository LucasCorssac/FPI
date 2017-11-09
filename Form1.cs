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
        private PictureBox[] picboxes = new PictureBox[2];
        private int picBoxIndex = 0;
        private int placeW = 0, placeH = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private Image pictureLoader(string pictureName)
        {
            Image image = Image.FromFile(pictureName);

            var picture = new PictureBox
            {
                Name = "pictureBox",
                Size = new Size(image.Width, image.Height),
                Location = new Point(placeW, placeH),
                Image = image,

            };

            placeW += image.Width;
            placeH += image.Height;
            picBoxIndex += 1;

            picboxes[picBoxIndex] = picture;

            this.Controls.Add(picture);
            
            return image;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Image image = pictureLoader("spurdo.jpg");
            pictureLoader("johnny.jpg");
            // Set the PictureBox image property to this image.
            //this.Controls.pictureBox.Image = image;
            //pictureBox.Height = image.Height;
            //pictureBox.Width = image.Width;

            this.Height = image.Height;
            this.Width = image.Width;

            image.Save("johnny.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);


        }
    }
}
