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
    public partial class HeroDialog : Form
    {
        DatabaseCommon dc = new DatabaseCommon();

        public HeroDialog()
        {
            InitializeComponent();
        }

        private void InitAll(object sender, EventArgs e)
        {
            PrepareAlignment();
            PrepareRace();
            PrepareSubrace();
            PreparePantheon();
            PrepareGod(sender,e);
            PrepareZodiac();
            PreparePath();
            //PrepareBloodline();
        }

        private void PreparePath()
        {
            List<string> paths = new List<string>();
            List<string> temp = new List<string>();
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();

            string query = "SELECT `PathName` FROM `Path`";
            MySqlDataReader reader = dc.ReadQuery(query);
            while (reader.Read())
            {
                paths.Add(reader.GetString(0));
            }

            foreach (string p in paths)
            {
                query = "SELECT DISTINCT `PathName` FROM `Path`,`pathoforigins` WHERE `PathID`IN(SELECT `Path_Pathoforigin` FROM `pathoforigins` WHERE `Path_PathID`IN(SELECT `PathID` FROM `Path` WHERE `PathName`='"+p+"'))";
                reader = dc.ReadQuery(query);
                while (reader.Read())
                {
                    temp.Add(reader.GetString(0));
                }
                dic.Add(p, temp);
            }
        }
        private void PrepareGod(object sender, EventArgs e)
        {
            GodBox.Items.Clear();
            HashSet<string> sr = new HashSet<string>();

            MySqlConnection conn = dc.EstablishConn();
            string query = "SELECT DISTINCT `GodName` FROM `God`,`Pantheon` WHERE `GodPantheon`=(SELECT `PantheonID` FROM `Pantheon` WHERE `PantheonName`='" + PantheonBox.SelectedItem.ToString() + "');";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                sr.Add(reader.GetString(0));
            }
            foreach (string s in sr)
                GodBox.Items.Add(s);
            GodBox.SetSelected(0, true);
        }

        private void PreparePantheon()
        {
            PantheonBox.Items.Clear();

            MySqlConnection conn = dc.EstablishConn();
            string query = "SELECT * FROM `Pantheon`;";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                PantheonBox.Items.Add(reader.GetString(1));
            }

            PantheonBox.SetSelected(0, true);
        }

        private void PrepareZodiac()
        {
            ZodiacView.Items.Clear();
            HashSet<string> sr = new HashSet<string>();

            MySqlConnection conn = dc.EstablishConn();
            string query = "SELECT * FROM `Zodiac`;";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                sr.Add(reader.GetString(1));
            }
            foreach (string s in sr)
                ZodiacView.Items.Add(s);
            
        }

        private void PrepareSubrace()
        {
            SubraceBox.Items.Clear();
            HashSet<string> sr = new HashSet<string>();

            MySqlConnection conn = dc.EstablishConn();
            string query = "SELECT DISTINCT `SubraceName` FROM `Race`,`Subrace` WHERE `SubraceRace`=(SELECT `RaceID` FROM `Race` WHERE `RaceName`='" + RaceBox.SelectedItem.ToString() + "');";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                sr.Add(reader.GetString(0));
            }
            foreach (string s in sr)
                SubraceBox.Items.Add(s);
            SubraceBox.SetSelected(0, true);

            RaceDesc();
        }

        private void PrepareRace()
        {
            RaceBox.Items.Clear();

            MySqlConnection conn = dc.EstablishConn();
            string query = "SELECT * FROM `Race`;";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                RaceBox.Items.Add(reader.GetString(1));
            }

            RaceBox.SetSelected(0,true);
        }

        private void RaceDesc()
        {
            MySqlConnection conn = dc.EstablishConn();
            string query = "SELECT CONCAT(`RaceDescription`,`SubraceDescription`) FROM `Race`,`Subrace` WHERE `RaceName`='" + RaceBox.SelectedItem.ToString() + "' AND `SubraceName`='"+SubraceBox.SelectedItem.ToString()+"';";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                DescBox.Text=(reader.GetString(0));
            }
        }

        private void RaceClick(object sender, EventArgs e)
        {
            PrepareSubrace();
            RaceDesc();
        }

        private void PrepareAlignment()
        {
            string[] align = {"Good","Neutral","Evil"};

            AlignmentBox.Items.Clear();

            foreach (string a in align)
            {
                AlignmentBox.Items.Add(a);
            }
            AlignmentBox.SelectedIndex = AlignmentBox.Items.Count - 2;
        }

        private void SubraceClick(object sender, EventArgs e)
        {
            RaceDesc();
        }
    }
}


/*
 List<int[]> iT = new List<int[]>();
            int[] x =new int[2];

            List<string[]> names = new List<string[]>();
            string[] y = new string[2];

            TreeNode pn,cpn;

            string query = "SELECT * FROM `pathoforigins`";
            MySqlDataReader reader=dc.ReadQuery(query);
            while (reader.Read())
            {
                x[0] = reader.GetInt32(0);
                x[1] = reader.GetInt32(0);
                iT.Add(x);
            }
            foreach (int[] z in iT)
            {
                query = "SELECT `PathName` FROM `Path` WHERE `PathID`="+z[0]+";";
                reader = dc.ReadQuery(query);
                while (reader.Read())
                {
                    y[0] = reader.GetString(0);
                }

                if (z[1] != 0)
                {
                    query = "SELECT `PathName` FROM `Path` WHERE `PathID`=" + z[1] + ";";
                    reader = dc.ReadQuery(query);
                    while (reader.Read())
                    {
                        y[1] = reader.GetString(0);
                    }
                }
                else y[1] = null;
                names.Add(y);
            }
            foreach (string[] s in names)
            {
                pn = new TreeNode();
                cpn = new TreeNode();
                PathTreeView.Nodes.Add(pn);
            }
 */