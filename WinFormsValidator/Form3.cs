using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WinFormsValidator.authenticate;
using static WinFormsDemo.imageUploader;

namespace WinFormsValidator
{
    public partial class Form3 : Form
    {

        private User authenticatedUser;
        public Form3(User user)
        {
            InitializeComponent();
            authenticatedUser = user;

            welcomeLabel.Text = $"Welcome, {authenticatedUser.Username}!";
            labelE.Text = $"Email: {authenticatedUser.Email}";
            labelG.Text = $"Gender: {authenticatedUser.Gender}";
            if (user.Image != null && user.Image.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(user.Image))
                {
                    pictureBox.Image = Image.FromStream(ms);
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();


            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string selectedImagePath = openFileDialog.FileName;
                    Image selectedImage = Image.FromFile(selectedImagePath);

                    byte[] imageData = ImageToByteArray(selectedImage);

                    UploadImage(authenticatedUser.Username, imageData);

                    pictureBox.Image = selectedImage;

                    uploadButton.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error uploading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (Form4 reserveForm = new Form4())
            {
                reserveForm.ShowDialog();
            }
        }
    }
}
