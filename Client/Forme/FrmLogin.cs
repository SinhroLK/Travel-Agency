using Client.GuiController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            Color backgroundColor = Color.FromArgb(46, 51, 73);
            this.BackColor = backgroundColor;
            btnLogin.Click += LoginGuiController.Instance.Login;
        }
    }
}
