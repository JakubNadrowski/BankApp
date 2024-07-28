using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bank
{
    public partial class ManageUsers : Form
    {
        User LoggedUser = new User();
        Account acc = new Account();
        AutoTransferConnection at = new AutoTransferConnection();
        public ManageUsers(User user)
        {
            InitializeComponent();
            LoggedUser = user;
            populate();
            populatetransfer();
            if (at.GetAutoTransfers(LoggedUser, acc) != null )
            {
                at.CheckAutoTransfers(LoggedUser, acc);
            }
            else
            {
                
            }
        }


        private ConnectionAccount dataaccount = new ConnectionAccount();
        private ConnectionTransfer datatransfer = new ConnectionTransfer();
        private void populate()
        {
            DataSet dsv = dataaccount.GetAccounts(LoggedUser);
            AccountView.DataSource = dsv.Tables[0];
        }

        private void populatetransfer()
        {
            Account acc = new Account();
            DataSet dsv = datatransfer.GetTransfers(LoggedUser, acc);
            try
            {
                TransferView.DataSource = dsv.Tables[0];
            }
            catch (Exception ex)
            {

            }




        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Check1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(LoggedUser);
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            acc.AccountString(LoggedUser);
            if (MessageBox.Show("Are you sure you want to delete your accout? You're not getting your money back", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                LoggedUser.DeleteUser();
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            };
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateAccount form = new CreateAccount(LoggedUser);
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TransferMoney form = new TransferMoney(LoggedUser);
            form.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddBalance form = new AddBalance(LoggedUser);
            form.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ProfilePic form = new ProfilePic(LoggedUser);
            form.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            byte[] img = LoggedUser.GetPFP();
            MemoryStream stream = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(stream);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AutoTransfer form = new AutoTransfer(LoggedUser);
            form.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CheckAT form = new CheckAT(LoggedUser);
            form.Show();
            this.Hide();

        }
    }
}
