using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace CharacterManagerBloodlust
{
    public partial class MainWindow : Form
    {
        List<string> read = new List<string>();

        DatabaseCommon dc = new DatabaseCommon();
        WindowInit wi = new WindowInit();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = dc.EstablishConn();
            string query = "SELECT * FROM `AccType`;";
            MySqlCommand cmd = new MySqlCommand(query,conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                CharacterList.Items.Add(reader.GetString(1));
            }
            
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewScenario();
        }

        private bool NewScenario()
        {
            int AccID=GetAccID();
            string[] scenario=GetScenarioData();
            string ScenarioName = scenario[0];
            string ScenarioDesc = scenario[1];

            MySqlConnection conn = dc.EstablishConn();
            try
            {
                string query = "INSERT INTO `Scenario`(`ScenarioName`, `ScenarioDescription`) VALUES ('"+ScenarioName+"','"+ScenarioDesc+"')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();

            AccHasScen(AccID,FindScenarioAgain(ScenarioName));

            //wi.SimpleReload(AccID);

            return true;
        }

        private void AccHasScen(int AccID, int p)
        {
            MySqlConnection conn = dc.EstablishConn();
            try
            {
                string query = "INSERT INTO `Account_has_Scenario`(`AccountID`, `ScenarioID`) VALUES ("+AccID+","+p+")";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private int FindScenarioAgain(string ScenarioName)
        {
            MySqlConnection conn = dc.EstablishConn();
            int ScenarioID = 0;
            try
            {
                string query = "SELECT `ScenarioID` FROM `Scenario` WHERE `ScenarioName`='" + ScenarioName + "';";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ScenarioID = reader.GetInt32(0);
                }
                reader.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            return ScenarioID;
        }

        private string[] GetScenarioData()
        {
            SmallForms.ScenarioDialog sd = new SmallForms.ScenarioDialog();
            string[] x = new string[2];

            if (sd.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                x[0] = sd.ScenarioName.Text;
                x[1] = sd.ScenarioDesc.Text;
            }
            else
            {
                return null;
            }
            sd.Dispose();
            return x;
        }

        private int GetAccID()
        {
            MySqlConnection conn = dc.EstablishConn();
            int AccID = 0;
            try
            {
                string query = "SELECT `AccountID` FROM `Account` WHERE `AccountName`='" + UsernameLabel.Text + "';";
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
            conn.Close();
            return AccID;
        }
        private int GetAccType()
        {
            MySqlConnection conn = dc.EstablishConn();
            int AccType = 0;
            try
            {
                string query = "SELECT `AccountType` FROM `Account` WHERE `AccountName`='" + UsernameLabel.Text + "';";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    AccType = reader.GetInt32(0);
                }
                reader.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            return AccType;
        }

    }
}
