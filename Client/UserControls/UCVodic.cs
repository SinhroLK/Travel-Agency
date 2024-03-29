﻿using Client.GuiController;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UserControls
{
    public partial class UCVodic : UserControl
    {
        public static Timer timer = new Timer();
        public BindingList<Vodic> vodici;
        public BindingList<Vodic> filterVodici;
        public UCVodic()
        {
            InitializeComponent();
            InitializeTimer();
        }
        public void InitializeTimer()
        {
            timer.Interval = 500;
            timer.Tick += AzurirajTabelu;
            timer.Start();
        }

        private void AzurirajTabelu(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPretraga.Text))
            {
                Vodic vodic = new Vodic();
                List<Vodic> listaVodica = (List<Vodic>)Communication.Instance.VratiVodice(vodic);
                if (listaVodica == null)
                {
                    timer.Stop();
                    MessageBox.Show("Doslo je do greske na serveru");
                    MainCoordinator.Instance.frmMain.Close();
                    Communication.Instance.Close();
                    return;
                }
                vodici = new BindingList<Vodic>(listaVodica);
                filterVodici = new BindingList<Vodic>(listaVodica);
                dgvVodici.DataSource = vodici;
                dgvVodici.Columns["TableName"].Visible = false;
                dgvVodici.Columns["VodicId"].Visible = false;
                dgvVodici.Columns["Values"].Visible = false;
                dgvVodici.Columns["Id"].Visible = false;
                dgvVodici.Columns["IdColumnName"].Visible = false;
                dgvVodici.Columns["zaJoin"].Visible = false;
                dgvVodici.Columns["zaSet"].Visible = false;
                dgvVodici.Columns["DatumRodjenja"].HeaderText = "Datum rodjenja";
                dgvVodici.Columns["DatumIstekaUgovora"].HeaderText = "Datum isteka ugovora";
            } 
        }
        //private void txtPretraga_TextChanged(object sender, EventArgs e)
        //{
        //    string filter = txtPretraga.Text;
        //    BindingList<Vodic> temp = vodici;
        //    if (string.IsNullOrEmpty(filter))
        //    {
        //        filterVodici = vodici;
        //    }
        //    else
        //    {
        //        List<Vodic> tempVodic = new List<Vodic>();
        //        foreach (Vodic vodic in temp)
        //        {
        //            if (vodic.Ime.ToLower().Contains(filter.ToLower()))
        //            {
        //                tempVodic.Add(vodic);
        //            }
        //            filterVodici = new BindingList<Vodic>(tempVodic);
        //        }
        //    }
        //    RefreshDataGridView();
        //}

        //private void RefreshDataGridView()
        //{
        //    dgvVodici.DataSource = filterVodici;
        //    dgvVodici.Columns["TableName"].Visible = false;
        //    dgvVodici.Columns["VodicId"].Visible = false;
        //    dgvVodici.Columns["Values"].Visible = false;
        //}
    }
}
