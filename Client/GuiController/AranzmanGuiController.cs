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
        Aranzman aranzmanZaIzmenu;

        internal Control KreirajDodajAranzman()
        {
            ucAranzman = new UCAranzman();
            ucAranzman.btnDodajAranzman.Click += DodajAranzman;
            ucAranzman.txtPretraga.TextChanged += Pretraga;
            ucAranzman.btnObrisi.Click += Obrisi;
            ucAranzman.btnDetalji.Click += OmoguciIzmenu;
            ucAranzman.btnIzmeni.Click += Izmeni;
            return ucAranzman;
        }

        private void Izmeni(object sender, EventArgs e)
        {
            Mesto mesto = ucAranzman.cbMesta.SelectedItem as Mesto;
            if (ucAranzman.txtIme.Text != "" && ucAranzman.txtOpis.Text != "" && ucAranzman.txtCena.Text != "" && mesto != null)
            {
                try
                {
                    aranzmanZaIzmenu.ImeAranzmana = ucAranzman.txtIme.Text;
                    aranzmanZaIzmenu.Cena = int.Parse(ucAranzman.txtCena.Text);
                    aranzmanZaIzmenu.Opis = ucAranzman.txtOpis.Text;
                    aranzmanZaIzmenu.Mesto = mesto;
                    Response response = Communication.Instance.IzmeniAranzman(aranzmanZaIzmenu);
                    if (response == null)
                    {
                        MessageBox.Show("Doslo je do greske na serveru");
                        Environment.Exit(0);
                        Communication.Instance.Close();
                        return;
                    }
                    if (response.Exception == null)
                    {
                        MessageBox.Show("Uspesno ste izmenili aranzman!");
                        ucAranzman.txtOpis.Text = "";
                        ucAranzman.txtIme.Text = "";
                        ucAranzman.txtCena.Text = "";
                        ucAranzman.txtPretraga.Text = "";
                        ucAranzman.cbMesta.SelectedItem = null;
                    }
                    else
                    {
                        Debug.WriteLine(">>>", response.Exception);
                        MessageBox.Show(response.Exception.Message);
                    }

                }
                catch (FormatException)
                {
                    MessageBox.Show("Cena mora biti brojcana vrednost");
                }
            }
            else
            {
                MessageBox.Show("Sva polja moraju biti popunjena da bi mogli da izmenite podatke. Ponovo popunite sva polja koriscenjem opcije Detalji");
            }
            ucAranzman.btnIzmeni.Enabled = false;
        }

        private void OmoguciIzmenu(object sender, EventArgs e)
        {
            if(ucAranzman.txtPretraga.Text != "")
            {
                int rowIndex = ucAranzman.dgvAranzmani.SelectedCells[0].RowIndex;
                aranzmanZaIzmenu = ucAranzman.dgvAranzmani.Rows[rowIndex].DataBoundItem as Aranzman;
                ucAranzman.txtIme.Text = aranzmanZaIzmenu.ImeAranzmana;
                ucAranzman.txtCena.Text = aranzmanZaIzmenu.Cena.ToString();
                ucAranzman.txtOpis.Text = aranzmanZaIzmenu.Opis;
                ucAranzman.cbMesta.SelectedIndex = ucAranzman.cbMesta.FindStringExact(aranzmanZaIzmenu.Mesto.ToString());
                ucAranzman.btnIzmeni.Enabled = true;
            }
            else
            {
                MessageBox.Show("Morate pretraziti aranzmane pre izmene");
            }
        }

        private void Obrisi(object sender, EventArgs e)
        {
            if(ucAranzman.txtPretraga.Text != "")
            {
                int rowIndex = ucAranzman.dgvAranzmani.SelectedCells[0].RowIndex;
                Aranzman aranzman = ucAranzman.dgvAranzmani.Rows[rowIndex].DataBoundItem as Aranzman;
                //MessageBox.Show($"{vodic.Ime}, {vodic.VodicId}");
                Response response = Communication.Instance.ObrisiAranzman(aranzman);
                if (response == null)
                {
                    MessageBox.Show("Doslo je do greske na serveru");
                    MainCoordinator.Instance.frmMain.Close();
                    Communication.Instance.Close();
                    return;
                }
                if (response.Exception == null)
                {
                    MessageBox.Show("Uspesno ste obrisali aranzman");
                    ucAranzman.txtPretraga.Text = "";
                    ucAranzman.txtOpis.Text = "";
                    ucAranzman.txtIme.Text = "";
                    ucAranzman.txtCena.Text = "";
                    ucAranzman.txtPretraga.Text = "";
                    ucAranzman.cbMesta.SelectedItem = null;
                }
                else
                {
                    MessageBox.Show("Doslo je do greske pri brisanju aranzmana");
                    Debug.WriteLine(">>>", response.Exception.Message);
                }
            }
            else
            {
                MessageBox.Show("Morate pretraziti aranzmane pre brisanja");
            }
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
                    List<ProlaznoMesto> prolazna = new List<ProlaznoMesto>();
                    foreach (var checkedItem in ucAranzman.clbMesta.CheckedItems)
                    {
                        // Convert the checkedItem to string and do something with it
                        ProlaznoMesto itemValue = new ProlaznoMesto();
                        itemValue.Aranzman = aranzman;
                        itemValue.Mesto = checkedItem as Mesto;
                        prolazna.Add(itemValue);
                    }
                    aranzman.prolaznaMesta = prolazna;
                    Response response = Communication.Instance.KreirajAranzman(aranzman);
                    
                    for (int i = 0; i < ucAranzman.clbMesta.Items.Count; i++)
                    {
                        ucAranzman.clbMesta.SetItemChecked(i, false);
                    }
                    if (response == null)
                    {
                        MessageBox.Show("Doslo je do greske na serveru");
                        MainCoordinator.Instance.frmMain.Close();
                        Communication.Instance.Close();
                        return;
                    }
                    if (response.Exception == null)
                    {
                        MessageBox.Show("Uspesno ste dodali aranzman!");
                        ucAranzman.txtOpis.Text = "";
                        ucAranzman.txtIme.Text = "";
                        ucAranzman.txtCena.Text = "";
                        ucAranzman.txtPretraga.Text = "";
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
            if (listaAranzmana == null)
            {
                MainCoordinator.Instance.frmMain.Close();
                Communication.Instance.Close();
                MessageBox.Show("Doslo je do greske na serveru");
                return;
            }
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
