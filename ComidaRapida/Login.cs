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
    public partial class Login : Form
    {
        List<Usuario> usuarios;
        List<Producto> productos;
        List<Pedido> pedidos;
        Pedido pedidoActual;

        Usuario usuarioLogueado;

        public Login(List<Usuario> usuarios, List<Producto> productos, List<Pedido> pedidos, Pedido pedidoActual)
        {
            this.usuarios = usuarios;
            this.productos = productos;
            this.pedidos = pedidos;
            this.pedidoActual = pedidoActual;
            InitializeComponent();
        }

        private void ingresarButton_Click(object sender, EventArgs e)
        {
            foreach (Usuario us in usuarios)
            {
                if (us.GetNombre() == usuarioTextBox.Text) {
                    if (us.GetClave() == contraseniaTextBox.Text)
                    {
                        usuarioLogueado = us;
                        break;
                    }
                }
            }

            if (usuarioLogueado != null)
            {
                var listaForm = Application.OpenForms.OfType<MenuPrincipal>();
                if (listaForm.Count() > 0)
                {
                    listaForm.ElementAt(0).Show();
                }
                else
                {
                    var menuPrincipal = new MenuPrincipal(productos, pedidos, pedidoActual, usuarioLogueado);
                    menuPrincipal.Show();
                }
            }
        }

        private void Ingresar_Enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                ingresarButton_Click(sender, e);
            }
        }

        private void usuarioTextBox_MouseEnter(object sender, EventArgs e)
        {
            if (usuarioTextBox.Text == "USUARIO")
            {
                usuarioTextBox.Text = "";
                usuarioTextBox.ForeColor = Color.Gray;
            }
        }
        private void usuarioTextBox_Leave(object sender, EventArgs e)
        {
            if (usuarioTextBox.Text == "")
            {
                usuarioTextBox.Text = "USUARIO";
               // usuarioTextBox.ForeColor = Color.DimGray;
            }
        }

        private void contraseniaTextBox_MouseEnter(object sender, EventArgs e)
        {


            if (contraseniaTextBox.Text == "CONTRASEÑA")
            {
               contraseniaTextBox.Text = "";
               //contraseniaTextBox.ForeColor = Color.Gray;
               contraseniaTextBox.UseSystemPasswordChar = true;
            }

        }

        private void contraseniaTextBox_Leave(object sender, EventArgs e)
        {

            if (contraseniaTextBox.Text == "")
            {
                contraseniaTextBox.Text = "CONTRASEÑA";
                contraseniaTextBox.ForeColor = Color.DimGray;
                contraseniaTextBox.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
