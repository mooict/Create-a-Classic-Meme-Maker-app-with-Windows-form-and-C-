using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Imaging; // this one is for saving JPG images

namespace Meme_Maker_with_MOO_ICT
{

    // www.mooict.com
    // project based programming tutoials
    public partial class Form1 : Form
    {

        OpenFileDialog openImageFile;


        public Form1()
        {
            InitializeComponent();

            SetUpApp();
        }

        private void SetUpApp()
        {
            imgPreview.Controls.Add(lblTopText);
            imgPreview.Controls.Add(lblBottomText);

            lblTopText.Location = new Point(0, 0);

            lblBottomText.Location = new Point(0, 350);

            imgPreview.SendToBack();

        }

        private void ChangeTopText(object sender, EventArgs e)
        {
            lblTopText.Text = txtTopTextBox.Text;
        }

        private void ChangeBottomText(object sender, EventArgs e)
        {
            lblBottomText.Text = txtBottomTextBox.Text;
        }

        private void OpenImage(object sender, EventArgs e)
        {

            openImageFile = new OpenFileDialog();

            openImageFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openImageFile.Filter = "Image Files Only (*.jpg, *.gif, *.png, *.bmp) | *.jpg; *.gif; *.png; *.bmp";


            if (openImageFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    imgPreview.Image = Image.FromFile(openImageFile.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error!, Couldn't load the file" + ex.Message);
                }
            }


        }

        private void SaveImage(object sender, EventArgs e)
        {

            SaveFileDialog saveDialog = new SaveFileDialog();

            saveDialog.FileName = "Meme with MOO ICT";
            saveDialog.DefaultExt = "jpg";
            saveDialog.Filter = "JPG Image | *.jpg";
            saveDialog.ValidateNames = true;

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                int width = Convert.ToInt32(imgPreview.Width);
                int height = Convert.ToInt32(imgPreview.Height);
                Bitmap bmp = new Bitmap(width, height);
                imgPreview.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                bmp.Save(saveDialog.FileName, ImageFormat.Jpeg);
            }
        }

        private void ChangeTextColour(object sender, EventArgs e)
        {
            Button tempButton = sender as Button;

            lblTopText.ForeColor = tempButton.BackColor;
            lblBottomText.ForeColor = tempButton.BackColor;
        }
    }
}
