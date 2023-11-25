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
        float pagado;
        float vuelto;

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
            pagadoTextBox.TabStop = true;

            numeroTextBox.ReadOnly = true;
            numeroTextBox.TabStop = false;
            nombreTextBox.ReadOnly = true;
            nombreTextBox.TabStop = false;
        }

        private void SeleccionarTarjeta ()
        {
            pagadoTextBox.ReadOnly = true;
            pagadoTextBox.TabStop = false;

            numeroTextBox.ReadOnly = false;
            numeroTextBox.TabStop = true;
            nombreTextBox.ReadOnly = false;
            nombreTextBox.TabStop = true;
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
            bool pagoCorrecto = true;
            if (efectivoRadioButton.Checked == true)
            {
                if (pagado < pedidoActual.GetPago().GetImporteTotal())
                {
                    MessageBox.Show("El pago es insuficiente. Ingrese un importe igual o mayor al total.");
                    pagoCorrecto = false;
                } else
                {
                    PagoEfectivo pe = new PagoEfectivo(
                        pedidoActual.GetPago().GetImporteTotal(),
                        pagado,
                        vuelto);
                    pedidoActual.SetPago(pe);
                }
            }
            else
            {
                PagoTarjeta pt = new PagoTarjeta(
                    pedidoActual.GetPago().GetImporteTotal(),
                    numeroTextBox.Text,
                    nombreTextBox.Text);
                pedidoActual.SetPago(pt);
            }

            if (pagoCorrecto)
            {
                var listaForm = Application.OpenForms.OfType<PedidoConfirmar>();
                if (listaForm.Count() > 0)
                {
                    listaForm.ElementAt(0).Show();
                }
                else
                {
                    var pc = new PedidoConfirmar(pedidoActual);
                    pc.Show();
                }
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
