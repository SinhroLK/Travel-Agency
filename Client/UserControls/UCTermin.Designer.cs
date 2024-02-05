namespace Client.UserControls
{
    partial class UCTermin
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mcDatumOd = new System.Windows.Forms.MonthCalendar();
            this.mcDatumDo = new System.Windows.Forms.MonthCalendar();
            this.cbAranzman = new System.Windows.Forms.ComboBox();
            this.cbVodic = new System.Windows.Forms.ComboBox();
            this.lblAranzman = new System.Windows.Forms.Label();
            this.lblVodic = new System.Windows.Forms.Label();
            this.lblDatumOd = new System.Windows.Forms.Label();
            this.lblDatumDo = new System.Windows.Forms.Label();
            this.dgvTermini = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.lblPretraga = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).BeginInit();
            this.SuspendLayout();
            // 
            // mcDatumOd
            // 
            this.mcDatumOd.Location = new System.Drawing.Point(241, 38);
            this.mcDatumOd.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.mcDatumOd.Name = "mcDatumOd";
            this.mcDatumOd.TabIndex = 8;
            // 
            // mcDatumDo
            // 
            this.mcDatumDo.Location = new System.Drawing.Point(493, 38);
            this.mcDatumDo.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.mcDatumDo.Name = "mcDatumDo";
            this.mcDatumDo.TabIndex = 9;
            // 
            // cbAranzman
            // 
            this.cbAranzman.FormattingEnabled = true;
            this.cbAranzman.Location = new System.Drawing.Point(97, 38);
            this.cbAranzman.Name = "cbAranzman";
            this.cbAranzman.Size = new System.Drawing.Size(121, 25);
            this.cbAranzman.TabIndex = 10;
            // 
            // cbVodic
            // 
            this.cbVodic.FormattingEnabled = true;
            this.cbVodic.Location = new System.Drawing.Point(97, 86);
            this.cbVodic.Name = "cbVodic";
            this.cbVodic.Size = new System.Drawing.Size(121, 25);
            this.cbVodic.TabIndex = 11;
            // 
            // lblAranzman
            // 
            this.lblAranzman.AutoSize = true;
            this.lblAranzman.ForeColor = System.Drawing.Color.White;
            this.lblAranzman.Location = new System.Drawing.Point(17, 46);
            this.lblAranzman.Name = "lblAranzman";
            this.lblAranzman.Size = new System.Drawing.Size(74, 17);
            this.lblAranzman.TabIndex = 12;
            this.lblAranzman.Text = "Aranzman";
            // 
            // lblVodic
            // 
            this.lblVodic.AutoSize = true;
            this.lblVodic.ForeColor = System.Drawing.Color.White;
            this.lblVodic.Location = new System.Drawing.Point(45, 94);
            this.lblVodic.Name = "lblVodic";
            this.lblVodic.Size = new System.Drawing.Size(46, 17);
            this.lblVodic.TabIndex = 13;
            this.lblVodic.Text = "Vodic";
            // 
            // lblDatumOd
            // 
            this.lblDatumOd.AutoSize = true;
            this.lblDatumOd.ForeColor = System.Drawing.Color.White;
            this.lblDatumOd.Location = new System.Drawing.Point(327, 13);
            this.lblDatumOd.Name = "lblDatumOd";
            this.lblDatumOd.Size = new System.Drawing.Size(75, 17);
            this.lblDatumOd.TabIndex = 14;
            this.lblDatumOd.Text = "Datum od";
            // 
            // lblDatumDo
            // 
            this.lblDatumDo.AutoSize = true;
            this.lblDatumDo.ForeColor = System.Drawing.Color.White;
            this.lblDatumDo.Location = new System.Drawing.Point(586, 13);
            this.lblDatumDo.Name = "lblDatumDo";
            this.lblDatumDo.Size = new System.Drawing.Size(75, 17);
            this.lblDatumDo.TabIndex = 15;
            this.lblDatumDo.Text = "Datum do";
            // 
            // dgvTermini
            // 
            this.dgvTermini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTermini.Location = new System.Drawing.Point(252, 256);
            this.dgvTermini.Name = "dgvTermini";
            this.dgvTermini.ReadOnly = true;
            this.dgvTermini.RowHeadersWidth = 51;
            this.dgvTermini.RowTemplate.Height = 24;
            this.dgvTermini.Size = new System.Drawing.Size(475, 249);
            this.dgvTermini.TabIndex = 16;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(97, 132);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(121, 29);
            this.btnDodaj.TabIndex = 17;
            this.btnDodaj.Text = "Dodaj Termin";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // btnDetalji
            // 
            this.btnDetalji.Location = new System.Drawing.Point(109, 345);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(121, 29);
            this.btnDetalji.TabIndex = 18;
            this.btnDetalji.Text = "Detalji";
            this.btnDetalji.UseVisualStyleBackColor = true;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(109, 380);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(121, 29);
            this.btnIzmeni.TabIndex = 19;
            this.btnIzmeni.Text = "Izmeni Termin";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(109, 415);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(121, 29);
            this.btnObrisi.TabIndex = 20;
            this.btnObrisi.Text = "Obrisi Termin";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // lblPretraga
            // 
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.ForeColor = System.Drawing.Color.White;
            this.lblPretraga.Location = new System.Drawing.Point(166, 269);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(64, 17);
            this.lblPretraga.TabIndex = 21;
            this.lblPretraga.Text = "Pretraga";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(111, 289);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(119, 23);
            this.txtPretraga.TabIndex = 22;
            // 
            // UCTermin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.lblPretraga);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvTermini);
            this.Controls.Add(this.lblDatumDo);
            this.Controls.Add(this.lblDatumOd);
            this.Controls.Add(this.lblVodic);
            this.Controls.Add(this.lblAranzman);
            this.Controls.Add(this.cbVodic);
            this.Controls.Add(this.cbAranzman);
            this.Controls.Add(this.mcDatumDo);
            this.Controls.Add(this.mcDatumOd);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UCTermin";
            this.Size = new System.Drawing.Size(747, 517);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MonthCalendar mcDatumOd;
        public System.Windows.Forms.MonthCalendar mcDatumDo;
        public System.Windows.Forms.ComboBox cbAranzman;
        public System.Windows.Forms.ComboBox cbVodic;
        public System.Windows.Forms.Label lblAranzman;
        public System.Windows.Forms.Label lblVodic;
        public System.Windows.Forms.Label lblDatumOd;
        public System.Windows.Forms.Label lblDatumDo;
        public System.Windows.Forms.DataGridView dgvTermini;
        public System.Windows.Forms.Button btnDodaj;
        public System.Windows.Forms.Button btnDetalji;
        public System.Windows.Forms.Button btnIzmeni;
        public System.Windows.Forms.Button btnObrisi;
        public System.Windows.Forms.Label lblPretraga;
        private System.Windows.Forms.TextBox txtPretraga;
    }
}
