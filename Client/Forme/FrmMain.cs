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
            // on click
            btnAranzman.Click += MainCoordinator.Instance.Aranzman;
            btnMesto.Click += MainCoordinator.Instance.Mesto;
            btnPocetna.Click += MainCoordinator.Instance.Pocetna;
            btnTermin.Click += MainCoordinator.Instance.Termin;
            btnVodic.Click += MainCoordinator.Instance.Vodic;
            btnLogout.Click += MainCoordinator.Instance.Logout;
            // on leave
            btnAranzman.Leave += MainCoordinator.Instance.AranzmanReset;
            btnMesto.Leave += MainCoordinator.Instance.MestoReset;
            btnPocetna.Leave += MainCoordinator.Instance.PocetnaReset;
            btnTermin.Leave += MainCoordinator.Instance.TerminReset;
            btnVodic.Leave += MainCoordinator.Instance.VodicReset;
            btnLogout.Leave += MainCoordinator.Instance.LogoutReset;
        }
    }
}
