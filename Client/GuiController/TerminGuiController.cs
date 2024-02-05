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
        Termin terminZaIzmenu;

        internal Control KreirajDodajTermin()
        {
            ucTermin = new UCTermin();
            ucTermin.btnDodaj.Click += DodajTermin;
            ucTermin.txtPretraga.TextChanged += Pretraga;
            ucTermin.btnObrisi.Click += Obrisi;
            ucTermin.btnDetalji.Click += OmoguciIzmenu;
            ucTermin.btnIzmeni.Click += Izmeni;
            return ucTermin;
        }

        private void Izmeni(object sender, EventArgs e)
        {
            Aranzman aranzman = ucTermin.cbAranzman.SelectedItem as Aranzman;
            Vodic vodic = ucTermin.cbVodic.SelectedItem as Vodic;
            bool provera = vodic != null && aranzman != null && ucTermin.mcDatumDo.SelectionStart.Date > ucTermin.mcDatumOd.SelectionStart.Date && ucTermin.mcDatumOd.SelectionStart.Date > DateTime.Now.Date && ucTermin.mcDatumDo.SelectionStart.Date > DateTime.Now.Date;
            if (provera)
            {
                terminZaIzmenu.Aranzman = ucTermin.cbAranzman.SelectedItem as Aranzman;
                terminZaIzmenu.Vodic = ucTermin.cbVodic.SelectedItem as Vodic;
                terminZaIzmenu.DatumOd = ucTermin.mcDatumOd.SelectionStart;
                terminZaIzmenu.DatumDo = ucTermin.mcDatumDo.SelectionStart;

                Response response = Communication.Instance.IzmeniTermin(terminZaIzmenu);
                if (response.Exception == null)
                {
                    MessageBox.Show("Uspesno ste izmenili termin!");
                    ucTermin.mcDatumOd.SelectionStart = DateTime.Now;
                    ucTermin.mcDatumDo.SelectionStart = DateTime.Now;
                    ucTermin.cbVodic.SelectedItem = null;
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
                MessageBox.Show("Sva polja moraju biti popunjena da bi mogli da izmenite podatke. Ponovo popunite sva polja koriscenjem opcije Detalji");
            }
            ucTermin.btnIzmeni.Enabled = false;
            ucTermin.btnDodaj.Enabled = true;
            ucTermin.btnObrisi.Enabled = true;
        }

        private void OmoguciIzmenu(object sender, EventArgs e)
        {
            if (ucTermin.txtPretraga.Text != "")
            {
                int rowIndex = ucTermin.dgvTermini.SelectedCells[0].RowIndex;
                terminZaIzmenu = ucTermin.dgvTermini.Rows[rowIndex].DataBoundItem as Termin; ;
                ucTermin.cbAranzman.SelectedIndex = ucTermin.cbAranzman.FindStringExact(terminZaIzmenu.Aranzman.ToString());
                ucTermin.cbVodic.SelectedIndex = ucTermin.cbVodic.FindStringExact(terminZaIzmenu.Vodic.ToString());
                ucTermin.mcDatumOd.SelectionStart = terminZaIzmenu.DatumOd;
                ucTermin.mcDatumDo.SelectionStart = terminZaIzmenu.DatumDo;
                ucTermin.btnIzmeni.Enabled = true;
                ucTermin.btnDodaj.Enabled = false;
                ucTermin.btnObrisi.Enabled = false;
            }
            else
            {
                MessageBox.Show("Morate pretraziti termine pre izmene");
            }
        }

        private void Obrisi(object sender, EventArgs e)
        {
            if (ucTermin.txtPretraga.Text != "")
            {
                int rowIndex = ucTermin.dgvTermini.SelectedCells[0].RowIndex;
                Termin termin= ucTermin.dgvTermini.Rows[rowIndex].DataBoundItem as Termin;
                Response response = Communication.Instance.ObrisiTermin(termin);
                if (response.Exception == null)
                {
                    MessageBox.Show("Uspesno ste obrisali termin");
                    ucTermin.mcDatumOd.SelectionStart = DateTime.Now;
                    ucTermin.mcDatumDo.SelectionStart = DateTime.Now;
                    ucTermin.cbVodic.SelectedItem = null;
                    ucTermin.txtPretraga.Text = "";
                    ucTermin.cbAranzman.SelectedItem = null;
                }
                else
                {
                    MessageBox.Show("Doslo je do greske pri brisanju termina");
                    Debug.WriteLine(">>>", response.Exception.Message);
                }
            }
            else
            {
                MessageBox.Show("Morate pretraziti termine pre brisanja");
            }
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
