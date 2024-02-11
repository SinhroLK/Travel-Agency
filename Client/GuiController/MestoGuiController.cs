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
    public class MestoGuiController
    {
        private UCMesto ucMesto;

        internal Control KreirajDodajMesto()
        {
            ucMesto = new UCMesto();
            ucMesto.btnDodajMesto.Click += DodajMesto;
            ucMesto.btnDodajSadrzaj.Click += DodajSadrzaj;
            return ucMesto;
        }

        private void DodajSadrzaj(object sender, EventArgs e)
        {
            Mesto mesto = ucMesto.cbMesta.SelectedItem as Mesto;
            if(ucMesto.txtSadrzaj.Text != "" && mesto != null)
            {
              
                Sadrzaj sadrzaj = new Sadrzaj
                {
                    Mesto = mesto,
                    Opis = ucMesto.txtSadrzaj.Text
                };
                Response response = Communication.Instance.KreirajSadrzaj(sadrzaj);
                if (response == null)
                {
                    MessageBox.Show("Doslo je do greske na serveru");
                    MainCoordinator.Instance.frmMain.Close();
                    Communication.Instance.Close();
                    return;
                }
                if (response.Exception == null)
                {
                    MessageBox.Show($"Uspesno ste dodali sadrzaj za {mesto.NazivMesta}");
                    ucMesto.txtSadrzaj.Text = "";
                    ucMesto.cbMesta.SelectedItem = null;
                }
                else
                {
                    Debug.WriteLine(">>>", response.Exception.Message);
                }
            }
            else
            {
                MessageBox.Show("Molimo Vas da popunite polje za opis sadrzaja i odaberite mesto");
            }
        }

        private void DodajMesto(object sender, EventArgs e)
        {
            if(ucMesto.txtNazivMesta.Text != "" && ucMesto.txtValuta.Text != "" && ucMesto.txtBrojStanovnika.Text != "")
            {
                try
                {
                    Mesto mesto = new Mesto
                    {
                        NazivMesta = ucMesto.txtNazivMesta.Text,
                        Valuta = ucMesto.txtValuta.Text,
                        BrojStanovnika = int.Parse(ucMesto.txtBrojStanovnika.Text)
                    };
                    Response response = Communication.Instance.KreirajMesto(mesto);
                    if (response == null)
                    {
                        MessageBox.Show("Doslo je do greske na serveru");
                        MainCoordinator.Instance.frmMain.Close();
                        Communication.Instance.Close();
                        return;
                    }
                    if (response.Exception == null)
                    {
                        MessageBox.Show("Uspesno ste dodali mesto!");
                        ucMesto.txtNazivMesta.Text = "";
                        ucMesto.txtValuta.Text = "";
                        ucMesto.txtBrojStanovnika.Text = "";
                        List<Mesto> listaMesta = (List<Mesto>)Communication.Instance.VratiMesta(new Mesto());
                        BindingList<Mesto> mesta = new BindingList<Mesto>(listaMesta);
                        ucMesto.cbMesta.SelectedItem = null;
                        ucMesto.cbMesta.DataSource = mesta;
                        ucMesto.cbMesta.DisplayMember = "NazivMesta";
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
