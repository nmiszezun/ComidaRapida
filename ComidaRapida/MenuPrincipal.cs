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
        List<Producto> productos;
        List<Pedido> pedidos;
        Pedido pedidoActual;

        public MenuPrincipal(List<Producto> productos, List<Pedido> pedidos, Pedido pedidoActual)
        {
            this.productos = productos;
            this.pedidos = pedidos;
            this.pedidoActual = pedidoActual;
            InitializeComponent();
        }

        private void nuevoPedidoButton_Click(object sender, EventArgs e)
        {
            var pp = new PedidoProductos(productos, pedidoActual);
            pp.Show();
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
