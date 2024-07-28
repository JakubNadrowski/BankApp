using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace Bank
{
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private ConnectionClass data = new ConnectionClass();

        private void button1_Click(object sender, EventArgs e)
        {

            if (UsernameTxt.Text == "" || PasswordTxt.Text == "" || EmailTxt.Text == "" || PhonenumTxt.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                if (EmailTxt.Text.Contains("@"))
                {
                    User user = new User(UsernameTxt.Text, PasswordTxt.Text, EmailTxt.Text, Convert.ToInt32(PhonenumTxt.Text), 0, null);

                    user.CreateUser();

                    Form1 form = new Form1();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("The email doesn't contain the @ symbol, please enter an email adress.");
                }
                

            }


        }


        private void CreateUser_Load(object sender, EventArgs e)
        {

        }

        private void CheckUnames_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                PasswordTxt.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordTxt.UseSystemPasswordChar = true;
            }
        }

        private void PasswordTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
