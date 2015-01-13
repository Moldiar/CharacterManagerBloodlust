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
    public partial class LoginScreen : Form
    {
        DatabaseCommon dc = new DatabaseCommon();

        public LoginScreen()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            WindowInit winInit = new WindowInit();

            winInit.CreateAccWin(this);
        }

        private void LoginScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private bool LoggingIn()
        {
            string login=LoginBox.Text;
            string password=PasswordBox.Text;
            string pass="";
            MySqlConnection conn = dc.EstablishConn();

            string query = "SELECT `AccountPassword` FROM `Account` WHERE `AccountLogin`='"+login+"';";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                pass = reader.GetString(0);
            }
            reader.Close();
            conn.Close();
            if (pass == password)
            {

                return true;
            }
            else
            {
                return false;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LoggingIn())
            {
                WindowInit winInit = new WindowInit();

                MySqlConnection conn = dc.EstablishConn();
                string AccName = "";
                string query = "SELECT `AccountName` FROM `Account` WHERE `AccountLogin`='" + LoginBox.Text + "';";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    AccName = reader.GetString(0);
                }

                winInit.MainWin(this,AccName);
            }
            else
            {
                MessageBox.Show("Wrong Login and/or Password","Failed to Login",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
    }
}
