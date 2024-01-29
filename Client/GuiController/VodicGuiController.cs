using Client.UserControls;
using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
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
            //dodajVodica.txtPretraga.TextChanged += Pretraga;
            return dodajVodica;
        }

        //private void Pretraga(object sender, EventArgs e)
        //{
        //    if (dodajVodica.txtPretraga.Text == "")
        //    {
        //        dodajVodica.InitializeTimer();
        //    }
        //    else
        //    {
        //        dodajVodica.FilterData(dodajVodica.txtPretraga.Text);
        //    }
        //}

        private void DodajVodica(object sender, EventArgs e)
        {
            bool provera = dodajVodica.txtImePrezime.Text == "" || dodajVodica.txtPlata.Text == "" || dodajVodica.txtBrojTelefona.Text == "" || dodajVodica.mcDatumRodjenja.SelectionStart.Year - DateTime.Now.Year < 18 || dodajVodica.mcDatumIsteka.SelectionStart != DateTime.Now;
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
