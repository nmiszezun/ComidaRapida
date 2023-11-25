using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ComidaRapida
{
    public partial class PedidoProductos : Form
    {
        List<Producto> listaProductos;
        Pedido pedidoActual;
        DataTable tablaDetalle;

        public PedidoProductos(Pedido pedidoActual)
        {
            this.listaProductos = new List<Producto>();
            this.pedidoActual = pedidoActual; //temporal, hasta ser reemplazado por una llamada a la BD
            InitializeComponent();
            CargarProductos();
            LlenarComboBox();
            CrearDataTable();
            LlenarDataTable();
            MostrarDataTable();
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
            tablaDetalle.Clear();
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

            DataGridViewButtonColumn columnaBorrar = new DataGridViewButtonColumn();
            columnaBorrar.Name = "borrar";
            columnaBorrar.Text = "Borrar ítem";
            columnaBorrar.UseColumnTextForButtonValue = true;
            pedidoGrid.Columns.Insert(3, columnaBorrar);

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

        private void agregarButton_Click(object sender, EventArgs e)
        {
            int indice = agregarComboBox.SelectedIndex;
            int cantidadAgregar = (int)cantidadInput.Value;
            if (indice > 0 && cantidadAgregar > 0)
            {
                Producto productoAgregar = listaProductos.ElementAt(indice);
                cantidadAgregar = (int)cantidadInput.Value;
                pedidoActual.AgregarProducto(productoAgregar, cantidadAgregar);

                CambiarTotal();

                AgregarUltimaFilaDataTable();
            }
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
            var listaForm = Application.OpenForms.OfType<PedidoPago>();
            if (listaForm.Count() > 0)
            {
                listaForm.ElementAt(0).Show();
            }
            else
            {
                var pp = new PedidoPago(pedidoActual);
                pp.Show();
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minPic1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exitPic1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarProductos()
        {
            //variables de configuración
            string ubicacion = $"C:\\ComidaRapida\\productos.txt";
            string texto = "";
            string[] linea;
            string separador = "\t";

            //inicialización de variables
            int id, stock;
            string nombre;
            float precio;
            Producto nuevoProducto;

            //comienzo de lectura línea por línea
            StreamReader sr = new StreamReader(ubicacion);
            while (true)
            {
                texto = sr.ReadLine();

                //sale cuando no quedan líneas por leer
                if (texto == null || texto == "")
                {
                    break;
                }

                //divide la línea en tabulaciones
                linea = texto.Split(separador.ToCharArray());

                //completa las variables según cada tabulación
                id = int.Parse(linea[0]);
                nombre = linea[1];
                stock = int.Parse(linea[2]);
                precio = float.Parse(linea[3]);

                //crea el objeto, y lo carga en la lista
                nuevoProducto = new Producto(id, nombre, stock, precio);
                listaProductos.Add(nuevoProducto);
            }
        }

        private void pedidoGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == pedidoGrid.Columns["borrar"].Index)
            {
                pedidoActual.BorrarProducto(e.RowIndex);
                LlenarDataTable();
                CambiarTotal();
            }
        }
    }
}
