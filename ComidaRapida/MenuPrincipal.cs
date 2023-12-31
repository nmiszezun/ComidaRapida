﻿using System;
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
    public partial class MenuPrincipal : Form
    {
        Pedido pedidoActual;
        Usuario usuarioLogueado;

        public MenuPrincipal(Usuario usuario)
        {
            this.pedidoActual = new Pedido();
            this.usuarioLogueado = usuario;
            InitializeComponent();
            bienvenidoLabel.Text = $"Bienvenido, {usuario.GetNombre()}";
        }

        private void nuevoPedidoButton_Click(object sender, EventArgs e)
        {
            pedidoActual = new Pedido();
            pedidoActual.SetUsuario(usuarioLogueado);

            var listaForm = Application.OpenForms.OfType<PedidoProductos>();
            if (listaForm.Count() > 0)
            {
                listaForm.ElementAt(0).Show();
            }
            else
            {
                var pp = new PedidoProductos(pedidoActual);
                pp.Show();
            }
        }

        private void minimizePic_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exitPic_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
