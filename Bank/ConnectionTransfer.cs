using Microsoft.VisualBasic.ApplicationServices;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class ConnectionTransfer : ConnectionClass
    {
        public int InsertTransfer(Transfer transfer)
        {
            string query = "INSERT INTO `Transfer`(`Sender`, `Recipient`, `Date`, `Amount`, `Auto`)" +
                $"VALUES ('{transfer.sender}','{transfer.recipient}','{transfer.date}','{transfer.amount}', '{transfer.Auto}')";
            return Insert(query);
        }

        public DataSet GetTransfers(User user, Account account) 
        {
            string accounts = account.AccountString(user);
            string query = $"SELECT `sender`,`recipient`,`Amount`, `Date` FROM `Transfer` WHERE recipient in ({accounts}) OR sender in ({accounts})";
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


    }
}
