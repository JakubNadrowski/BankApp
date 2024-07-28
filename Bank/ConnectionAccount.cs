using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class ConnectionAccount : ConnectionClass
    {

        public DataSet GetAccounts(User user)
        {
            string query = $"SELECT `AccountNum`,`Balance`,`Name` FROM `Account` WHERE UserID = {user.ID}";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, connection);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }

        public List<int> GetUsersAccounts(User user)
        {
            List<int> usersAccounts = new List<int>();
            string query = $"SELECT `AccountNum`,`Balance`,`Name` FROM `Account` WHERE UserID = {user.ID}";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand commandDB = new MySqlCommand(query, conn);
            conn.Open();
            var reader = commandDB.ExecuteReader();
            while (reader.Read())
            {
                usersAccounts.Add(reader.GetInt32(0));
            }
            conn.Close();
            return usersAccounts;
        }


        public int CreateAccount(User user, Account account)
        {
            string query = "INSERT INTO `Account` (`AccountNum`, `UserID`, `Balance`, `Name`)" +
                $" VALUES ('{account.AccountNum}','{user.ID}','0','{account.Name}')";
            return Insert(query);
        }

        public List<int> GetAccountIDs()
        {
            List<int> ids = new List<int>();
            string query = "SELECT AccountNum FROM Account";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand commandDB = new MySqlCommand(query, conn);
            conn.Open();
            var reader = commandDB.ExecuteReader();
            while (reader.Read())
            {
                ids.Add(reader.GetInt32(0));
            }
            conn.Close();
            return ids;
        }

        public int GetBalance(Account account)
        {
            string query = $"SELECT Balance FROM Account WHERE AccountNum = {account.AccountNum}";
            int balance = 0 ;
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand commandDB = new MySqlCommand(query, conn);
            conn.Open();
            var reader = commandDB.ExecuteReader();
            while (reader.Read())
            {
               balance = reader.GetInt32(0);
            }
            conn.Close();
            return balance;
        }

        public int UpdateBalance (Account account)
        {
            string query = $"UPDATE `Account` SET `Balance` = '{account.Balance}' WHERE `Account`.`AccountNum` = {account.AccountNum}; ";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand commandDB = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                int result = commandDB.ExecuteNonQuery();

                return (int)commandDB.LastInsertedId;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return -1;
        }
        
    }
}
