using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterManagerBloodlust
{
    class DatabaseCommon
    {
        public MySqlConnection EstablishConn()
        {
            string server = "localhost";
            string database = "cmb";
            string uid = "Moldiar";
            string password = "Starter0";
            string connectionString;
            MySqlConnection conn;
            connectionString = "SERVER=" + server + "; PORT = 3306 ;" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
                conn.Open();
                conn.Ping();
                return conn;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public MySqlDataReader ReadQuery(string query)
        {
            MySqlConnection conn = EstablishConn();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            conn.Close();
            return reader;
        }
    }
}
