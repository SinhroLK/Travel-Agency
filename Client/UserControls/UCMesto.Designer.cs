namespace Client.UserControls
{
    partial class UCMesto
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
            this.txtNazivMesta = new System.Windows.Forms.TextBox();
            this.txtValuta = new System.Windows.Forms.TextBox();
            this.txtBrojStanovnika = new System.Windows.Forms.TextBox();
            this.lblNazivMesta = new System.Windows.Forms.Label();
            this.lblValuta = new System.Windows.Forms.Label();
            this.lblBrojStanovnika = new System.Windows.Forms.Label();
            this.btnDodajMesto = new System.Windows.Forms.Button();
            this.dgvMesta = new System.Windows.Forms.DataGridView();
            this.txtSadrzaj = new System.Windows.Forms.TextBox();
            this.lblSadrzaj = new System.Windows.Forms.Label();
            this.btnDodajSadrzaj = new System.Windows.Forms.Button();
            this.cbMesta = new System.Windows.Forms.ComboBox();
            this.lblComboMesta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesta)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNazivMesta
            // 
            this.txtNazivMesta.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNazivMesta.Location = new System.Drawing.Point(163, 21);
            this.txtNazivMesta.Name = "txtNazivMesta";
            this.txtNazivMesta.Size = new System.Drawing.Size(176, 28);
            this.txtNazivMesta.TabIndex = 0;
            // 
            // txtValuta
            // 
            this.txtValuta.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValuta.Location = new System.Drawing.Point(163, 81);
            this.txtValuta.Name = "txtValuta";
            this.txtValuta.Size = new System.Drawing.Size(176, 28);
            this.txtValuta.TabIndex = 1;
            // 
            // txtBrojStanovnika
            // 
            this.txtBrojStanovnika.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrojStanovnika.Location = new System.Drawing.Point(163, 138);
            this.txtBrojStanovnika.Name = "txtBrojStanovnika";
            this.txtBrojStanovnika.Size = new System.Drawing.Size(176, 28);
            this.txtBrojStanovnika.TabIndex = 2;
            // 
            // lblNazivMesta
            // 
            this.lblNazivMesta.AutoSize = true;
            this.lblNazivMesta.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivMesta.ForeColor = System.Drawing.Color.White;
            this.lblNazivMesta.Location = new System.Drawing.Point(33, 24);
            this.lblNazivMesta.Name = "lblNazivMesta";
            this.lblNazivMesta.Size = new System.Drawing.Size(113, 21);
            this.lblNazivMesta.TabIndex = 3;
            this.lblNazivMesta.Text = "Naziv mesta";
            // 
            // lblValuta
            // 
            this.lblValuta.AutoSize = true;
            this.lblValuta.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValuta.ForeColor = System.Drawing.Color.White;
            this.lblValuta.Location = new System.Drawing.Point(79, 84);
            this.lblValuta.Name = "lblValuta";
            this.lblValuta.Size = new System.Drawing.Size(67, 21);
            this.lblValuta.TabIndex = 4;
            this.lblValuta.Text = "Valuta";
            // 
            // lblBrojStanovnika
            // 
            this.lblBrojStanovnika.AutoSize = true;
            this.lblBrojStanovnika.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojStanovnika.ForeColor = System.Drawing.Color.White;
            this.lblBrojStanovnika.Location = new System.Drawing.Point(20, 141);
            this.lblBrojStanovnika.Name = "lblBrojStanovnika";
            this.lblBrojStanovnika.Size = new System.Drawing.Size(137, 21);
            this.lblBrojStanovnika.TabIndex = 5;
            this.lblBrojStanovnika.Text = "Broj Stanovnika";
            // 
            // btnDodajMesto
            // 
            this.btnDodajMesto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajMesto.ForeColor = System.Drawing.Color.Black;
            this.btnDodajMesto.Location = new System.Drawing.Point(204, 183);
            this.btnDodajMesto.Name = "btnDodajMesto";
            this.btnDodajMesto.Size = new System.Drawing.Size(135, 34);
            this.btnDodajMesto.TabIndex = 6;
            this.btnDodajMesto.Text = "Dodaj Mesto";
            this.btnDodajMesto.UseVisualStyleBackColor = true;
            // 
            // dgvMesta
            // 
            this.dgvMesta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMesta.Location = new System.Drawing.Point(383, 21);
            this.dgvMesta.MultiSelect = false;
            this.dgvMesta.Name = "dgvMesta";
            this.dgvMesta.ReadOnly = true;
            this.dgvMesta.RowHeadersWidth = 51;
            this.dgvMesta.RowTemplate.Height = 24;
            this.dgvMesta.Size = new System.Drawing.Size(348, 465);
            this.dgvMesta.TabIndex = 7;
            // 
            // txtSadrzaj
            // 
            this.txtSadrzaj.Location = new System.Drawing.Point(163, 235);
            this.txtSadrzaj.Multiline = true;
            this.txtSadrzaj.Name = "txtSadrzaj";
            this.txtSadrzaj.Size = new System.Drawing.Size(176, 123);
            this.txtSadrzaj.TabIndex = 8;
            // 
            // lblSadrzaj
            // 
            this.lblSadrzaj.AutoSize = true;
            this.lblSadrzaj.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSadrzaj.ForeColor = System.Drawing.Color.White;
            this.lblSadrzaj.Location = new System.Drawing.Point(23, 234);
            this.lblSadrzaj.Name = "lblSadrzaj";
            this.lblSadrzaj.Size = new System.Drawing.Size(123, 21);
            this.lblSadrzaj.TabIndex = 9;
            this.lblSadrzaj.Text = "Opis Sadrzaja";
            // 
            // btnDodajSadrzaj
            // 
            this.btnDodajSadrzaj.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajSadrzaj.ForeColor = System.Drawing.Color.Black;
            this.btnDodajSadrzaj.Location = new System.Drawing.Point(245, 431);
            this.btnDodajSadrzaj.Name = "btnDodajSadrzaj";
            this.btnDodajSadrzaj.Size = new System.Drawing.Size(94, 55);
            this.btnDodajSadrzaj.TabIndex = 10;
            this.btnDodajSadrzaj.Text = "Dodaj sadrzaj";
            this.btnDodajSadrzaj.UseVisualStyleBackColor = true;
            // 
            // cbMesta
            // 
            this.cbMesta.FormattingEnabled = true;
            this.cbMesta.Location = new System.Drawing.Point(163, 384);
            this.cbMesta.Name = "cbMesta";
            this.cbMesta.Size = new System.Drawing.Size(176, 25);
            this.cbMesta.TabIndex = 11;
            // 
            // lblComboMesta
            // 
            this.lblComboMesta.AutoSize = true;
            this.lblComboMesta.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComboMesta.ForeColor = System.Drawing.Color.White;
            this.lblComboMesta.Location = new System.Drawing.Point(82, 388);
            this.lblComboMesta.Name = "lblComboMesta";
            this.lblComboMesta.Size = new System.Drawing.Size(64, 21);
            this.lblComboMesta.TabIndex = 12;
            this.lblComboMesta.Text = "Mesta";
            // 
            // UCMesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.lblComboMesta);
            this.Controls.Add(this.cbMesta);
            this.Controls.Add(this.btnDodajSadrzaj);
            this.Controls.Add(this.lblSadrzaj);
            this.Controls.Add(this.txtSadrzaj);
            this.Controls.Add(this.dgvMesta);
            this.Controls.Add(this.btnDodajMesto);
            this.Controls.Add(this.lblBrojStanovnika);
            this.Controls.Add(this.lblValuta);
            this.Controls.Add(this.lblNazivMesta);
            this.Controls.Add(this.txtBrojStanovnika);
            this.Controls.Add(this.txtValuta);
            this.Controls.Add(this.txtNazivMesta);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "UCMesto";
            this.Size = new System.Drawing.Size(747, 517);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtNazivMesta;
        public System.Windows.Forms.TextBox txtValuta;
        public System.Windows.Forms.TextBox txtBrojStanovnika;
        private System.Windows.Forms.Label lblNazivMesta;
        private System.Windows.Forms.Label lblValuta;
        private System.Windows.Forms.Label lblBrojStanovnika;
        public System.Windows.Forms.Button btnDodajMesto;
        public System.Windows.Forms.DataGridView dgvMesta;
        public System.Windows.Forms.TextBox txtSadrzaj;
        private System.Windows.Forms.Label lblSadrzaj;
        public System.Windows.Forms.Button btnDodajSadrzaj;
        public System.Windows.Forms.ComboBox cbMesta;
        private System.Windows.Forms.Label lblComboMesta;
    }
}
