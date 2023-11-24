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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void nuevoPedidoButton_Click(object sender, EventArgs e)
        {
           
            var pedido = new PedidoProductos();
            pedido.Show();
        }

        private void minimizePic_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exitPic_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
