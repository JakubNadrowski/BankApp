using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class ProfilePic : Form
    {
        User LoggedUser = new User();
        public ProfilePic(User user)
        {
            InitializeComponent();
            LoggedUser = user;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Choose an image (*.jpg; *.png;)|*.jpg; *.png;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                byte[] imageBytes = File.ReadAllBytes(ofd.FileName);
                LoggedUser.UploadPFP(imageBytes);
                this.Hide();
                ManageUsers form = new ManageUsers(LoggedUser);
                form.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MemoryStream stream = new MemoryStream();
            pictureBox1.Image.Save(stream, pictureBox1.Image.RawFormat);
            byte[] img = stream.ToArray();

            LoggedUser.UploadPFP(img);
            this.Hide();
            ManageUsers form = new ManageUsers(LoggedUser);
            form.Show();
        }
    }
}
