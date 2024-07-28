using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Collections;
using MySqlConnector;

namespace Bank
{
    public partial class ManageUsers2 : Form
    {

        private ConnectionUser datauser = new ConnectionUser();
        private User user = new User();
        private User admin = new User();
        private void populate()
        {
            DataSet dsv = datauser.GetUsers();
            userView.DataSource = dsv.Tables[0];
        }
        public ManageUsers2(User user)
        {
            InitializeComponent();
            admin = user;
            populate();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void userView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MngUserID.Text = userView.SelectedRows[0].Cells[0].Value.ToString();
            MngUserUsrName.Text = userView.SelectedRows[0].Cells[1].Value.ToString();
            MngUserPassword.Text = userView.SelectedRows[0].Cells[2].Value.ToString();
            MngUserEmail.Text = userView.SelectedRows[0].Cells[3].Value.ToString();
            MngUserPhoneNum.Text = userView.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            if (MngUserID.Text != "")
            {
                if (MngUserID.Text == admin.ID.ToString())
                {
                    MessageBox.Show("You're trying to delete yourself admin, don't do that");
                }
                else
                {
                    user.ID = Convert.ToInt32(MngUserID.Text);
                    bool decide = user.UserExist();
                    if (decide)
                    {
                        user.DeleteUser();
                        populate();
                    }
                    else
                    {
                        MessageBox.Show("This user does not exist in the database. Check the user ID.");
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Please enter the user ID you want to delete.");
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            if (MngUserID.Text != "")
            {
                user.ID = Convert.ToInt32(MngUserID.Text);
                bool decide = user.UserExist();
                if (decide)
                {
                    if (MngUserUsrName.Text == "" || MngUserPassword.Text == "" || MngUserEmail.Text == "" || MngUserPhoneNum.Text == "" || comboBox1.SelectedItem == null)
                    {
                        MessageBox.Show("Missing data, check that all boxes are filled.");
                    }
                    else
                    {
                        user.Username = MngUserUsrName.Text; user.Password = MngUserPassword.Text; user.Email = MngUserEmail.Text; user.PhoneNum = Convert.ToInt32(MngUserPhoneNum.Text); user.AdminStatus = Convert.ToInt32(comboBox1.Text);
                        user.UpdateUser();
                        MessageBox.Show("User updated!");
                        populate();

                    }

                }
                else
                {
                    MessageBox.Show("This user does not exist in the database. Check the user ID.");
                }
            }
            else
            {
                MessageBox.Show("Please fill the boxes properly.");
            }
            
        }

        private void label9_Click(object sender, EventArgs e)
        {
            user.ID = Convert.ToInt32(MngUserID.Text);
            bool decide = user.UserExist();
            if (!decide)
            {
                if (MngUserUsrName.Text == "" || MngUserPassword.Text == "" || MngUserEmail.Text == "" || MngUserPhoneNum.Text == "" || comboBox1.Text == "")
                {
                    MessageBox.Show("Missing data, check that all boxes are filled.");
                }
                else
                {
                    User user = new User();
                    user.Username = MngUserUsrName.Text; user.Password = MngUserPassword.Text; user.Email = MngUserEmail.Text; user.PhoneNum = Convert.ToInt32(MngUserPhoneNum.Text); user.AdminStatus = Convert.ToInt32(comboBox1.Text);
                    user.ID = Convert.ToInt32(MngUserID.Text);
                    user.CreateUser();
                    populate();
                    
                }

            }
            else
            {
                MessageBox.Show("This user exists in the database. Select a unique ID.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
