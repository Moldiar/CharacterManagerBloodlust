using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterManagerBloodlust.SmallForms
{
    public partial class PlayerInviteDialog : Form
    {
        DatabaseCommon dc = new DatabaseCommon();
        MainWindow mw = new MainWindow();
        private string p;

        public PlayerInviteDialog()
        {
            InitializeComponent();
        }

        public PlayerInviteDialog(string p)
        {
            InitializeComponent();
            this.p = p;
        }

        private void InitAll(object sender, EventArgs e)
        {
            LoadPlayers();
            LoadScenarios();
        }

        private void LoadScenarios()
        {
            string query = "Select scenarioname from scenario where scenarioid in (select ScenarioID from account_has_scenario where AccountID in(select AccountID from account where accountname='"+p+"'));";
            MySqlDataReader reader = dc.ReadQuery(query);
            while (reader.Read())
            {
                ScenarioList.Items.Add(reader.GetString(0));
            }
        }

        private void LoadPlayers()
        {
            string query = "Select accountname from account where accounttype=3";
            MySqlDataReader reader = dc.ReadQuery(query);
            while (reader.Read())
            {
                PlayerList.Items.Add(reader.GetString(0));
            }
        }
    }
}
