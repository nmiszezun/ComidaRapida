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
        Usuario usuarioLogueado;

        public MenuPrincipal(List<Producto> productos, List<Pedido> pedidos, Pedido pedidoActual, Usuario usuario)
        {
            this.productos = productos;
            this.pedidos = pedidos;
            this.pedidoActual = pedidoActual;
            this.usuarioLogueado = usuario;
            InitializeComponent();
        }

        private void nuevoPedidoButton_Click(object sender, EventArgs e)
        {
            pedidoActual.SetUsuario(usuarioLogueado);

            var listaForm = Application.OpenForms.OfType<PedidoProductos>();
            if (listaForm.Count() > 0)
            {
                listaForm.ElementAt(0).Show();
            }
            else
            {
                var pp = new PedidoProductos(productos, pedidos, pedidoActual);
                pp.Show();
            }
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
