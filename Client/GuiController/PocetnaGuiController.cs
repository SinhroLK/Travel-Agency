using Client.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.GuiController
{
    internal class PocetnaGuiController
    {
        private UCPocetna ucPocetna;

        internal Control KreirajPocetnu()
        {
            ucPocetna = new UCPocetna();
            return ucPocetna;
        }
    }
}
