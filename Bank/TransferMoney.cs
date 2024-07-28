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
    public partial class TransferMoney : Form
    {
        User sendere = new User();
        Account senderAcc = new Account();
        Account recipientAcc = new Account();
        public TransferMoney(User user)
        {
            InitializeComponent();
            sendere = user;
            foreach (int num in senderAcc.UsersAccounts(sendere))
            {
                listBox1.Items.Add(num);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            
            if (listBox1.SelectedItem == null) { MessageBox.Show("Please select an account to send money from."); }
            else if (recipientNum.Text == null) { MessageBox.Show("Please enter the account number to send money to."); }
            else
            {
                senderAcc.AccountNum = Convert.ToInt32(listBox1.SelectedItem.ToString());
                recipientAcc.AccountNum = Convert.ToInt32(recipientNum.Text);
                if (!recipientAcc.AccountExist())
                {
                    MessageBox.Show("This recipient doesn't exist");
                }
                else
                {
                    int amount = Convert.ToInt32(Amounter.Text);
                    senderAcc.Balance = senderAcc.AccountBalance();
                    recipientAcc.Balance = recipientAcc.AccountBalance();
                    if (amount > senderAcc.Balance) { MessageBox.Show("This account's balance is too low, try another account."); }
                    else
                    {
                        senderAcc.Balance -= amount;
                        recipientAcc.Balance += amount;
                        senderAcc.UpdateBalance();
                        recipientAcc.UpdateBalance();
                        DateTime datetime = DateTime.Now;
                        string date = datetime.ToString("yyyy-MM-dd");
                        Transfer transfer = new Transfer();
                        transfer.sender = senderAcc.AccountNum; transfer.recipient = recipientAcc.AccountNum; transfer.date = date; transfer.amount = amount;
                        transfer.CreateTransfer();
                        MessageBox.Show("Transfer Successful!");
                        ManageUsers form = new ManageUsers(sendere);
                        form.Show();
                        this.Hide();
                    }
                }


            }


        }
    }
}
