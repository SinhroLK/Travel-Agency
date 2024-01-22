using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.GuiController
{
    public class LoginGuiController
    {
        private bool isDragging;
        private Point lastCursorPos;
        private Point lastFormPos;
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
        #region windows manipulation
        internal void UgasiFormu(object sender, EventArgs e)
        {
            frmLogin.Close();
        }

        internal void Maximize(object sender, EventArgs e)
        {
            if (frmLogin.WindowState == System.Windows.Forms.FormWindowState.Maximized)
            {
                frmLogin.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
            else
            {
                frmLogin.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            }

        }

        internal void Minimize(object sender, EventArgs e)
        {
            frmLogin.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }
        internal void KursorKraj(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        internal void KursorKretanje(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = Cursor.Position.X - lastCursorPos.X;
                int deltaY = Cursor.Position.Y - lastCursorPos.Y;

                frmLogin.Location = new Point(lastFormPos.X + deltaX, lastFormPos.Y + deltaY);
            }
        }

        internal void KursorKlik(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastCursorPos = Cursor.Position;
            lastFormPos = frmLogin.Location;
        }
        #endregion
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
