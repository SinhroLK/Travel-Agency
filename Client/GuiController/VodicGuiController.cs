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
        private UCVodic dodajVodica;
        internal Control KreirajDodajVodica()
        {
            dodajVodica = new UCVodic();
            dodajVodica.btnDodajVodica.Click += DodajVodica;
            dodajVodica.txtPretraga.TextChanged += Pretraga;
            return dodajVodica;
        }

        private void Pretraga(object sender, EventArgs e)
        {
            string filter = dodajVodica.txtPretraga.Text;
            BindingList<Vodic> temp = dodajVodica.vodici;
            if (string.IsNullOrEmpty(filter))
            {
                dodajVodica.filterVodici = dodajVodica.vodici;
            }
            else
            {
                List<Vodic> tempVodic = new List<Vodic>();
                foreach (Vodic vodic in temp)
                {
                    if (vodic.Ime.ToLower().Contains(filter.ToLower()))
                    {
                        tempVodic.Add(vodic);
                    }
                    dodajVodica.filterVodici = new BindingList<Vodic>(tempVodic);
                }
            }
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            dodajVodica.dgvVodici.DataSource = dodajVodica.filterVodici;
            dodajVodica.dgvVodici.Columns["TableName"].Visible = false;
            dodajVodica.dgvVodici.Columns["VodicId"].Visible = false;
            dodajVodica.dgvVodici.Columns["Values"].Visible = false;
        }

        private void DodajVodica(object sender, EventArgs e)
        {
            bool rodjenje_provera = DateTime.Now.Year - dodajVodica.mcDatumRodjenja.SelectionStart.Year > 18;
            bool provera = dodajVodica.txtImePrezime.Text != "" && dodajVodica.txtPlata.Text != "" && dodajVodica.txtBrojTelefona.Text != "" && rodjenje_provera && dodajVodica.mcDatumIsteka.SelectionStart.Date != DateTime.Now.Date;
            if (provera)
            {
                Vodic vodic = new Vodic
                {
                    Ime = dodajVodica.txtImePrezime.Text,
                    Plata = double.Parse(dodajVodica.txtPlata.Text),
                    BrojTelefona = dodajVodica.txtBrojTelefona.Text,
                    DatumRodjenja = dodajVodica.mcDatumRodjenja.SelectionStart,
                    DatumIstekaUgovora = dodajVodica.mcDatumIsteka.SelectionStart
                };
                Response response = Communication.Instance.KreirajVodica(vodic);
                if (response.Exception == null)
                {
                    MessageBox.Show("Uspesno ste dodali vodica!");
                }
                else
                {
                    Debug.WriteLine(response.Exception);
                }
            }
            else
            {
                MessageBox.Show("Molimo popunite sva polja");
            }
        }
    }
}
