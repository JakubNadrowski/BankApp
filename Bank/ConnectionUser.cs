using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Design;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class ConnectionUser : ConnectionClass
    {
        public int InsertUser(User user)
        {
            string query = "INSERT INTO `User`(`ID`, `Username`, `Password`, `Email`, `PhoneNum`, `AdminStatus`)" +
                $" VALUES ('{user.ID}','{user.Username}','{user.Password}','{user.Email}','{user.PhoneNum}','{user.AdminStatus}')";
            return Insert(query);
        }

        
        public DataSet GetUsers()
        {
            string query = "SELECT * FROM User";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, connection);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }
        public List<string> GetUsername()
        {
            List<string> users = new List<string>();
            string query = "SELECT Username FROM User";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand commandDB = new MySqlCommand(query, conn);
            conn.Open();
            var reader = commandDB.ExecuteReader();
            while (reader.Read())
            {
                users.Add(reader.GetString(0));
            }
            conn.Close();
            return users;
        }

        public List<int> GetIDs()
        {
            List<int> ids = new List<int>();
            string query = "SELECT ID FROM User";
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
        public int DeleteUser(User user)
        {
            string query = $"DELETE FROM `User` WHERE `ID` = {user.ID}";
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

        public int UpdateUser(User user)
        {
            string query = $"UPDATE `User` SET `Username`='{user.Username}',`Password`='{user.Password}',`Email`='{user.Email}',`PhoneNum`='{user.PhoneNum}',`AdminStatus`='{user.AdminStatus}' WHERE `ID` = '{user.ID}'";
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

        public int UpdatePassword(User user)
        {
            string query = $"UPDATE `User` SET `Password`='{user.Password}' WHERE `ID` = {user.ID}";
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

        public User Login(string username, string password)
        {
            string query = $"SELECT * FROM `User` WHERE `Username` = '{username}' AND `Password` = '{password}'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand commandDB = new MySqlCommand(query, conn);
            conn.Open();
            User user = new User();
            var reader = commandDB.ExecuteReader();
            while (reader.Read())
            {
                string UserUsername = reader.GetString(1);
                string UserPass = reader.GetString(2);
                string UserEmail = reader.GetString(3);
                int UserPhoneNum = reader.GetInt32(4);
                int AdminStat = reader.GetInt32(5);
                user = new User(UserUsername, UserPass, UserEmail, UserPhoneNum, AdminStat, null);
                user.ID = reader.GetInt32(0);
             
            }
            return user;
        }

        public int SetPFP(User user, byte[] image)
        {
            string query = $"UPDATE `User` SET `image`='{image}' WHERE ID = '{user.ID}'";
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

        public byte[] GetPFP(User user)
        {
            string query = $"SELECT `image` FROM User WHERE ID = '{user.ID}'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand commandDB = new MySqlCommand(query, conn);
            conn.Open();
            using (var reader = commandDB.ExecuteReader())
            {
                if (!reader.Read())
                {
                    return null;
                }

                const int CHUNK_SIZE = 2 * 1024;
                byte[] buffer = new byte[CHUNK_SIZE];
                long bytesRead;
                long fieldOffset = 0;
                using (var stream = new MemoryStream())
                {
                    while ((bytesRead = reader.GetBytes(reader.GetOrdinal("Image"), fieldOffset, buffer, 0, buffer.Length)) == buffer.Length)
                    {
                        stream.Write(buffer, 0, (int)bytesRead);
                        fieldOffset += bytesRead;
                    }
                    return stream.ToArray();
                }
            }

        }
    }
}
