using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterManagerBloodlust
{
    class WindowInit
    {
        CreateAccount crAcc = new CreateAccount();
        LoginScreen logScr = new LoginScreen();
        MainWindow mainWin = new MainWindow();
        DatabaseCommon dc = new DatabaseCommon();

        public bool CreateAccWin(Form x)
        {
            crAcc.Show();
            x.Hide();
            return true;
        }
 
        public bool LogScrWin(Form x)
        {
            x.Hide();
            logScr.Show();
            return true;
        }

        public bool MainWin(Form x,string username)
        {
            mainWin.Show();
            mainWin.UsernameLabel.Text = username;
            mainWin.SettingUp(username);
            //LoadScenarios(username);
            x.Hide();
            return true;
        }

        private void LoadScenarios(string usrname)
        {
            HashSet<string> combo = new HashSet<string>();
            MySqlConnection conn = dc.EstablishConn();
            int AccID = 0;
            try
            {
                string query = "SELECT `AccountID` FROM `Account` WHERE `AccountName`='" + usrname + "';";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    AccID = reader.GetInt32(0);
                }
                reader.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                string query = "SELECT `Scenario`.`ScenarioName` FROM `Account`,`Scenario`,`Account_has_Scenario` WHERE `Account_has_Scenario`.`AccountID`=" + AccID + " && `Scenario`.`ScenarioID`=`Account_has_Scenario`.`ScenarioID`;";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    combo.Add(reader.GetString(0));
                }
                reader.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            foreach (string c in combo)
                mainWin.ScenarioBox.Items.Add(c);
            mainWin.ScenarioBox.SelectedIndex = mainWin.ScenarioBox.Items.Count - 1;

            //mainWin.SetVisibility();
        }
        
    }
}
