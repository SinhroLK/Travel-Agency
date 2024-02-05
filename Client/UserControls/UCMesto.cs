﻿using Common.Domain;
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
    public partial class UCMesto : UserControl
    {
        Timer timer = new Timer();
        public UCMesto()
        {
            InitializeComponent();
            InitializeTimer();
            Mesto mesto = new Mesto();
            List<Mesto> listaMesta = (List<Mesto>)Communication.Instance.VratiMesta(mesto);
            BindingList<Mesto> mesta = new BindingList<Mesto>(listaMesta);
            cbMesta.DataSource = mesta;
            cbMesta.DisplayMember = "NazivMesta";
            cbMesta.SelectedItem = null;;
        }

        public void InitializeTimer()
        {
            timer.Interval = 500;
            timer.Tick += AzurirajTabelu;
            timer.Start();
        }

        private void AzurirajTabelu(object sender, EventArgs e)
        {
            Mesto mesto = new Mesto();
            List<Mesto> listaMesta = (List<Mesto>)Communication.Instance.VratiMesta(mesto);
            BindingList<Mesto> mesta = new BindingList<Mesto>(listaMesta);
            dgvMesta.DataSource = mesta;
            dgvMesta.Columns["MestoId"].Visible = false;
            dgvMesta.Columns["TableName"].Visible = false;
            dgvMesta.Columns["Values"].Visible = false;
            dgvMesta.Columns["Id"].Visible = false;
            dgvMesta.Columns["IdColumnName"].Visible = false;
            dgvMesta.Columns["zaJoin"].Visible = false;
            dgvMesta.Columns["zaSet"].Visible = false;
        }
    }
}