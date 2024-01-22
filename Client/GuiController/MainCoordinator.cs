﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Client.GuiController
{
    public class MainCoordinator
    {
        private bool isDragging;
        private Point lastCursorPos;
        private Point lastFormPos;
        private static MainCoordinator instance;
        public static MainCoordinator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MainCoordinator();
                }
                return instance;
            }
        }

        private MainCoordinator()
        {
            mestoGuiController = new MestoGuiController();
        }
        private FrmMain frmMain;
        private MestoGuiController mestoGuiController;

        internal void ShowFrmMain(string ime, string prezime)
        {
            frmMain = new FrmMain();

            frmMain.pnlMarker.Height = frmMain.btnPocetna.Height;
            frmMain.pnlMarker.Top = frmMain.btnPocetna.Top;
            frmMain.pnlMarker.Left = frmMain.btnPocetna.Left;
            frmMain.btnPocetna.BackColor = Color.FromArgb(46, 51, 73);
            frmMain.lblUsername.Text = ime + " " + prezime;
            frmMain.ShowDialog();
            //frmMain.btnPocetna.PerformClick();  
        }
        #region navMenu
        internal void Aranzman(object sender, EventArgs e)
        {
            frmMain.pnlMarker.Height = frmMain.btnAranzman.Height;
            frmMain.pnlMarker.Top = frmMain.btnAranzman.Top;
            frmMain.pnlMarker.Left = frmMain.btnAranzman.Left;
            frmMain.btnAranzman.BackColor = Color.FromArgb(46, 51, 73);
        }

        internal void Vodic(object sender, EventArgs e)
        {
            frmMain.pnlMarker.Height = frmMain.btnVodic.Height;
            frmMain.pnlMarker.Top = frmMain.btnVodic.Top;
            frmMain.pnlMarker.Left = frmMain.btnVodic.Left;
            frmMain.btnVodic.BackColor = Color.FromArgb(46, 51, 73);
        }

        internal void Termin(object sender, EventArgs e)
        {
            frmMain.pnlMarker.Height = frmMain.btnTermin.Height;
            frmMain.pnlMarker.Top = frmMain.btnTermin.Top;
            frmMain.pnlMarker.Left = frmMain.btnTermin.Left;
            frmMain.btnTermin.BackColor = Color.FromArgb(46, 51, 73);
        }

        internal void Pocetna(object sender, EventArgs e)
        {
            frmMain.pnlMarker.Height = frmMain.btnPocetna.Height;
            frmMain.pnlMarker.Top = frmMain.btnPocetna.Top;
            frmMain.pnlMarker.Left = frmMain.btnPocetna.Left;
            frmMain.btnPocetna.BackColor = Color.FromArgb(46, 51, 73);
        }

        internal void Mesto(object sender, EventArgs e)
        {
            frmMain.pnlMarker.Height = frmMain.btnMesto.Height;
            frmMain.pnlMarker.Top = frmMain.btnMesto.Top;
            frmMain.pnlMarker.Left = frmMain.btnMesto.Left;
            frmMain.btnMesto.BackColor = Color.FromArgb(46, 51, 73);
        }

        internal void Logout(object sender, EventArgs e)
        {
            frmMain.pnlMarker.Height = frmMain.btnLogout.Height;
            frmMain.pnlMarker.Top = frmMain.btnLogout.Top;
            frmMain.pnlMarker.Left = frmMain.btnLogout.Left;
            frmMain.btnLogout.BackColor = Color.FromArgb(46, 51, 73);
        }
        #endregion
        #region resetNavMenu
        internal void AranzmanReset(object sender, EventArgs e)
        {
            frmMain.btnAranzman.BackColor = Color.FromArgb(24, 30, 54);
        }

        internal void MestoReset(object sender, EventArgs e)
        {
            frmMain.btnMesto.BackColor = Color.FromArgb(24, 30, 54);
        }

        internal void PocetnaReset(object sender, EventArgs e)
        {
            frmMain.btnPocetna.BackColor = Color.FromArgb(24, 30, 54);
        }

        internal void TerminReset(object sender, EventArgs e)
        {
            frmMain.btnTermin.BackColor = Color.FromArgb(24, 30, 54);
        }

        internal void VodicReset(object sender, EventArgs e)
        {
            frmMain.btnVodic.BackColor = Color.FromArgb(24, 30, 54);
        }

        internal void LogoutReset(object sender, EventArgs e)
        {
            frmMain.btnLogout.BackColor = Color.FromArgb(24, 30, 54);
        }
        #endregion
        #region windows manipulation
        internal void UgasiFormu(object sender, EventArgs e)
        {
            frmMain.Close();
        }

        internal void Maximize(object sender, EventArgs e)
        {
            if (frmMain.WindowState == System.Windows.Forms.FormWindowState.Maximized)
            {
                frmMain.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
            else
            {
                frmMain.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            }
            
        }

        internal void Minimize(object sender, EventArgs e)
        {
            frmMain.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }
        internal void KursorKraj(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        internal void KursorKretanje(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = Cursor.Position.X - lastCursorPos.X;
                int deltaY = Cursor.Position.Y - lastCursorPos.Y;

                frmMain.Location = new Point(lastFormPos.X + deltaX, lastFormPos.Y + deltaY);
            }
        }

        internal void KursorKlik(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastCursorPos = Cursor.Position;
            lastFormPos = frmMain.Location;
        }
        #endregion
        internal void DodajMesto(object sender, EventArgs e)
        {
            frmMain.ChangePanel(mestoGuiController.KreirajDodajMesto());
        }
    }
}
