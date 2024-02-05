using Client.UserControls;
using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.GuiController
{
    public class TerminGuiController
    {
        private UCTermin ucTermin;
        Termin Termin;

        internal Control KreirajDodajTermin()
        {
            ucTermin = new UCTermin();
            ucTermin.btnDodaj.Click += DodajTermin;
            return ucTermin;
        }

        private void DodajTermin(object sender, EventArgs e)
        {
            Aranzman aranzman = ucTermin.cbAranzman.SelectedItem as Aranzman;
            Vodic vodic = ucTermin.cbVodic.SelectedItem as Vodic;
            bool provera = vodic != null && aranzman != null && ucTermin.mcDatumDo.SelectionStart.Date > ucTermin.mcDatumOd.SelectionStart.Date && ucTermin.mcDatumOd.SelectionStart.Date > DateTime.Now.Date && ucTermin.mcDatumDo.SelectionStart.Date > DateTime.Now.Date;
            if (provera)
            {
                Termin termin = new Termin
                {
                    Aranzman = aranzman,
                    Vodic = vodic,
                    DatumOd = ucTermin.mcDatumOd.SelectionStart,
                    DatumDo = ucTermin.mcDatumDo.SelectionStart
                };
                Response response = Communication.Instance.KreirajTermin(termin);
            }
        }
    }
}
