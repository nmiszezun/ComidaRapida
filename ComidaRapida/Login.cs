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
    public partial class Login : Form
    {
        List<Usuario> usuarios;

        Usuario usuarioLogueado;

        public Login()
        {
            this.usuarios = new List<Usuario>();
            InitializeComponent();
            CargarUsuarios();
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
                    var menuPrincipal = new MenuPrincipal(usuarioLogueado);
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

        private void usuarioTextBox_Enter(object sender, EventArgs e)
        {
            usuarioTextBox.SelectAll();
        }

        private void contraseniaTextBox_Enter(object sender, EventArgs e)
        {
            contraseniaTextBox.SelectAll();
        }

        private void CargarUsuarios()
        {
            //variables de configuración
            string ubicacion = $"C:\\ComidaRapida\\usuarios.txt";
            string texto = "";
            string[] linea;
            string separador = "\t";

            //creación de variables
            int id;
            string usuario, clave;
            Usuario nuevoUsuario;

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
                usuario = linea[1];
                clave = linea[2];

                //crea el objeto, y lo carga en la lista
                nuevoUsuario = new Usuario(id, usuario, clave);
                usuarios.Add(nuevoUsuario);
            }
        }


    }
}
