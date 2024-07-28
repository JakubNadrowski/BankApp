using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class AutoTransferConnection : ConnectionClass
    {
        public int InsertAutoTransfer(AutoTransferClass at)
        {
            string query = "INSERT INTO `AutoPay`(`frequency`, `startDate`, `endDate`, `last_transfer`, `amount`, `senderNum`, `recipientNum`)" +
                $" VALUES ('{at.frequency}', (CURRENT_TIMESTAMP()), DATE_ADD((CURRENT_TIMESTAMP()), INTERVAL {at.frequencyNum} DAY), (CURRENT_TIMESTAMP()), '{at.amount}','{at.Sender}', '{at.Recipient}')";
            return Insert(query);
        }

        public int UpdateAutoTransfer(int ID)
        {
            string query = $"UPDATE `AutoPay` SET `last_transfer`= CURRENT_DATE() WHERE ID = '{ID}'";
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

        public int DeleteAutoTransfer(int ID)
        {
            string query = $"DELETE FROM `AutoPay` WHERE ID = '{ID}'";
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

        public DataSet GetAutoTransfers(User user, Account account)
        {
            string accounts = account.AccountString(user);
            string query = $"SELECT * FROM `AutoPay` WHERE senderNum in ({accounts})";
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter(query, connection);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(sda);
                var ds = new DataSet();
                if (accounts == "")
                {
                    return ds;
                }
                else
                {
                    sda.Fill(ds);
                    return ds;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            
        }
        public int CheckAutoTransfers(User userer, Account acc)
        {
            string accstring = acc.AccountString(userer);
            string query = $"SELECT ID, frequency, last_transfer, endDate, amount, senderNum, recipientNum FROM `AutoPay` WHERE senderNum in ({accstring})";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand commandDB = new MySqlCommand(query, conn);
            conn.Open();
            var reader = commandDB.ExecuteReader();
            while (reader.Read())
            {
                AutoTransferClass at = new AutoTransferClass();
                int ID = reader.GetInt32(0);
                at.frequency = reader.GetString(1);
                DateTime last_transfer = reader.GetDateTime(2);
                DateTime endDate = reader.GetDateTime(3);
                at.amount = reader.GetInt32(4);
                at.Sender = reader.GetInt32(5);
                at.Recipient = reader.GetInt32(6);
                at.CheckAutos(last_transfer, endDate, ID);
            }
            return 1;
        }
    }
}
