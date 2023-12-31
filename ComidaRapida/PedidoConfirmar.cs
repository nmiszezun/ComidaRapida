﻿using System;
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
    public partial class PedidoConfirmar : Form
    {
        Pedido pedidoActual;
        int ultimoNumeroTicket;

        public PedidoConfirmar(Pedido pedidoActual)
        {
            this.pedidoActual = pedidoActual;
            InitializeComponent();
            MostrarValores();
        }

        private void MostrarValores ()
        {
            string texto = "";
            foreach (DetallePedido dp in pedidoActual.GetListaProductos())
            {
                texto += dp.ToString();
                texto += "\r\n";
            }
            pedidoTextBox.Text = texto;

            pagoTextBox.Text = pedidoActual.GetPago().ToString();
        }

        private void minimPic_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;   
        }

        private void exPic_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editarPedidoButton_Click(object sender, EventArgs e)
        {
            Application.OpenForms.OfType<PedidoProductos>().ElementAt(0).Show();
            this.Close();
        }

        private void editarPagoButton_Click(object sender, EventArgs e)
        {
            Application.OpenForms.OfType<PedidoPago>().ElementAt(0).Show();
            this.Close();
        }

        private void cancelarPedidoButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("¿Está seguro que desea cancelar?", "Confirmar.", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                pedidoActual = new Pedido();
                VolverAMenuPrincipal();
            }
        }

        private void LeerNumeroTicket()
        {
            string linea;
            string ubicacion = $"C:\\ComidaRapida\\ultimoNumero.txt";
            StreamReader sr = new StreamReader(ubicacion);

            linea = sr.ReadLine();
            ultimoNumeroTicket = int.Parse(linea);
            sr.Close();
        }

        private void emitirButton_Click(object sender, EventArgs e)
        {
            LeerNumeroTicket();
            ultimoNumeroTicket++;
            pedidoActual.SetNumero(ultimoNumeroTicket);
            ActualizarNumeroTicket();
            pedidoActual.SetFechaHora(DateTime.Now);
            ImprimirTicket();
            pedidoActual = new Pedido();
            VolverAMenuPrincipal();
        }

        private void ActualizarNumeroTicket()
        {
            string ubicacion = $"C:\\ComidaRapida\\ultimoNumero.txt";
            StreamWriter sw = new StreamWriter(ubicacion);
            sw.Write(ultimoNumeroTicket);
            sw.Close();
        }

        private void ImprimirTicket()
        {
            List<string> listaTexto = new List<string>();
            listaTexto.Add("Comida Veloz S.A.");
            listaTexto.Add("CUIT 33-0303456-0");
            listaTexto.Add("IVA Responsable Inscripto");
            listaTexto.Add("");
            listaTexto.Add("Ticket factura tipo B");
            listaTexto.Add("A consumidor final");
            listaTexto.Add("");
            listaTexto.Add($"Ticket número {pedidoActual.GetNumero()}");
            listaTexto.Add($"{pedidoActual.GetFechaHora()}");
            listaTexto.Add("Detalle:");
            foreach (DetallePedido dp in pedidoActual.GetListaProductos())
            {
                listaTexto.Add($"{dp.GetCantidad()} x {dp.GetProducto().GetNombre()} ..... {dp.GetPrecio()}");
            }
            listaTexto.Add($"Total: $ {pedidoActual.GetPago().GetImporteTotal()}");
            listaTexto.Add("");
            listaTexto.Add($"Cajero: {pedidoActual.GetUsuario().GetNombre()}");
            listaTexto.Add($"Pago: {pedidoActual.GetPago().ToString()}");
            listaTexto.Add("");
            listaTexto.Add("¡Muchas gracias por su compra!");

            string texto = "";

            foreach (string linea in listaTexto)
            {
                texto += linea + "\n";
            }

            MessageBox.Show(texto);

            texto += "##########\n\n";

            string ubicacion = $"C:\\ComidaRapida\\tickets.txt";
            StreamWriter sw = new StreamWriter(ubicacion, append: true);
            sw.Write(texto);
            sw.Close();
        }

        private void VolverAMenuPrincipal ()
        {
            Application.OpenForms.OfType<PedidoProductos>().ElementAt(0).Close();
            Application.OpenForms.OfType<PedidoPago>().ElementAt(0).Close();
            Application.OpenForms.OfType<MenuPrincipal>().ElementAt(0).Show();
            this.Close();
        }
    }
}
