using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class User
    {
        //properties
        private ConnectionUser datauser = new ConnectionUser();

        public string Username;
        public string Password;

        public string Email;

        public int PhoneNum;
        public int AdminStatus;

        public int ID;

        public byte[] img;

        public User() { }

        //constructor
        public User(string _username, string _password, string _email, int _phoneNum, int _adminStatus, byte[] img)
        {
            this.Username = _username;
            this.Password = _password;
            this.Email = _email;
            this.PhoneNum = _phoneNum;
            this.AdminStatus = _adminStatus;
            this.ID = 0;
            this.img = null;
        }


        //methods
        public string getUsername() { return this.Username; }

        public int getID() { return this.ID; } 

        public bool CreateUser()
        {
            List<string> names = datauser.GetUsername();
            if (names.Contains(this.Username))
            {
                MessageBox.Show("This username is taken");
                return false;
            }
            else
            {
                ID = datauser.InsertUser(this);
                MessageBox.Show("User created!");
                return true;
            }
        }
        public bool UserExist()
        {
            List<int> ids = datauser.GetIDs();
            if (!ids.Contains(ID))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool UpdateUser()
        {
            bool decide = UserExist();
            if (decide)
            {
                datauser.UpdateUser(this);
                return true;
            }
            else
            {
                MessageBox.Show("This user does not exist in the database. Check the user ID.");
                return false;
            }
        }

        public int UpdatePassword()
        {
            int num = datauser.UpdatePassword(this);
            return num;
        }

        public bool DeleteUser()
        {
            datauser.DeleteUser(this);
            return true;
        }

        public User Login(string username, string password)
        {
            User user = datauser.Login(username, password);
            return user;
        }

        public int UploadPFP(byte[] img)
        {
            int num = datauser.SetPFP(this, img);
            MessageBox.Show("Profile picture uploaded!");
            return num;
        }

        public byte[] GetPFP()
        {
            img = datauser.GetPFP(this);
            return img;
        }
    }
}
