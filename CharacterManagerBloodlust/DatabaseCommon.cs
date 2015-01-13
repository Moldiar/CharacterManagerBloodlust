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
            string server = "sql3.freesqldatabase.com";
            string database = "sql363503";
            string uid = "sql363503";
            string password = "kT4!rC1*";
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
    }
}
