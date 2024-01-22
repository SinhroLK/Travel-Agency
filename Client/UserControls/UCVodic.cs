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
    public partial class UCVodic : UserControl
    {
        public UCVodic()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = 500;

            timer.Tick += AzurirajTabelu;
            timer.Start();
        }

        private void AzurirajTabelu(object sender, EventArgs e)
        {
            Vodic vodic= new Vodic();
            List<Vodic> listaVodica = (List<Vodic>)Communication.Instance.VratiVodice(vodic);
            BindingList<Vodic> mesta = new BindingList<Vodic>(listaVodica);
            dgvVodici.DataSource = mesta;
            dgvVodici.Columns["VodicId"].Visible = false;
            dgvVodici.Columns["TableName"].Visible = false;
            dgvVodici.Columns["Values"].Visible = false;
        }
    }
}
