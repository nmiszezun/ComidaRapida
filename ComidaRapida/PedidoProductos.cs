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
        List<Pedido> pedidos;
        Pedido pedidoActual;
        DataTable tablaDetalle;

        public PedidoProductos(List<Producto> listaProductos, List<Pedido> pedidos, Pedido pedidoActual)
        {
            this.listaProductos = listaProductos; //temporal, hasta ser reemplazado por una llamada a la BD
            this.pedidos = pedidos; //temporal, hasta ser reemplazado por una llamada a la BD
            this.pedidoActual = pedidoActual; //temporal, hasta ser reemplazado por una llamada a la BD
            InitializeComponent();
            LlenarComboBox();
            CrearDataTable();
            LlenarDataTable();
            MostrarDataTable();
        }

        private void PedidoProductos_Load(object sender, EventArgs e)
        {

        }

        private void CrearDataTable()
        {
            DataColumn columna;
            tablaDetalle = new DataTable("Detalle");

            // agregar columna "cantidad"
            columna = new DataColumn();
            columna.DataType = typeof(Int32);
            columna.ColumnName = "cantidad";
            columna.Caption = "Cant";
            columna.ReadOnly = false;
            columna.Unique = false;
            tablaDetalle.Columns.Add(columna);

            // agregar columna "producto"
            columna = new DataColumn();
            columna.DataType = typeof(String);
            columna.ColumnName = "producto";
            columna.Caption = "Producto";
            columna.ReadOnly = false;
            columna.Unique = false;
            tablaDetalle.Columns.Add(columna);

            // agregar columna "precio"
            columna = new DataColumn();
            columna.DataType = typeof(float);
            columna.ColumnName = "precio";
            columna.Caption = "Precio";
            columna.ReadOnly = false;
            columna.Unique = false;
            tablaDetalle.Columns.Add(columna);
        }

        private void LlenarDataTable()
        {
            DataRow fila;

            foreach (DetallePedido dp in pedidoActual.GetListaProductos())
            {
                fila = tablaDetalle.NewRow();
                fila["cantidad"] = dp.GetCantidad();
                fila["producto"] = dp.GetProducto().GetNombre();
                fila["precio"] = dp.GetPrecio();
                tablaDetalle.Rows.Add(fila);
            }
        }

        private void AgregarUltimaFilaDataTable()
        {
            DetallePedido dp = pedidoActual.GetListaProductos().Last();
            DataRow fila;

            fila = tablaDetalle.NewRow();
            fila["cantidad"] = dp.GetCantidad();
            fila["producto"] = dp.GetProducto().GetNombre();
            fila["precio"] = dp.GetPrecio();
            tablaDetalle.Rows.Add(fila);
        }

        private void MostrarDataTable()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = tablaDetalle;
            pedidoGrid.DataSource = bs;
        }

        private void LlenarComboBox()
        {
            string[] listaComboBox = new string[listaProductos.Count()];
            for (int i = 0; i < listaProductos.Count(); i++)
            {
                listaComboBox[i] = listaProductos.ElementAt(i).ToString();
            }
            agregarComboBox.Items.AddRange(listaComboBox);
        }

        private void ActualizarLista()
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

            CambiarTotal();

            AgregarUltimaFilaDataTable();
            //ActualizarLista();
        }

        private void CambiarTotal()
        {
            float suma = 0;
            foreach (DetallePedido dp in pedidoActual.GetListaProductos())
            {
                suma += dp.GetPrecio();
            }
            totalTextBox.Text = $"$ {suma}";
        }

        private void confirmarButton_Click(object sender, EventArgs e)
        {
            var pp = new PedidoPago(pedidos, pedidoActual);
            pp.Show();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
