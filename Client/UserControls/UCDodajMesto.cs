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
    public partial class UCDodajMesto : UserControl
    {
        public UCDodajMesto()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = 500;
            BindingList<Mesto> mesta = new BindingList<Mesto>((List<Mesto>)Communication.Instance.VratiMesta());
            dgvMesta.DataSource = mesta;
            dgvMesta.Columns["MestoId"].Visible = false;
            dgvMesta.Columns["TableName"].Visible = false;
            dgvMesta.Columns["Values"].Visible = false;
            timer.Tick += AzurirajTabelu;
            timer.Start();
        }

        private void AzurirajTabelu(object sender, EventArgs e)
        {
            BindingList<Mesto> mesta = new BindingList<Mesto>((List<Mesto>)Communication.Instance.VratiMesta());
            dgvMesta.DataSource = mesta;
        }
    }
}