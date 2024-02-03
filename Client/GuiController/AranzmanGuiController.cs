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
    public class AranzmanGuiController
    {
        private UCAranzman ucAranzman;

        internal Control KreirajDodajAranzman()
        {
            ucAranzman = new UCAranzman();
            ucAranzman.btnDodajAranzman.Click += DodajAranzman;
            ucAranzman.txtPretraga.TextChanged += Pretraga;
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

        private void Pretraga(object sender, EventArgs e)
        {
            string filter = ucAranzman.txtPretraga.Text;
            Aranzman aranzman = new Aranzman();
            List<Aranzman> listaAranzmana = (List<Aranzman>)Communication.Instance.VratiAranzmane(aranzman);
            ucAranzman.aranzmani = new BindingList<Aranzman>(listaAranzmana);
            List<Aranzman> tempAranzman = new List<Aranzman>();
            foreach (Aranzman a in ucAranzman.aranzmani)
            {
                if (a.ImeAranzmana.ToLower().Contains(filter.ToLower()) || a.Mesto.NazivMesta.ToLower().Contains(filter.ToLower()))
                {
                    tempAranzman.Add(a);
                }
                ucAranzman.filterAranzmani = new BindingList<Aranzman>(tempAranzman);
            }
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            ucAranzman.dgvAranzmani.DataSource = ucAranzman.filterAranzmani;
            ucAranzman.dgvAranzmani.Columns["TableName"].Visible = false;
            ucAranzman.dgvAranzmani.Columns["AranzmanId"].Visible = false;
            ucAranzman.dgvAranzmani.Columns["Values"].Visible = false;
            ucAranzman.dgvAranzmani.Columns["Id"].Visible = false;
            ucAranzman.dgvAranzmani.Columns["IdColumnName"].Visible = false;
            ucAranzman.dgvAranzmani.Columns["ZaJoin"].Visible = false;
        }
    }
}
