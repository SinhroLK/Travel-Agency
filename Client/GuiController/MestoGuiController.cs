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
            dodajMesto.btnDodajSadrzaj.Click += DodajSadrzaj;
            return dodajMesto;
        }

        private void DodajSadrzaj(object sender, EventArgs e)
        {
            Mesto mesto = dodajMesto.cbMesta.SelectedItem as Mesto;
            if(dodajMesto.txtSadrzaj.Text != "")
            {
              
                Sadrzaj sadrzaj = new Sadrzaj
                {
                    Mesto = mesto,
                    Opis = dodajMesto.txtSadrzaj.Text
                };
                Response response = Communication.Instance.KreirajSadrzaj(sadrzaj);
                if(response.Exception == null)
                {
                    MessageBox.Show($"Uspesno ste dodali sadrzaj za {mesto.NazivMesta}");
                }
                else
                {
                    Debug.WriteLine(">>>", response.Exception.Message);
                }
            }
            else
            {
                MessageBox.Show("Molimo vas da popunite polje za opis sadrzaja");
            }
        }

        private void DodajMesto(object sender, EventArgs e)
        {
            if(dodajMesto.txtNazivMesta.Text != "" && dodajMesto.txtValuta.Text != "" && dodajMesto.txtBrojStanovnika.Text != "")
            {
                try
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
                        dodajMesto.txtNazivMesta.Text = "";
                        dodajMesto.txtValuta.Text = "";
                        dodajMesto.txtBrojStanovnika.Text = "";
                    }
                    else
                    {
                        Debug.WriteLine(">>>", response.Exception);
                    }
                }
                catch (FormatException)
                {

                    MessageBox.Show("Broj stanovnika mora biti brojčana vrednost");
                }
            }
            else
            {
                MessageBox.Show("Molimo vas da popunite sva polja");
            }
        }
    }
}
