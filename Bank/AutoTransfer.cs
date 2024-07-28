using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class AutoTransfer : Form
    {
        User LoggedUser = new User();
        Account SenderAcc = new Account();
        Account RecipientAcc = new Account();
        public AutoTransfer(User user)
        {
            InitializeComponent();
            LoggedUser = user;
            foreach (int num in SenderAcc.UsersAccounts(LoggedUser))
            {
                listBox2.Items.Add(num);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem == null) { MessageBox.Show("Please select an account to send money from."); }
            else if (recipientNum.Text == "") { MessageBox.Show("Please enter the account number to send money to."); }
            else if (listBox1.SelectedItem == null) { MessageBox.Show("Please select the frequency of payments."); }
            else
            {
                SenderAcc.AccountNum = Convert.ToInt32(listBox2.SelectedItem.ToString());
                RecipientAcc.AccountNum = Convert.ToInt32(recipientNum.Text);
                if (!RecipientAcc.AccountExist())
                {
                    MessageBox.Show("This recipient doesn't exist");
                }
                else
                {
                    int amount = Convert.ToInt32(Amount.Text);
                    SenderAcc.Balance = SenderAcc.AccountBalance();
                    RecipientAcc.Balance = RecipientAcc.AccountBalance();
                    if (amount > SenderAcc.Balance) { MessageBox.Show("This account's balance is too low, try another account."); }
                    else
                    {
                        SenderAcc.Balance -= amount;
                        RecipientAcc.Balance += amount;
                        SenderAcc.UpdateBalance();
                        RecipientAcc.UpdateBalance();
                        DateTime datetime = DateTime.Now;
                        string date = datetime.ToString("yyyy-MM-dd");
                        Transfer transfer = new Transfer();
                        transfer.sender = SenderAcc.AccountNum; transfer.recipient = RecipientAcc.AccountNum; transfer.date = date; transfer.amount = amount;
                        transfer.CreateTransfer();
                        AutoTransferClass at = new AutoTransferClass();
                        at.frequency = listBox1.SelectedItem.ToString(); at.Sender = SenderAcc.AccountNum; at.Recipient = RecipientAcc.AccountNum;
                        at.amount = amount; at.frequencyNum = Convert.ToInt32(AoT.Text);
                        at.CreateAutoTransfer();
                        MessageBox.Show("Auto Trasnfer created!");
                        ManageUsers form = new ManageUsers(LoggedUser);
                        form.Show();
                        this.Hide();
                    }
                }


            }
        }
    }
}
