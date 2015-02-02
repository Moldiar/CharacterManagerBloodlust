using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterManagerBloodlust.Types
{
    class Hero
    {
        DatabaseCommon dc = new DatabaseCommon();

        public int ID { get; set; }
        public int Scenario { get; set; }
        public int Account { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Sex { get; set; }
        public string Alignment { get; set; }
        public string Race { get; set; }
        public string Subrace { get; set; }
        public string Bloodline { get; set; }
        public string Zodiac { get; set; }
        public string God { get; set; }
        public string Path { get; set; }
        public string Inventory { get; set; }
        public string Notes { get; set; }

        public Hero()
        { }

        public Hero(int ID)
        {
            try
            {
                string query = @"SELECT 
                                `hero`.`HeroID`,
                                `hero`.`HeroScenario`,
                                `hero`.`HeroAccount`,
                                `hero`.`HeroName`,
                                `hero`.`HeroSurname`,
                                `hero`.`HeroSex`,
                                `hero`.`HeroAlignment`,
                                `hero`.`HeroSubrace`,
                                `hero`.`HeroBloodline`,
                                `hero`.`HeroZodiac`,
                                `hero`.`HeroGod`,
                                `hero`.`HeroPath`,
                                `hero`.`HeroInventory`,
                                `hero`.`HeroNotes`
                            FROM 
                                `cmb`.`hero`
                            WHERE 
                                `hero`.`HeroID`=" + ID + ";";
                MySqlDataReader reader = dc.ReadQuery(query);
                while (reader.Read())
                {
                    this.ID = reader.GetInt32(0);
                    this.Scenario = reader.GetInt32(1);
                    this.Account = reader.GetInt32(2);

                    this.Name = reader.GetString(3);
                    this.Surname = reader.GetString(4);
                    if (reader.GetInt32(5) == 1) this.Sex = "Male"; else this.Sex = "Female";
                    this.Alignment = reader.GetString(6);

                    this.Race = GetRace(reader.GetInt32(7));
                    this.Subrace = GetSubrace(reader.GetInt32(7));

                    this.Bloodline = GetBloodline(reader.GetInt32(8));
                    this.Zodiac = GetZodiac(reader.GetInt32(9));
                    this.God = GetGod(reader.GetInt32(10));
                    this.Path = GetPath(reader.GetInt32(11));

                    this.Inventory = reader.GetString(12);
                    this.Notes = reader.GetString(13);
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<Hero> ByAccountID(int AccID,int ScenID)
        {
            List<Hero> heroes = new List<Hero>();
            try
            {
                string query = "SELECT `HeroID` FROM `Hero` WHERE `HeroAccount`='" + AccID + "' && `HeroScenario`='"+ScenID+"';";
                MySqlDataReader reader = dc.ReadQuery(query);
                while (reader.Read())
                {
                    Hero h = new Hero(reader.GetInt32(0));
                    heroes.Add(h);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return heroes;
        }

        private string GetRace(int x)
        {
            string z = "";
            try
            {

                string query = "SELECT DISTINCT `RaceName` FROM `Race`,`Subrace` WHERE `RaceID`=(SELECT `SubraceRace` FROM `subrace` WHERE `SubraceID`=" + x + ")";
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

        private string GetSubrace(int x)
        {
            string z = "";
            try
            {
                string query = "SELECT SubraceName from subrace where subraceid=" + x + ";";
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

        private string GetBloodline(int x)
        {
            string z = "";
            try
            {
                string query = "SELECT BloodlineName from Bloodline where Bloodlineid=" + x + ";";
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

        private string GetZodiac(int x)
        {
            string z = "";
            try
            {
                string query = "SELECT ZodiacName from Zodiac where Zodiacid=" + x + ";";
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

        private string GetGod(int x)
        {
            string z = "";
            try
            {
                string query = "SELECT GodName from God where godid=" + x + ";";
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

        private string GetPath(int x)
        {
            string z = "";
            try
            {
                string query = "SELECT PathName from Path where Pathid=" + x + ";";
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
