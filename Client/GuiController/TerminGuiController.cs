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
    public class TerminGuiController
    {
        private UCTermin ucTermin;
        Termin Termin;

        internal Control KreirajDodajTermin()
        {
            ucTermin = new UCTermin();
            ucTermin.btnDodaj.Click += DodajTermin;
            ucTermin.txtPretraga.TextChanged += Pretraga;
            return ucTermin;
        }

        private void DodajTermin(object sender, EventArgs e)
        {
            Aranzman aranzman = ucTermin.cbAranzman.SelectedItem as Aranzman;
            Vodic vodic = ucTermin.cbVodic.SelectedItem as Vodic;
            bool provera = vodic != null && aranzman != null && ucTermin.mcDatumDo.SelectionStart.Date > ucTermin.mcDatumOd.SelectionStart.Date && ucTermin.mcDatumOd.SelectionStart.Date > DateTime.Now.Date && ucTermin.mcDatumDo.SelectionStart.Date > DateTime.Now.Date;
            if (provera)
            {
                Termin termin = new Termin
                {
                    Aranzman = aranzman,
                    Vodic = vodic,
                    DatumOd = ucTermin.mcDatumOd.SelectionStart,
                    DatumDo = ucTermin.mcDatumDo.SelectionStart
                };
                Response response = Communication.Instance.KreirajTermin(termin);
                if (response.Exception == null)
                {
                    MessageBox.Show("Uspesno ste dodali termin!");
                    ucTermin.mcDatumOd.SelectionStart= DateTime.Now;
                    ucTermin.mcDatumDo.SelectionStart = DateTime.Now;
                    ucTermin.cbVodic.SelectedItem= null;
                    ucTermin.txtPretraga.Text = "";
                    ucTermin.cbAranzman.SelectedItem = null;
                }
                else
                {
                    MessageBox.Show("Doslo je do greske pri kreiranju termina");
                    Debug.WriteLine(">>>", response.Exception);
                }
            }
            else
            {
                MessageBox.Show("Molimo vas popunite sva polja i proverite odabrane datume");
            }
        }

        private void Pretraga(object sender, EventArgs e)
        {
            string filter = ucTermin.txtPretraga.Text;
            Termin termin = new Termin();
            List<Termin> listaTermina = (List<Termin>)Communication.Instance.VratiTermine(termin);
            ucTermin.termini = new BindingList<Termin>(listaTermina);

            List<Termin> tempTermin = new List<Termin>();
            foreach (Termin t in ucTermin.termini)
            {
                if (t.Aranzman.ImeAranzmana.ToLower().Contains(filter.ToLower()) || t.Aranzman.Mesto.NazivMesta.ToLower().Contains(filter.ToLower()))
                {
                    tempTermin.Add(t);
                }
                ucTermin.filterTermini = new BindingList<Termin>(tempTermin);
            }
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            ucTermin.dgvTermini.DataSource = ucTermin.filterTermini;
            ucTermin.dgvTermini.Columns["TableName"].Visible = false;
            ucTermin.dgvTermini.Columns["RedniBroj"].Visible = false;
            ucTermin.dgvTermini.Columns["Values"].Visible = false;
            ucTermin.dgvTermini.Columns["Id"].Visible = false;
            ucTermin.dgvTermini.Columns["IdColumnName"].Visible = false;
            ucTermin.dgvTermini.Columns["ZaJoin"].Visible = false;
        }
    }
}
