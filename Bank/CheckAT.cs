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
    public partial class CheckAT : Form
    {
        User LoggedUser = new User();
        AutoTransferConnection atdata = new AutoTransferConnection();
        public CheckAT(User user)
        {
            InitializeComponent();
            LoggedUser = user;
            populatetransfer();
        }

        private void populatetransfer()
        {
            Account acc = new Account();
            DataSet dsv = atdata.GetAutoTransfers(LoggedUser, acc);
            try
            {
                ATView.DataSource = dsv.Tables[0];
            }
            catch (Exception ex)
            {

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageUsers form = new ManageUsers(LoggedUser);
            form.Show();
            this.Hide();
        }
    }
}
