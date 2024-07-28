using Microsoft.VisualBasic.ApplicationServices;

namespace Bank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private ConnectionUser datauser = new ConnectionUser();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            UsernameTb.Text = "";
            PasswordTb.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                PasswordTb.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordTb.UseSystemPasswordChar = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateUser form = new CreateUser();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UsernameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Missing data, enter both Username and Password.");
            }
            else
            {

                User LoggedUser = datauser.Login(UsernameTb.Text, PasswordTb.Text);
                if (LoggedUser.ID == 0)
                {
                    MessageBox.Show("Wrong data, enter the correct Username and Password.");
                }
                else
                {
                    if (LoggedUser.AdminStatus == 1)
                    {
                        MessageBox.Show("Welcome Admin");
                        ManageUsers2 form = new ManageUsers2(LoggedUser);
                        form.Show();
                        this.Hide();
                    }
                    else if (LoggedUser.AdminStatus == 0)
                    {
                        MessageBox.Show("Welcome user");
                        ManageUsers form = new ManageUsers(LoggedUser);
                        form.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong credidentials");
                    }
                }

            }
        }
    }
}