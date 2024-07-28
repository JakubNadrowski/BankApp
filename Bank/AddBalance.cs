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
    public partial class AddBalance : Form
    {
        User accHolder = new User();
        Account account = new Account();
        public AddBalance(User user)
        {
            InitializeComponent();
            accHolder = user;
            foreach (int num in account.UsersAccounts(accHolder))
            {
                listBox1.Items.Add(num);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) { MessageBox.Show("Please select an account to send money from."); }
            else
            {
                if (amount.Text == "")
                {
                    MessageBox.Show("Please enter the amount.");
                }
                else
                {
                    account.AccountNum = Convert.ToInt32(listBox1.SelectedItem.ToString());
                    account.Balance = account.AccountBalance();
                    account.Balance += Convert.ToInt32(amount.Text);
                    account.UpdateBalance();
                    this.Hide();
                    ManageUsers form = new ManageUsers(accHolder);
                    form.Show();

                }
            }
        }
    }
}
