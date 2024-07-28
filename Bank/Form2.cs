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
    public partial class Form2 : Form
    {
        User Loggeduser = new User();
        public Form2(User user)
        {
            InitializeComponent();
            Loggeduser = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loggeduser.Password = NewPassword.Text;
            int conf = Loggeduser.UpdatePassword();
            if (conf != -1)
            {
                MessageBox.Show("Password Changed!");
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
        }
    }
}
