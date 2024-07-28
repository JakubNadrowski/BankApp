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
    public partial class CreateAccount : Form
    {
        User LoggedUser = new User();
        public CreateAccount(User user)
        {
            InitializeComponent();
            LoggedUser = user;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            if (AccNum.Text.Length > 9)
            {
                MessageBox.Show("This account number is too long");
            }
            else
            {
                account.AccountNum = Convert.ToInt32(AccNum.Text);
                account.Name = AccName.Text;
                account.CreateAccount(LoggedUser);
                ManageUsers form = new ManageUsers(LoggedUser);
                form.Show();
                this.Hide();
            }
            
        }
    }
}
