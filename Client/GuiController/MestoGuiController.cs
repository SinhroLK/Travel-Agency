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
    public class MestoGuiController
    {
        private UCDodajMesto dodajMesto;

        internal Control KreirajDodajMesto()
        {
            dodajMesto = new UCDodajMesto();
            dodajMesto.btnDodajMesto.Click += DodajMesto;
            return dodajMesto;
        }

        private void DodajMesto(object sender, EventArgs e)
        {
            if(dodajMesto.txtNazivMesta.Text == "" || dodajMesto.txtValuta.Text == "" || dodajMesto.txtBrojStanovnika.Text == "||")
            {
                Mesto mesto = new Mesto
                {
                    NazivMesta = dodajMesto.txtNazivMesta.Text,
                    Valuta = dodajMesto.txtValuta.Text,
                    BrojStanovnika = int.Parse(dodajMesto.txtBrojStanovnika.Text)
                };
                Response response = Communication.Instance.KreirajMesto(mesto);
                if (response.Exception == null)
                {
                    MessageBox.Show("Uspesno ste dodali mesto!");
                }
                else
                {
                    Debug.WriteLine(response.Exception);
                }
            }
            else
            {
                MessageBox.Show("Molimo vas da popunite sva polja");
            }
        }
    }
}
