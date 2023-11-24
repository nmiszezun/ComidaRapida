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
        List<Pedido> pedidos;
        Pedido pedidoActual;
        float pagado;
        float vuelto;

        public PedidoPago(List<Pedido> pedidos, Pedido pedidoActual)
        {
            this.pedidos = pedidos;
            this.pedidoActual = pedidoActual;
            InitializeComponent();
            importeTotalTextBox.Text = $"$ {pedidoActual.GetPago().GetImporteTotal()}";
            efectivoRadioButton.Checked = true;
            SeleccionarEfectivo();
        }

        private void SeleccionarEfectivo ()
        {
            pagadoTextBox.ReadOnly = false;

            numeroTextBox.ReadOnly = true;
            nombreTextBox.ReadOnly = true;
        }

        private void SeleccionarTarjeta ()
        {
            pagadoTextBox.ReadOnly = true;

            numeroTextBox.ReadOnly = false;
            nombreTextBox.ReadOnly = false;
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

        private void confirmarButton_Click(object sender, EventArgs e)
        {
            if (efectivoRadioButton.Checked == true)
            {
                PagoEfectivo pe = new PagoEfectivo(
                    pedidoActual.GetPago().GetImporteTotal(),
                    pagado,
                    vuelto);
                pedidoActual.SetPago(pe);
            }
            else
            {
                PagoTarjeta pt = new PagoTarjeta(
                    pedidoActual.GetPago().GetImporteTotal(),
                    numeroTextBox.Text,
                    nombreTextBox.Text);
                pedidoActual.SetPago(pt);
            }

            var listaForm = Application.OpenForms.OfType<PedidoConfirmar>();
            if (listaForm.Count() > 0)
            {
                listaForm.ElementAt(0).Show();
            }
            else
            {
                var pc = new PedidoConfirmar(pedidos, pedidoActual);
                pc.Show();
            }
        }

        private void pagadoTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pagado = float.Parse(pagadoTextBox.Text);
                vuelto = pagado - pedidoActual.GetPago().GetImporteTotal();
                vueltoTextBox.Text = $"$ {vuelto}";
            }
            catch (Exception expt)
            {
                MessageBox.Show("El valor ingresado es incorrecto.");
                pagadoTextBox.Text = "";
            }
        }

        private void efectivoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SeleccionarEfectivo();
        }

        private void tarjetaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SeleccionarTarjeta();
        }

        private void volverButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
