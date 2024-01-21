namespace Client.UserControls
{
    partial class UCDodajMesto
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesta)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNazivMesta
            // 
            this.txtNazivMesta.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNazivMesta.Location = new System.Drawing.Point(182, 146);
            this.txtNazivMesta.Name = "txtNazivMesta";
            this.txtNazivMesta.Size = new System.Drawing.Size(102, 28);
            this.txtNazivMesta.TabIndex = 0;
            // 
            // txtValuta
            // 
            this.txtValuta.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValuta.Location = new System.Drawing.Point(182, 206);
            this.txtValuta.Name = "txtValuta";
            this.txtValuta.Size = new System.Drawing.Size(102, 28);
            this.txtValuta.TabIndex = 1;
            // 
            // txtBrojStanovnika
            // 
            this.txtBrojStanovnika.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrojStanovnika.Location = new System.Drawing.Point(182, 263);
            this.txtBrojStanovnika.Name = "txtBrojStanovnika";
            this.txtBrojStanovnika.Size = new System.Drawing.Size(102, 28);
            this.txtBrojStanovnika.TabIndex = 2;
            // 
            // lblNazivMesta
            // 
            this.lblNazivMesta.AutoSize = true;
            this.lblNazivMesta.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivMesta.ForeColor = System.Drawing.Color.White;
            this.lblNazivMesta.Location = new System.Drawing.Point(42, 153);
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
            this.lblValuta.Location = new System.Drawing.Point(88, 213);
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
            this.lblBrojStanovnika.Location = new System.Drawing.Point(29, 270);
            this.lblBrojStanovnika.Name = "lblBrojStanovnika";
            this.lblBrojStanovnika.Size = new System.Drawing.Size(137, 21);
            this.lblBrojStanovnika.TabIndex = 5;
            this.lblBrojStanovnika.Text = "Broj Stanovnika";
            // 
            // btnDodajMesto
            // 
            this.btnDodajMesto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajMesto.ForeColor = System.Drawing.Color.Black;
            this.btnDodajMesto.Location = new System.Drawing.Point(182, 305);
            this.btnDodajMesto.Name = "btnDodajMesto";
            this.btnDodajMesto.Size = new System.Drawing.Size(102, 33);
            this.btnDodajMesto.TabIndex = 6;
            this.btnDodajMesto.Text = "Dodaj Mesto";
            this.btnDodajMesto.UseVisualStyleBackColor = true;
            // 
            // dgvMesta
            // 
            this.dgvMesta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMesta.Location = new System.Drawing.Point(310, 146);
            this.dgvMesta.Name = "dgvMesta";
            this.dgvMesta.RowHeadersWidth = 51;
            this.dgvMesta.RowTemplate.Height = 24;
            this.dgvMesta.Size = new System.Drawing.Size(405, 192);
            this.dgvMesta.TabIndex = 7;
            // 
            // UCDodajMesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
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
            this.Name = "UCDodajMesto";
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
    }
}
