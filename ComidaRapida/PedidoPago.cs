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
        Pedido pedidoActual;

        public PedidoPago(Pedido pedidoActual)
        {
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
                    float.Parse(pagadoTextBox.Text),
                    float.Parse(vueltoTextBox.Text));
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
        }

        private void pagadoTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float pagado = float.Parse(pagadoTextBox.Text);
                vueltoTextBox.Text = $"$ {(pagado - pedidoActual.GetPago().GetImporteTotal()).ToString()}";
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
    }
}
