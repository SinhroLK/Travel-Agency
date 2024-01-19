using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.GuiController
{
    public class LoginGuiController
    {
        private static LoginGuiController instance;
        public static LoginGuiController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoginGuiController();
                }
                return instance;
            }
        }
        private LoginGuiController()
        {
        }

        private FrmLogin frmLogin;

        internal void ShowFrmLogin()
        {
            Communication.Instance.Connect();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin = new FrmLogin();
            frmLogin.AutoSize = true;
            Application.Run(frmLogin);
        }

        public void Login(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
