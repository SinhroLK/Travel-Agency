using Client.GuiController;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UserControls
{
    public partial class UCMesto : UserControl
    {
        Timer timer = new Timer();
        public UCMesto()
        {
            InitializeComponent();
            InitializeTimer();
            Mesto mesto = new Mesto();
            List<Mesto> listaMesta = (List<Mesto>)Communication.Instance.VratiMesta(mesto);
            if (listaMesta == null)
            {
                MainCoordinator.Instance.frmMain.Close();
                Communication.Instance.Close();
                MessageBox.Show("Doslo je do greske na serveru");
                return;
            }
            BindingList<Mesto> mesta = new BindingList<Mesto>(listaMesta);
            cbMesta.SelectedItem = null;
            cbMesta.DataSource = mesta;
            cbMesta.DisplayMember = "NazivMesta";
        }

        public void InitializeTimer()
        {
            timer.Interval = 500;
            timer.Tick += AzurirajTabelu;
            timer.Start();
        }

        private void AzurirajTabelu(object sender, EventArgs e)
        {
            Mesto mesto = new Mesto();
            List<Mesto> listaMesta = (List<Mesto>)Communication.Instance.VratiMesta(mesto);
            if (listaMesta == null)
            {
                timer.Stop();
                MessageBox.Show("Doslo je do greske na serveru");
                MainCoordinator.Instance.frmMain.Close();
                Communication.Instance.Close();
                return;
            }
            BindingList<Mesto> mesta = new BindingList<Mesto>(listaMesta);
            dgvMesta.DataSource = mesta;
            dgvMesta.Columns["MestoId"].Visible = false;
            dgvMesta.Columns["TableName"].Visible = false;
            dgvMesta.Columns["Values"].Visible = false;
            dgvMesta.Columns["Id"].Visible = false;
            dgvMesta.Columns["IdColumnName"].Visible = false;
            dgvMesta.Columns["zaJoin"].Visible = false;
            dgvMesta.Columns["zaSet"].Visible = false;   
        }
    }
}
