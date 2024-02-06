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
    public partial class UCTermin : UserControl
    {
        Timer timer = new Timer();
        public BindingList<Termin> termini;
        public BindingList<Termin> filterTermini;
        public UCTermin()
        {
            InitializeComponent();
            btnIzmeni.Enabled = false;
            InitializeTimer();
            Aranzman aranzman = new Aranzman();
            List<Aranzman> listaAranzmana = (List<Aranzman>)Communication.Instance.VratiAranzmane(aranzman);
            if (listaAranzmana == null)
            {
                timer.Stop();
                MessageBox.Show("Doslo je do greske na serveru");
                MainCoordinator.Instance.frmMain.Dispose();
                Environment.Exit(0);
                Communication.Instance.Close();
                return;
            }
            BindingList<Aranzman> aranzmani = new BindingList<Aranzman>(listaAranzmana);
            cbAranzman.DataSource = aranzmani;
            cbAranzman.DisplayMember = "ImeAranzmana";
            cbAranzman.SelectedItem = null;
            Vodic vodic = new Vodic();
            List<Vodic> listaVodica = (List<Vodic>)Communication.Instance.VratiVodice(vodic);
            if (listaVodica == null)
            {
                timer.Stop();
                MessageBox.Show("Doslo je do greske na serveru");
                MainCoordinator.Instance.frmMain.Close();
                Communication.Instance.Close();
                return;
            }
            BindingList<Vodic> vodici = new BindingList<Vodic>(listaVodica);
            cbVodic.DataSource = vodici;
            cbVodic.DisplayMember = "Ime";
            cbVodic.SelectedItem = null;
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
                Termin termin = new Termin();
                List<Termin> listaTermina = (List<Termin>)Communication.Instance.VratiTermine(termin);
                if (listaTermina == null)
                {
                    timer.Stop();
                    MessageBox.Show("Doslo je do greske na serveru");
                    MainCoordinator.Instance.frmMain.Dispose();
                    Environment.Exit(0);
                    Communication.Instance.Close();
                    return;
                }
                termini = new BindingList<Termin>(listaTermina);
                filterTermini = new BindingList<Termin>(listaTermina);
                dgvTermini.DataSource = termini;
                dgvTermini.Columns["TableName"].Visible = false;
                dgvTermini.Columns["RedniBroj"].Visible = false;
                dgvTermini.Columns["Values"].Visible = false;
                dgvTermini.Columns["Id"].Visible = false;
                dgvTermini.Columns["IdColumnName"].Visible = false;
                dgvTermini.Columns["zaJoin"].Visible = false;
                dgvTermini.Columns["zaSet"].Visible = false;

            }
        }
    }
}
