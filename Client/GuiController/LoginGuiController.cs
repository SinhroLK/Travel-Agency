using Common.Communication;
using Common.Domain;
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
            Admin user = new Admin
            {
                KorisnickoIme = frmLogin.txtUsername.Text,
                Lozinka = frmLogin.txtPassword.Text,
            };
            Response response = Communication.Instance.Login(user);
            if (response.Exception == null)
            {
                MessageBox.Show("Uspesna prijava");
                frmLogin.Visible = false;
                Admin a = (Admin)response.Odgovor;
                MainCoordinator.Instance.ShowFrmMain(a.Ime, a.Prezime);
            }
            else
            {
                MessageBox.Show("Netačno korisničko ime ili lozinka. Pokušajte ponovo");
            }
        }
    }
}
