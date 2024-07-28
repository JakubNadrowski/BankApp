using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Account
    {
        private ConnectionAccount dataaccount = new ConnectionAccount();

        public int AccountNum;
        public int UserId;
        public int Balance;
        public string Name;

        public Account() { }
        public Account(int accountNum, int userId, int balance, string name)
        {
            this.AccountNum = accountNum;
            this.UserId = userId;
            this.Name = name;
            this.Balance = balance;
        }

        //methods
        public bool AccountExist()
        {
            List<int> ids = dataaccount.GetAccountIDs();
            if (!ids.Contains(this.AccountNum))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public List<int> UsersAccounts(User user)
        {
            List<int> Accounts = dataaccount.GetUsersAccounts(user);
            return Accounts;
        }

        public string AccountString(User user)
        {
            string accountstring = "";
            foreach (int id in UsersAccounts(user))
            {
                accountstring += id.ToString()+",";
                
            }
            if (accountstring == "")
            {
                return accountstring;
            }
            else
            {
                accountstring = accountstring.Remove(accountstring.Length - 1);
                return accountstring;
            }
            
            
        }



        public bool CreateAccount(User user)
        {
            if (AccountExist())
            {
                MessageBox.Show("This Account Number is taken");
                return false;
            }
            else
            {
                dataaccount.CreateAccount(user, this);
                MessageBox.Show("Account created!");
                return true;
            }
        }

        public int AccountBalance()
        {
            int balance = dataaccount.GetBalance(this);
            return balance;
        }

        public int UpdateBalance()
        {
            int num = dataaccount.UpdateBalance(this);
            return num;
        }

        

    }

}
