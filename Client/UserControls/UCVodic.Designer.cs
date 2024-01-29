namespace Client.UserControls
{
    partial class UCVodic
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
            this.dgvVodici = new System.Windows.Forms.DataGridView();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPlata = new System.Windows.Forms.Label();
            this.lblBrojTelefona = new System.Windows.Forms.Label();
            this.txtImePrezime = new System.Windows.Forms.TextBox();
            this.txtPlata = new System.Windows.Forms.TextBox();
            this.txtBrojTelefona = new System.Windows.Forms.TextBox();
            this.mcDatumRodjenja = new System.Windows.Forms.MonthCalendar();
            this.mcDatumIsteka = new System.Windows.Forms.MonthCalendar();
            this.lblDatumRodjenja = new System.Windows.Forms.Label();
            this.lblDatumIstekaUgovora = new System.Windows.Forms.Label();
            this.btnDodajVodica = new System.Windows.Forms.Button();
            this.btnObrisiVodica = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.lblPretraga = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVodici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVodici
            // 
            this.dgvVodici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVodici.Location = new System.Drawing.Point(28, 311);
            this.dgvVodici.Name = "dgvVodici";
            this.dgvVodici.RowHeadersWidth = 51;
            this.dgvVodici.RowTemplate.Height = 24;
            this.dgvVodici.Size = new System.Drawing.Size(566, 159);
            this.dgvVodici.TabIndex = 0;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.ForeColor = System.Drawing.Color.White;
            this.lblIme.Location = new System.Drawing.Point(21, 44);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(93, 17);
            this.lblIme.TabIndex = 1;
            this.lblIme.Text = "Ime i Prezime";
            // 
            // lblPlata
            // 
            this.lblPlata.AutoSize = true;
            this.lblPlata.ForeColor = System.Drawing.Color.White;
            this.lblPlata.Location = new System.Drawing.Point(54, 89);
            this.lblPlata.Name = "lblPlata";
            this.lblPlata.Size = new System.Drawing.Size(42, 17);
            this.lblPlata.TabIndex = 2;
            this.lblPlata.Text = "Plata";
            // 
            // lblBrojTelefona
            // 
            this.lblBrojTelefona.AutoSize = true;
            this.lblBrojTelefona.ForeColor = System.Drawing.Color.White;
            this.lblBrojTelefona.Location = new System.Drawing.Point(25, 134);
            this.lblBrojTelefona.Name = "lblBrojTelefona";
            this.lblBrojTelefona.Size = new System.Drawing.Size(89, 17);
            this.lblBrojTelefona.TabIndex = 3;
            this.lblBrojTelefona.Text = "Broj telefona";
            // 
            // txtImePrezime
            // 
            this.txtImePrezime.Location = new System.Drawing.Point(102, 38);
            this.txtImePrezime.Name = "txtImePrezime";
            this.txtImePrezime.Size = new System.Drawing.Size(100, 23);
            this.txtImePrezime.TabIndex = 4;
            // 
            // txtPlata
            // 
            this.txtPlata.Location = new System.Drawing.Point(102, 83);
            this.txtPlata.Name = "txtPlata";
            this.txtPlata.Size = new System.Drawing.Size(100, 23);
            this.txtPlata.TabIndex = 5;
            // 
            // txtBrojTelefona
            // 
            this.txtBrojTelefona.Location = new System.Drawing.Point(102, 128);
            this.txtBrojTelefona.Name = "txtBrojTelefona";
            this.txtBrojTelefona.Size = new System.Drawing.Size(100, 23);
            this.txtBrojTelefona.TabIndex = 6;
            // 
            // mcDatumRodjenja
            // 
            this.mcDatumRodjenja.Location = new System.Drawing.Point(237, 38);
            this.mcDatumRodjenja.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.mcDatumRodjenja.Name = "mcDatumRodjenja";
            this.mcDatumRodjenja.TabIndex = 7;
            // 
            // mcDatumIsteka
            // 
            this.mcDatumIsteka.Location = new System.Drawing.Point(489, 38);
            this.mcDatumIsteka.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.mcDatumIsteka.Name = "mcDatumIsteka";
            this.mcDatumIsteka.TabIndex = 8;
            // 
            // lblDatumRodjenja
            // 
            this.lblDatumRodjenja.AutoSize = true;
            this.lblDatumRodjenja.ForeColor = System.Drawing.Color.White;
            this.lblDatumRodjenja.Location = new System.Drawing.Point(293, 13);
            this.lblDatumRodjenja.Name = "lblDatumRodjenja";
            this.lblDatumRodjenja.Size = new System.Drawing.Size(110, 17);
            this.lblDatumRodjenja.TabIndex = 9;
            this.lblDatumRodjenja.Text = "DatumRodjenja";
            // 
            // lblDatumIstekaUgovora
            // 
            this.lblDatumIstekaUgovora.AutoSize = true;
            this.lblDatumIstekaUgovora.ForeColor = System.Drawing.Color.White;
            this.lblDatumIstekaUgovora.Location = new System.Drawing.Point(518, 13);
            this.lblDatumIstekaUgovora.Name = "lblDatumIstekaUgovora";
            this.lblDatumIstekaUgovora.Size = new System.Drawing.Size(154, 17);
            this.lblDatumIstekaUgovora.TabIndex = 10;
            this.lblDatumIstekaUgovora.Text = "Datum isteka ugovora";
            // 
            // btnDodajVodica
            // 
            this.btnDodajVodica.Location = new System.Drawing.Point(102, 170);
            this.btnDodajVodica.Name = "btnDodajVodica";
            this.btnDodajVodica.Size = new System.Drawing.Size(100, 45);
            this.btnDodajVodica.TabIndex = 11;
            this.btnDodajVodica.Text = "Dodaj vodiča";
            this.btnDodajVodica.UseVisualStyleBackColor = true;
            // 
            // btnObrisiVodica
            // 
            this.btnObrisiVodica.Location = new System.Drawing.Point(620, 431);
            this.btnObrisiVodica.Name = "btnObrisiVodica";
            this.btnObrisiVodica.Size = new System.Drawing.Size(103, 39);
            this.btnObrisiVodica.TabIndex = 12;
            this.btnObrisiVodica.Text = "Obriši vodiča";
            this.btnObrisiVodica.UseVisualStyleBackColor = true;
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(145, 280);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(100, 23);
            this.txtPretraga.TabIndex = 13;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // lblPretraga
            // 
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.ForeColor = System.Drawing.Color.White;
            this.lblPretraga.Location = new System.Drawing.Point(25, 286);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(114, 17);
            this.lblPretraga.TabIndex = 14;
            this.lblPretraga.Text = "Pretraga vodiča";
            // 
            // UCVodic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.lblPretraga);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.btnObrisiVodica);
            this.Controls.Add(this.btnDodajVodica);
            this.Controls.Add(this.lblDatumIstekaUgovora);
            this.Controls.Add(this.lblDatumRodjenja);
            this.Controls.Add(this.mcDatumIsteka);
            this.Controls.Add(this.mcDatumRodjenja);
            this.Controls.Add(this.txtBrojTelefona);
            this.Controls.Add(this.txtPlata);
            this.Controls.Add(this.txtImePrezime);
            this.Controls.Add(this.lblBrojTelefona);
            this.Controls.Add(this.lblPlata);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.dgvVodici);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UCVodic";
            this.Size = new System.Drawing.Size(747, 517);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVodici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvVodici;
        public System.Windows.Forms.Label lblIme;
        public System.Windows.Forms.Label lblPlata;
        public System.Windows.Forms.Label lblBrojTelefona;
        public System.Windows.Forms.TextBox txtImePrezime;
        public System.Windows.Forms.TextBox txtPlata;
        public System.Windows.Forms.TextBox txtBrojTelefona;
        public System.Windows.Forms.MonthCalendar mcDatumRodjenja;
        public System.Windows.Forms.MonthCalendar mcDatumIsteka;
        public System.Windows.Forms.Label lblDatumRodjenja;
        public System.Windows.Forms.Label lblDatumIstekaUgovora;
        public System.Windows.Forms.Button btnDodajVodica;
        public System.Windows.Forms.Button btnObrisiVodica;
        public System.Windows.Forms.TextBox txtPretraga;
        public System.Windows.Forms.Label lblPretraga;
    }
}
