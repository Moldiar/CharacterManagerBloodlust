using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterManagerBloodlust.Types
{
    class Scenario
    {
        DatabaseCommon dc = new DatabaseCommon();

        public int ID { get; set; }
        public int AccountID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Scenario()
        { }
        public Scenario(int ScenID)
        {
            try
            {
                string query = @"SELECT 
                                    `scenario`.`ScenarioID`,
                                    `scenario`.`ScenarioName`,
                                    `scenario`.`ScenarioDescription`
                                FROM 
                                    `cmb`.`scenario`
                                WHERE 
                                    `scenario`.`ScenarioID`=" + ScenID + ";";
                MySqlDataReader reader = dc.ReadQuery(query);
                while (reader.Read())
                {
                    this.ID = reader.GetInt32(0);
                    this.AccountID = GetAccountID(reader.GetInt32(0));
                    this.Name = reader.GetString(1);
                    this.Description = reader.GetString(2);

                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Scenario(string ScenName)
        {
            try
            {
                string query = @"SELECT 
                                    `scenario`.`ScenarioID`,
                                    `scenario`.`ScenarioName`,
                                    `scenario`.`ScenarioDescription`
                                FROM 
                                    `cmb`.`scenario`
                                WHERE 
                                    `scenario`.`ScenarioName`='" + ScenName + "';";
                MySqlDataReader reader = dc.ReadQuery(query);
                while (reader.Read())
                {
                    this.ID = reader.GetInt32(0);
                    this.AccountID = GetAccountID(reader.GetInt32(0));
                    this.Name = reader.GetString(1);
                    this.Description = reader.GetString(2);

                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<Scenario> ByAccountID(int AccID)
        {
            List<Scenario> list = new List<Scenario>();
            try
            {
                string query = 
                                @"SELECT   
		                            `scenario`.`ScenarioID`,
                                    `scenario`.`ScenarioName`,
                                    `scenario`.`ScenarioDescription`
                                FROM 
		                            `cmb`.`scenario`
                                INNER JOIN
                                    `cmb`.`account_has_scenario`  
                                ON 
		                            `scenario`.`scenarioid`=`account_has_scenario`.`scenarioid`
                                AND		
                                    `account_has_scenario`.`accountid`=" + AccID + ";";
                MySqlDataReader reader = dc.ReadQuery(query);
                while (reader.Read())
                {
                    Scenario temp = new Scenario();
                    temp.ID = reader.GetInt32(0);
                    temp.AccountID = AccID;
                    temp.Name = reader.GetString(1);
                    temp.Description = reader.GetString(2);
                    list.Add(temp);
                    //Lista odwołuje się do jednostki pamięci. 
                    //Poprawić tak by wartości listy były przekazane dalej 
                    //zanim dojdzie do zamiany miejsc z następnym wpisem.
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return list;
        }

        private int GetAccountID(int x)
        {
            try
            {
                string query = @"SELECT 
                                    `account_has_scenario`.`AccountID`
                                FROM 
                                    `cmb`.`account_has_scenario`
                                WHERE
                                    `account_has_scenario`.`ScenarioID`="+x+";";
                MySqlDataReader reader = dc.ReadQuery(query);
                while (reader.Read())
                {
                    x = reader.GetInt32(0);
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return x;
        }
    }
}
