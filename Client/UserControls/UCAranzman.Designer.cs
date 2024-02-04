namespace Client.UserControls
{
    partial class UCAranzman
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
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblCena = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.dgvAranzmani = new System.Windows.Forms.DataGridView();
            this.lblComboMesta = new System.Windows.Forms.Label();
            this.cbMesta = new System.Windows.Forms.ComboBox();
            this.btnDodajAranzman = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.lblPretraga = new System.Windows.Forms.Label();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAranzmani)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(74, 11);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(176, 23);
            this.txtIme.TabIndex = 0;
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(74, 58);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(176, 23);
            this.txtCena.TabIndex = 1;
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(74, 108);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(176, 145);
            this.txtOpis.TabIndex = 2;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.lblNaziv.ForeColor = System.Drawing.Color.White;
            this.lblNaziv.Location = new System.Drawing.Point(35, 12);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(41, 21);
            this.lblNaziv.TabIndex = 3;
            this.lblNaziv.Text = "Ime";
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.lblCena.ForeColor = System.Drawing.Color.White;
            this.lblCena.Location = new System.Drawing.Point(19, 59);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(57, 21);
            this.lblCena.TabIndex = 4;
            this.lblCena.Text = "Cena";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.lblOpis.ForeColor = System.Drawing.Color.White;
            this.lblOpis.Location = new System.Drawing.Point(29, 107);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(47, 21);
            this.lblOpis.TabIndex = 5;
            this.lblOpis.Text = "Opis";
            // 
            // dgvAranzmani
            // 
            this.dgvAranzmani.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAranzmani.Location = new System.Drawing.Point(295, 43);
            this.dgvAranzmani.MultiSelect = false;
            this.dgvAranzmani.Name = "dgvAranzmani";
            this.dgvAranzmani.ReadOnly = true;
            this.dgvAranzmani.RowHeadersWidth = 51;
            this.dgvAranzmani.RowTemplate.Height = 24;
            this.dgvAranzmani.Size = new System.Drawing.Size(432, 451);
            this.dgvAranzmani.TabIndex = 8;
            // 
            // lblComboMesta
            // 
            this.lblComboMesta.AutoSize = true;
            this.lblComboMesta.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComboMesta.ForeColor = System.Drawing.Color.White;
            this.lblComboMesta.Location = new System.Drawing.Point(12, 272);
            this.lblComboMesta.Name = "lblComboMesta";
            this.lblComboMesta.Size = new System.Drawing.Size(64, 21);
            this.lblComboMesta.TabIndex = 14;
            this.lblComboMesta.Text = "Mesta";
            // 
            // cbMesta
            // 
            this.cbMesta.FormattingEnabled = true;
            this.cbMesta.Location = new System.Drawing.Point(74, 269);
            this.cbMesta.Name = "cbMesta";
            this.cbMesta.Size = new System.Drawing.Size(176, 25);
            this.cbMesta.TabIndex = 13;
            // 
            // btnDodajAranzman
            // 
            this.btnDodajAranzman.Location = new System.Drawing.Point(116, 310);
            this.btnDodajAranzman.Name = "btnDodajAranzman";
            this.btnDodajAranzman.Size = new System.Drawing.Size(134, 35);
            this.btnDodajAranzman.TabIndex = 15;
            this.btnDodajAranzman.Text = "Dodaj Aranzman";
            this.btnDodajAranzman.UseVisualStyleBackColor = true;
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(574, 10);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(136, 23);
            this.txtPretraga.TabIndex = 16;
            // 
            // lblPretraga
            // 
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.lblPretraga.ForeColor = System.Drawing.Color.White;
            this.lblPretraga.Location = new System.Drawing.Point(464, 9);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(83, 21);
            this.lblPretraga.TabIndex = 17;
            this.lblPretraga.Text = "Pretraga";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(116, 351);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(134, 35);
            this.btnObrisi.TabIndex = 18;
            this.btnObrisi.Text = "Obrisi Aranzman";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // btnDetalji
            // 
            this.btnDetalji.Location = new System.Drawing.Point(116, 392);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(134, 35);
            this.btnDetalji.TabIndex = 19;
            this.btnDetalji.Text = "Detalji";
            this.btnDetalji.UseVisualStyleBackColor = true;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(116, 433);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(134, 35);
            this.btnIzmeni.TabIndex = 20;
            this.btnIzmeni.Text = "Izmeni Aranzman";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            // 
            // UCAranzman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.lblPretraga);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.btnDodajAranzman);
            this.Controls.Add(this.lblComboMesta);
            this.Controls.Add(this.cbMesta);
            this.Controls.Add(this.dgvAranzmani);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblCena);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.txtIme);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UCAranzman";
            this.Size = new System.Drawing.Size(747, 517);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAranzmani)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtIme;
        public System.Windows.Forms.TextBox txtCena;
        public System.Windows.Forms.TextBox txtOpis;
        public System.Windows.Forms.Label lblNaziv;
        public System.Windows.Forms.Label lblCena;
        public System.Windows.Forms.Label lblOpis;
        public System.Windows.Forms.DataGridView dgvAranzmani;
        public System.Windows.Forms.Label lblComboMesta;
        public System.Windows.Forms.ComboBox cbMesta;
        public System.Windows.Forms.Button btnDodajAranzman;
        public System.Windows.Forms.TextBox txtPretraga;
        public System.Windows.Forms.Label lblPretraga;
        public System.Windows.Forms.Button btnObrisi;
        public System.Windows.Forms.Button btnDetalji;
        public System.Windows.Forms.Button btnIzmeni;
    }
}
