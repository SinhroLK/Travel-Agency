using Client.GuiController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            #region on click
            btnAranzman.Click += MainCoordinator.Instance.Aranzman;
            btnMesto.Click += MainCoordinator.Instance.Mesto;
            btnPocetna.Click += MainCoordinator.Instance.Pocetna;
            btnTermin.Click += MainCoordinator.Instance.Termin;
            btnVodic.Click += MainCoordinator.Instance.Vodic;
            btnLogout.Click += MainCoordinator.Instance.Logout;
            #endregion
            #region on leave
            btnAranzman.Leave += MainCoordinator.Instance.AranzmanReset;
            btnMesto.Leave += MainCoordinator.Instance.MestoReset;
            btnPocetna.Leave += MainCoordinator.Instance.PocetnaReset;
            btnTermin.Leave += MainCoordinator.Instance.TerminReset;
            btnVodic.Leave += MainCoordinator.Instance.VodicReset;
            btnLogout.Leave += MainCoordinator.Instance.LogoutReset;
            #endregion
            #region window manipulation
            btnExit.Click += MainCoordinator.Instance.UgasiFormu;
            btnMaximize.Click += MainCoordinator.Instance.Maximize;
            btnMinimize.Click += MainCoordinator.Instance.Minimize;
            pnlWindowControl.MouseDown += MainCoordinator.Instance.KursorKlik;
            pnlWindowControl.MouseMove += MainCoordinator.Instance.KursorKretanje;
            pnlWindowControl.MouseUp += MainCoordinator.Instance.KursorKraj;
            #endregion
            //SK
            btnMesto.Click += MainCoordinator.Instance.DodajMesto;
            btnVodic.Click += MainCoordinator.Instance.DodajVodica;
        }

        internal void ChangePanel(Control control)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(control);
            control.Dock = DockStyle.Fill;
            pnlMain.AutoSize = true;
            pnlMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }
    }
}
