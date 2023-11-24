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
    public partial class PedidoProductos : Form
    {
        List<Producto> listaProductos;
        Pedido pedidoActual;

        public PedidoProductos(List<Producto> listaProductos, Pedido pedidoActual)
        {
            this.listaProductos = listaProductos; //temporal, hasta ser reemplazado por una llamada a la BD
            this.pedidoActual = pedidoActual; //temporal, hasta ser reemplazado por una llamada a la BD
            InitializeComponent();
            llenarComboBox();
        }

        private void PedidoProductos_Load(object sender, EventArgs e)
        {

        }

        private void llenarComboBox()
        {
            string[] listaComboBox = new string[listaProductos.Count()];
            for (int i = 0; i < listaProductos.Count(); i++)
            {
                listaComboBox[i] = listaProductos.ElementAt(i).ToString();
            }
            agregarComboBox.Items.AddRange(listaComboBox);
        }

        private void actualizarLista()
        {
            // los valores están en el grid, pero no los muestra

            /*pedidoGrid.Rows.Clear();
            DataGridViewRow dgvr = new DataGridViewRow();
            foreach (DetallePedido dp in pedidoActual.GetListaProductos())
            {
                pedidoGrid.Rows.Add(new string[] { dp.GetCantidad().ToString(), dp.GetProducto().GetNombre(), dp.GetPrecio().ToString() });
            }
            pedidoGrid.Refresh();
            pedidoGrid.Update();*/
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            Producto productoAgregar = listaProductos.ElementAt(agregarComboBox.SelectedIndex);
            int cantidadAgregar = (int)cantidadInput.Value;
            pedidoActual.AddProducto(productoAgregar, cantidadAgregar);

            actualizarLista();
        }
    }
}
