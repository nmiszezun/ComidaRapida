using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComidaRapida
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ingresarButton_Click(object sender, EventArgs e)
        {
            var menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
        }
    }
}
