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
    public partial class PedidoPago : Form
    {
        public PedidoPago()
        {
            InitializeComponent();
        }

        private void medioDePagoLabel_Click(object sender, EventArgs e)
        {

        }

        private void PedidoPago_Load(object sender, EventArgs e)
        {

        }

        private void minPic1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exitPic1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
