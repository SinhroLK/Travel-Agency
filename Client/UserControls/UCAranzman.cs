using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UserControls
{
    public partial class UCAranzman : UserControl
    {
        Timer timer = new Timer();
        public BindingList<Aranzman> aranzmani;
        public BindingList<Aranzman> filterAranzmani;
        public UCAranzman()
        {
            InitializeComponent();
            InitializeTimer();
            Mesto mesto = new Mesto();
            List<Mesto> listaMesta = (List<Mesto>)Communication.Instance.VratiMesta(mesto);
            BindingList<Mesto> mesta = new BindingList<Mesto>(listaMesta);
            cbMesta.DataSource = mesta;
            cbMesta.DisplayMember = "NazivMesta";
            cbMesta.SelectedItem = null;            
        }
        public void InitializeTimer()
        {
            timer.Interval = 500;
            timer.Tick += AzurirajTabelu;
            timer.Start();
        }

        private void AzurirajTabelu(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPretraga.Text))
            {
                Aranzman aranzman = new Aranzman();
                List<Aranzman> listaAranzmana = (List<Aranzman>)Communication.Instance.VratiAranzmane(aranzman);
                aranzmani = new BindingList<Aranzman>(listaAranzmana);
                filterAranzmani = new BindingList<Aranzman>(listaAranzmana);
                dgvAranzmani.DataSource = aranzmani;
                dgvAranzmani.Columns["TableName"].Visible = false;
                dgvAranzmani.Columns["AranzmanId"].Visible = false;
                dgvAranzmani.Columns["Values"].Visible = false;
                dgvAranzmani.Columns["Id"].Visible = false;
                dgvAranzmani.Columns["IdColumnName"].Visible = false;
            }
        }
    }
}
