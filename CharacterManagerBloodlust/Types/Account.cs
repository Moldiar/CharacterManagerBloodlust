using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterManagerBloodlust.Types
{
    class Account
    {
        DatabaseCommon dc = new DatabaseCommon();

        public int ID { get; set; }
        public string Name { get; set; }
        public string AccountType { get; set; }

        public Account(int ID)
        {
            try
            {
                string query = @"SELECT 
                                    `account`.`AccountID`,
                                    `account`.`AccountName`,
                                    `account`.`AccountType`
                                FROM 
                                    `cmb`.`account`
                                WHERE 
                                    `account`.`AccountID`=" + ID + ";";
                MySqlDataReader reader = dc.ReadQuery(query);
                while (reader.Read())
                {
                    this.ID = reader.GetInt32(0);
                    this.Name = reader.GetString(1);
                    this.AccountType = GetAccountType(reader.GetInt32(2));
                    
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Account(string username)
        {
            try
            {
                string query = @"SELECT 
                                    `account`.`AccountID`,
                                    `account`.`AccountName`,
                                    `account`.`AccountType`
                                FROM 
                                    `cmb`.`account`
                                WHERE 
                                    `account`.`AccountName`='" + username + "';";
                MySqlDataReader reader = dc.ReadQuery(query);
                while (reader.Read())
                {
                    this.ID = reader.GetInt32(0);
                    this.Name = reader.GetString(1);
                    this.AccountType = GetAccountType(reader.GetInt32(2));

                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string GetAccountType(int x)
        {
            string z = "";
            try
            {
                string query = "SELECT `AccTypeName` FROM `AccType` WHERE `AccTypeID`='" + x + "';";
                MySqlDataReader reader = dc.ReadQuery(query);
                while (reader.Read())
                {
                    z = reader.GetString(0);
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return z;
        }
    }
}
