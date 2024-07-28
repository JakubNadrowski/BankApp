using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Collections;
using System.Data;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Bank
{
    class ConnectionClass
    {

        public string connection =
            "datasource=ID386613_JBCorp.db.webhosting.be;" +
            "port=3306;" +
            "username=ID386613_JBCorp;" +
            "password=JBCorpAdmin02;" +
            "database=ID386613_JBCorp;";

        public int Insert(string query)
        {
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
                Console.WriteLine(ex.Message);
            }
            return -1;
        }

       
        

      


    }
}
