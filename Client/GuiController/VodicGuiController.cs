using Client.UserControls;
using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.GuiController
{
    public class VodicGuiController
    {
        private UCVodic ucVodic;
        internal Control KreirajDodajVodica()
        {
            ucVodic = new UCVodic();
            ucVodic.btnDodajVodica.Click += DodajVodica;
            ucVodic.txtPretraga.TextChanged += Pretraga;
            ucVodic.btnObrisiVodica.Click += ObrisiVodica;
            return ucVodic;
        }

        private void ObrisiVodica(object sender, EventArgs e)
        {
            if(ucVodic.txtPretraga.Text != "")
            {
                int rowIndex = ucVodic.dgvVodici.SelectedCells[0].RowIndex;
                Vodic vodic = ucVodic.dgvVodici.Rows[rowIndex].DataBoundItem as Vodic;
                //MessageBox.Show($"{vodic.Ime}, {vodic.VodicId}");
                Response response = Communication.Instance.ObrisiVodica(vodic);
                if (response == null)
                {
                    MessageBox.Show("Doslo je do greske na serveru");
                    MainCoordinator.Instance.frmMain.Close();
                    Communication.Instance.Close();
                    return;
                }
                if (response.Exception == null)
                {
                    MessageBox.Show("Uspesno ste obrisali vodica");
                    ucVodic.txtPretraga.Text = "";
                }
                else
                {
                    MessageBox.Show("Doslo je do greske pri brisanju vodica");
                    Debug.WriteLine(">>>", response.Exception.Message);
                }
            }
            else
            {
                MessageBox.Show("Morate pretraziti vodice pre brisanja");
            }
        }

        #region pretraga
        private void Pretraga(object sender, EventArgs e)
        {
            string filter = ucVodic.txtPretraga.Text;
            Vodic vodic = new Vodic();
            List<Vodic> listaVodica = (List<Vodic>)Communication.Instance.VratiVodice(vodic);
            if (listaVodica == null)
            {
                MainCoordinator.Instance.frmMain.Close();
                Communication.Instance.Close();
                MessageBox.Show("Doslo je do greske na serveru");
                return;
            }
            ucVodic.vodici = new BindingList<Vodic>(listaVodica);
            List<Vodic> tempVodic = new List<Vodic>();
            foreach (Vodic v in ucVodic.vodici)
            {
                if (v.Ime.ToLower().Contains(filter.ToLower()))
                {
                    tempVodic.Add(v);
                }
                ucVodic.filterVodici = new BindingList<Vodic>(tempVodic);
            }
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            ucVodic.dgvVodici.DataSource = ucVodic.filterVodici;
            ucVodic.dgvVodici.Columns["TableName"].Visible = false;
            ucVodic.dgvVodici.Columns["VodicId"].Visible = false;
            ucVodic.dgvVodici.Columns["Values"].Visible = false;
        }
        #endregion
        private void DodajVodica(object sender, EventArgs e)
        {
            bool datumRodjenjaProvera = DateTime.Now.Year - ucVodic.mcDatumRodjenja.SelectionStart.Year > 18;
            bool datumIstekaUgovoraProvera = ucVodic.mcDatumIsteka.SelectionStart.Date > DateTime.Now.Date;
            bool provera = ucVodic.txtImePrezime.Text != "" && ucVodic.txtPlata.Text != "" && ucVodic.txtBrojTelefona.Text != "" && datumRodjenjaProvera && datumIstekaUgovoraProvera;
            if (provera)
            {
                try
                {
                    Vodic vodic = new Vodic
                    {
                        Ime = ucVodic.txtImePrezime.Text,
                        Plata = double.Parse(ucVodic.txtPlata.Text),
                        BrojTelefona = ucVodic.txtBrojTelefona.Text,
                        DatumRodjenja = ucVodic.mcDatumRodjenja.SelectionStart,
                        DatumIstekaUgovora = ucVodic.mcDatumIsteka.SelectionStart
                    };
                    Response response = Communication.Instance.KreirajVodica(vodic);
                    if (response == null)
                    {
                        MessageBox.Show("Doslo je do greske na serveru");
                        MainCoordinator.Instance.frmMain.Close();
                        Communication.Instance.Close();
                        return;
                    }
                    if (response.Exception == null)
                    {
                        MessageBox.Show("Uspesno ste dodali vodica!");
                        ucVodic.txtImePrezime.Text = "";
                        ucVodic.txtPlata.Text = "";
                        ucVodic.txtBrojTelefona.Text = "";
                        ucVodic.mcDatumIsteka.SetDate(DateTime.Now);
                        ucVodic.mcDatumRodjenja.SetDate(DateTime.Now);
                    }
                    else
                    {
                        Debug.WriteLine(">>>", response.Exception.Message);
                    }
                }
                catch (FormatException)
                {

                    MessageBox.Show("Plata mora biti brojcana vrednost");
                }
            }
            else
            {
                if (!datumRodjenjaProvera)
                {
                    MessageBox.Show("Osoba nema 18 godina");
                } 
                else if (!datumIstekaUgovoraProvera)
                {
                    MessageBox.Show("Datum isteka ugovora mora biti datum u budućnosti");
                }
                else
                {
                    MessageBox.Show("Molimo popunite sva polja");
                }
            }
        }
    }
}
