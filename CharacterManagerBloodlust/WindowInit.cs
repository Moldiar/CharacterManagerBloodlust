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

        public bool MainWin(Form x)
        {
            x.Hide();
            mainWin.Show();
            return true;
        }
    }
}
