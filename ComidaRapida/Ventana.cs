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
    public partial class Ventana : Form
    {
        public Ventana(List<Producto> productos, List<Pedido> pedidos)
        {
            InitializeComponent();
            MostrarPantalla("login");
        }

        public void MostrarPantalla (string pantalla)
        {
            login1.Hide();
            menuPrincipal1.Hide();
            pedidoProductos1.Hide();
            pedidoPago1.Hide();
            pedidoConfirmar1.Hide();

            switch(pantalla)
            {
                case "login": login1.Show(); break;
                case "menu principal": menuPrincipal1.Show(); break;
                case "pedido productos": pedidoProductos1.Show(); break;
                case "pedido pago": pedidoPago1.Show(); break;
                case "pedido confirmar": pedidoConfirmar1.Show(); break;
                default: break;
            }
        }
    }
}
