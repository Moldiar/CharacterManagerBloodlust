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

namespace CharacterManagerBloodlust
{
    public partial class CreateAccount : Form
    {
        DatabaseCommon dc = new DatabaseCommon();

        public CreateAccount()
        {
            InitializeComponent();
            PopulateAccTypeList();
        }

        private void PopulateAccTypeList()
        {
            MySqlConnection conn = dc.EstablishConn();
            string query = "SELECT * FROM `AccType`;";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                AccTypeBox.Items.Add(reader.GetString(1));
            }
            reader.Close();
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowInit winInit = new WindowInit();

            winInit.LogScrWin(this);
        }

        private void CreateAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CreateAccountDB())
            {
                MessageBox.Show("Account created succesfully!","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                WindowInit winInit = new WindowInit();

                winInit.LogScrWin(this);
            }
        }

        private bool CreateAccountDB()
        {
            string accName = AccNameBox.Text;
            string login = LoginBox.Text;
            string password = PasswordBox.Text;
            string rePassword = RePasswordBox.Text;
            string accType = AccTypeBox.Text;
            int accTypeID=0;

            if(password!=rePassword)
            {
                MessageBox.Show("Passwords don't match!","Fail",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }

            MySqlConnection conn = dc.EstablishConn();
            try
            {
                string query = "SELECT `AccTypeID` FROM `AccType` WHERE `AccTypeName`='" + accType + "';";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    accTypeID = reader.GetInt32(0);
                }
                reader.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                string query = "INSERT INTO `Account`(`AccountName`, `AccountLogin`, `AccountPassword`, `AccountType`) VALUES ('" + accName + "','" + login + "','" + password + "','" + accTypeID + "');";
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

    }
}
