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
        #region pretraga
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
        #endregion
        private void DodajVodica(object sender, EventArgs e)
        {
            bool datumRodjenjaProvera = DateTime.Now.Year - dodajVodica.mcDatumRodjenja.SelectionStart.Year > 18;
            bool datumIstekaUgovoraProvera = dodajVodica.mcDatumIsteka.SelectionStart.Date > DateTime.Now.Date;
            bool provera = dodajVodica.txtImePrezime.Text != "" && dodajVodica.txtPlata.Text != "" && dodajVodica.txtBrojTelefona.Text != "" && datumRodjenjaProvera && datumIstekaUgovoraProvera;
            if (provera)
            {
                try
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
                        dodajVodica.txtImePrezime.Text = "";
                        dodajVodica.txtPlata.Text = "";
                        dodajVodica.txtBrojTelefona.Text = "";
                        dodajVodica.mcDatumIsteka.SetDate(DateTime.Now);
                        dodajVodica.mcDatumRodjenja.SetDate(DateTime.Now);
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
                } else if (!datumIstekaUgovoraProvera)
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
