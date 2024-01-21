namespace Client
{
    partial class FrmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlMarker = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnTermin = new System.Windows.Forms.Button();
            this.btnAranzman = new System.Windows.Forms.Button();
            this.btnVodic = new System.Windows.Forms.Button();
            this.btnMesto = new System.Windows.Forms.Button();
            this.btnPocetna = new System.Windows.Forms.Button();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMenu.SuspendLayout();
            this.pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlMenu.Controls.Add(this.pnlMarker);
            this.pnlMenu.Controls.Add(this.btnLogout);
            this.pnlMenu.Controls.Add(this.btnTermin);
            this.pnlMenu.Controls.Add(this.btnAranzman);
            this.pnlMenu.Controls.Add(this.btnVodic);
            this.pnlMenu.Controls.Add(this.btnMesto);
            this.pnlMenu.Controls.Add(this.btnPocetna);
            this.pnlMenu.Controls.Add(this.pnlUser);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(186, 553);
            this.pnlMenu.TabIndex = 0;
            // 
            // pnlMarker
            // 
            this.pnlMarker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlMarker.Location = new System.Drawing.Point(0, 193);
            this.pnlMarker.Name = "pnlMarker";
            this.pnlMarker.Size = new System.Drawing.Size(3, 100);
            this.pnlMarker.TabIndex = 3;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnLogout.Image = global::Client.Properties.Resources.log_out;
            this.btnLogout.Location = new System.Drawing.Point(0, 469);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(186, 69);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Log out";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnTermin
            // 
            this.btnTermin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTermin.FlatAppearance.BorderSize = 0;
            this.btnTermin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTermin.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTermin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnTermin.Image = global::Client.Properties.Resources.calendar;
            this.btnTermin.Location = new System.Drawing.Point(0, 400);
            this.btnTermin.Name = "btnTermin";
            this.btnTermin.Size = new System.Drawing.Size(186, 69);
            this.btnTermin.TabIndex = 1;
            this.btnTermin.Text = "Termini";
            this.btnTermin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTermin.UseVisualStyleBackColor = true;
            // 
            // btnAranzman
            // 
            this.btnAranzman.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAranzman.FlatAppearance.BorderSize = 0;
            this.btnAranzman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAranzman.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAranzman.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAranzman.Image = global::Client.Properties.Resources.Conact;
            this.btnAranzman.Location = new System.Drawing.Point(0, 331);
            this.btnAranzman.Name = "btnAranzman";
            this.btnAranzman.Size = new System.Drawing.Size(186, 69);
            this.btnAranzman.TabIndex = 1;
            this.btnAranzman.Text = "Aranžmani";
            this.btnAranzman.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAranzman.UseVisualStyleBackColor = true;
            // 
            // btnVodic
            // 
            this.btnVodic.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVodic.FlatAppearance.BorderSize = 0;
            this.btnVodic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVodic.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVodic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnVodic.Image = global::Client.Properties.Resources.male;
            this.btnVodic.Location = new System.Drawing.Point(0, 262);
            this.btnVodic.Name = "btnVodic";
            this.btnVodic.Size = new System.Drawing.Size(186, 69);
            this.btnVodic.TabIndex = 1;
            this.btnVodic.Text = "Vodiči";
            this.btnVodic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVodic.UseVisualStyleBackColor = true;
            // 
            // btnMesto
            // 
            this.btnMesto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMesto.FlatAppearance.BorderSize = 0;
            this.btnMesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesto.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnMesto.Image = global::Client.Properties.Resources.gps;
            this.btnMesto.Location = new System.Drawing.Point(0, 193);
            this.btnMesto.Name = "btnMesto";
            this.btnMesto.Size = new System.Drawing.Size(186, 69);
            this.btnMesto.TabIndex = 1;
            this.btnMesto.Text = "Mesta";
            this.btnMesto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMesto.UseVisualStyleBackColor = true;
            // 
            // btnPocetna
            // 
            this.btnPocetna.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPocetna.FlatAppearance.BorderSize = 0;
            this.btnPocetna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPocetna.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPocetna.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnPocetna.Image = global::Client.Properties.Resources.home;
            this.btnPocetna.Location = new System.Drawing.Point(0, 124);
            this.btnPocetna.Name = "btnPocetna";
            this.btnPocetna.Size = new System.Drawing.Size(186, 69);
            this.btnPocetna.TabIndex = 1;
            this.btnPocetna.Text = "Početna strana";
            this.btnPocetna.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPocetna.UseVisualStyleBackColor = true;
            // 
            // pnlUser
            // 
            this.pnlUser.Controls.Add(this.lblUsername);
            this.pnlUser.Controls.Add(this.pictureBox1);
            this.pnlUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUser.Location = new System.Drawing.Point(0, 0);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(186, 124);
            this.pnlUser.TabIndex = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblUsername.Location = new System.Drawing.Point(36, 88);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(108, 23);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Client.Properties.Resources.Untitled_11;
            this.pictureBox1.Location = new System.Drawing.Point(60, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(933, 553);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "Turisticka Agencija";
            this.pnlMenu.ResumeLayout(false);
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlUser;
        public System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btnPocetna;
        public System.Windows.Forms.Button btnMesto;
        public System.Windows.Forms.Button btnTermin;
        public System.Windows.Forms.Button btnAranzman;
        public System.Windows.Forms.Button btnVodic;
        public System.Windows.Forms.Button btnLogout;
        public System.Windows.Forms.Panel pnlMarker;
    }
}