using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Classes.Common
{
    public class Connection
    {
        public static readonly string config = "server=127.0.0.1;port=3306;uid=root;pwd=;database=kino;";

        public MySqlConnection OpenConnection() {
            MySqlConnection connection = new MySqlConnection();
            connection.Open();

            return connection;
        }
        public MySqlDataReader Query(string SQL, MySqlConnection connection)
        {
            return new MySqlCommand(SQL, connection).ExecuteReader();
        }
        public void CloseConnection(MySqlConnection connection)
        {
            connection.Close();
            MySqlConnection.ClearPool(connection);
        }
    }
}
