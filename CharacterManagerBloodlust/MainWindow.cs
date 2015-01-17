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

        public MainWindow()
        {
            InitializeComponent();
        }

        //
        //Buttons
        //

        private void button1_Click(object sender, EventArgs e)
        {
            ScenarioBox.Items.Clear();
            SimpleScenarioReload(GetAccID());
            button7_Click(sender,e);
            button8_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = dc.EstablishConn();
            string query = "SELECT * FROM `AccType`;";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                CharacterList.Items.Add(reader.GetString(1));
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewScenario();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NewHero();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NewScenarioEntry();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NewJournalEntry();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FlowView.Items.Clear();
            LoadScenarioEntries();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            JournalView.Items.Clear();
            LoadJournalEntries();
        }

        //
        //Form Options
        //

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        //
        //Functions
        //

        /// <summary>
        /// Metoda do dodania nowego scenariusza
        /// </summary>
        /// <returns></returns>
        private bool NewScenario()
        {
            int AccID=GetAccID();
            string[] scenario=GetScenarioData();
            if (scenario[0] == null || scenario[1] == null) return false;
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

            ScenarioBox.Items.Clear();
            SimpleScenarioReload(AccID);

            return true;
        }

        /// <summary>
        /// Metoda do ponownego załadowania listy scenariuszy w comboboxie
        /// </summary>
        /// <returns></returns>
        public void SimpleScenarioReload(int AccID)
        {
            HashSet<string> combo = new HashSet<string>();
            MySqlConnection conn = dc.EstablishConn();
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
                ScenarioBox.Items.Add(c);
            ScenarioBox.SelectedIndex = ScenarioBox.Items.Count - 1;
        }

        /// <summary>
        /// Metoda do dodania odwołania w tablicy Account_has_Scenario w celu powiązania scenariusza z kontem
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Metoda do ponownego wyszukania wcześniej dodanego scenariusza by pozyskać jego ID
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Metoda do pozyskania informacji na temat scenariusza od użytownika
        /// </summary>
        /// <returns></returns>
        private string[] GetScenarioData()
        {
            SmallForms.ScenarioDialog sd = new SmallForms.ScenarioDialog();
            string[] x = new string[2];

            if (sd.ShowDialog(this) == DialogResult.OK)
            {
                x[0] = sd.ScenarioName.Text;
                x[1] = sd.ScenarioDesc.Text;
            }
            else
            {
                x[0] = null;
                x[1] = null;
            }
            sd.Dispose();
            return x;
        }

        /// <summary>
        /// Metoda do pozyskania ID konta na podstawie Nazwy użytkownika po zalogowaniu
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Metoda do pozyskania typu konta na podstawie Nazwy użytkownika po zalogowaniu
        /// </summary>
        /// <returns></returns>
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
        
        private bool NewScenarioEntry()
        {
            int ScenID = GetScenID();
            string[] flow = GetEntryData();
            if (flow[0] == null || flow[1] == null) return false;
            string EntryNumber = flow[0];
            string EntryDesc = flow[1];

            MySqlConnection conn = dc.EstablishConn();
            try
            {
                string query = "INSERT INTO `Flow`(`FlowScenario`, `FlowContent`, `FlowOrderNumber`) VALUES ("+ScenID+",'"+EntryDesc+"',"+EntryNumber+")";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();

            FlowView.Items.Clear();
            LoadScenarioEntries();

            return true;
        }

        private int GetScenID()
        {
            MySqlConnection conn = dc.EstablishConn();
            int ScenID = 0;
            try
            {
                string query = "SELECT `ScenarioID` FROM `Scenario` WHERE `ScenarioName`='" + ScenarioBox.Text + "';";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ScenID = reader.GetInt32(0);
                }
                reader.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            return ScenID;
        }

        private string[] GetEntryData()
        {
            SmallForms.FlowDialog fd = new SmallForms.FlowDialog();
            string[] x = new string[2];

            if (fd.ShowDialog(this) == DialogResult.OK)
            {
                x[0] = fd.EntryNumberBox.Text;
                x[1] = fd.EntryDescBox.Text;
            }
            else
            {
                x[0] = null;
                x[1] = null;
            }
            fd.Dispose();
            return x;
        }

        private void LoadScenarioEntries()
        {
            int ScenID = GetScenID();

            MySqlConnection conn = dc.EstablishConn();

            string query = "SELECT `FlowOrderNumber`, `FlowContent` FROM `Flow` WHERE `FlowScenario`="+ScenID+";";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string[] row = { reader.GetInt32(0).ToString(), reader.GetString(1)};
                var lvi = new ListViewItem(row);
                FlowView.Items.Add(lvi);
            }
            conn.Close();
            reader.Close();
        }

        private void LoadJournalEntries()
        {
            int ScenID = GetScenID();

            MySqlConnection conn = dc.EstablishConn();

            string query = "SELECT `JournalName`, `JournalDescription`, `JournalDate`, `JournalImportance` FROM `Journal` WHERE `JournalScenario`="+ScenID+";";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string[] row = { reader.GetString(0), reader.GetString(1), reader.GetDateTime(2).ToString(), reader.GetInt32(3).ToString() };
                var lvi = new ListViewItem(row);
                JournalView.Items.Add(lvi);
            }
            conn.Close();
            reader.Close();
        }

        private string[] GetJournalData()
        {
            SmallForms.JournalDialog fd = new SmallForms.JournalDialog();
            string[] x = new string[3];

            if (fd.ShowDialog(this) == DialogResult.OK)
            {
                x[0] = fd.JournalNameBox.Text;
                x[1] = fd.JournalDescBox.Text;
                x[2] = fd.ImportanceBox.Text;
            }
            else
            {
                x[0] = null;
                x[1] = null;
                x[2] = null;
            }
            fd.Dispose();
            return x;
        }

        private bool NewJournalEntry()
        {
            int ScenID = GetScenID();
            string[] Jour = GetJournalData();
            if (Jour[0] == null || Jour[1] == null || Jour[2] == null) return false;
            string JournalName = Jour[0];
            string JournalDesc = Jour[1];
            string JournalImportance = Jour[2];
            int imp = 0;

            switch (JournalImportance)
            {
                case "Unimportant": { imp = 1; break; }
                case "Trivial": { imp = 2; break; }
                case "Neutral": { imp = 3; break; }
                case "Important": { imp = 4; break; }
                case "Critical": { imp = 5; break; }
            }

            DateTime theDate = DateTime.Now;

            MySqlConnection conn = dc.EstablishConn();
            try
            {
                string query = "INSERT INTO `Journal`(`JournalScenario`, `JournalName`, `JournalDescription`, `JournalDate`, `JournalImportance`) VALUES (" + ScenID + ",'" + JournalName + "','" + JournalDesc + "','" + theDate.ToString("yyyy-MM-dd H:mm:ss") + "'," + imp + ")";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();

            JournalView.Items.Clear();
            LoadJournalEntries();

            return true;
        }

        private bool NewHero()
        {
            string[] scenario = GetHeroData();
            if (scenario[0] == null || scenario[1] == null) return false;
            string ScenarioName = scenario[0];
            string ScenarioDesc = scenario[1];

            MySqlConnection conn = dc.EstablishConn();
            try
            {
                string query = "INSERT INTO `Scenario`(`ScenarioName`, `ScenarioDescription`) VALUES ('" + ScenarioName + "','" + ScenarioDesc + "')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();

            return true;
        }

        private string[] GetHeroData()
        {
            SmallForms.HeroDialog sd = new SmallForms.HeroDialog();
            string[] x = new string[9];

            if (sd.ShowDialog(this) == DialogResult.OK)
            {
                x[0] = sd.NameBox.Text;
                x[1] = sd.SurnameBox.Text;
                if (sd.MaleRadio.Checked) x[2] = "Male"; 
                else x[2] = "Female";
                x[3] = sd.AlignmentBox.Text;
                x[4] = sd.SubraceBox.SelectedItem.ToString();
                x[5] = sd.GodBox.SelectedItem.ToString();
                x[6] = sd.ZodiacView.SelectedItems.ToString();
                x[7] = sd.PathTreeView.SelectedNode.Text;
                x[8] = sd.BloodlineBox.SelectedItem.ToString();
            }
            else
            {
                x[0] = null;
                x[1] = null;
                x[2] = null;
                x[3] = null;
                x[4] = null;
                x[5] = null;
                x[6] = null;
                x[7] = null;
                x[8] = null;
            }
            sd.Dispose();
            return x;
        }

    }
}
