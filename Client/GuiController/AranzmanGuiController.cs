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
    public class AranzmanGuiController
    {
        private UCAranzman ucAranzman;

        internal Control KreirajDodajAranzman()
        {
            ucAranzman = new UCAranzman();
            ucAranzman.btnDodajAranzman.Click += DodajAranzman;
            return ucAranzman;
        }

        private void DodajAranzman(object sender, EventArgs e)
        {
            Mesto mesto = ucAranzman.cbMesta.SelectedItem as Mesto;
            if(ucAranzman.txtIme.Text != "" && ucAranzman.txtOpis.Text != "" && ucAranzman.txtCena.Text != "" && mesto != null)
            {
                try
                {
                    Aranzman aranzman = new Aranzman
                    {
                        ImeAranzmana = ucAranzman.txtIme.Text,
                        Cena = int.Parse(ucAranzman.txtCena.Text),
                        Opis = ucAranzman.txtOpis.Text,
                        Mesto = mesto
                    };
                    Response response = Communication.Instance.KreirajAranzman(aranzman);
                    if (response.Exception == null)
                    {
                        MessageBox.Show("Uspesno ste dodali aranzman!");
                        ucAranzman.txtOpis.Text = "";
                        ucAranzman.txtIme.Text = "";
                        ucAranzman.txtCena.Text = "";
                        ucAranzman.cbMesta.SelectedItem = null;
                    }
                    else
                    {
                        Debug.WriteLine(">>>", response.Exception);
                    }
                }
                catch (FormatException)
                {

                    MessageBox.Show("Cena mora biti brojčana vrednost");
                }
            }
            else
            {
                MessageBox.Show("Molimo vas popunite sva polja");
            }
        }
    }
}
