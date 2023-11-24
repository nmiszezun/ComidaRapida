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
    public partial class PedidoConfirmar : Form
    {
        public PedidoConfirmar()
        {
            InitializeComponent();
        }

        private void minimPic_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;   
        }

        private void exPic_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
