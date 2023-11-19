
namespace ComidaRapida
{
    partial class Ventana
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.login1 = new ComidaRapida.Login();
            this.menuPrincipal1 = new ComidaRapida.MenuPrincipal();
            this.pedidoConfirmar1 = new ComidaRapida.PedidoConfirmar();
            this.pedidoPago1 = new ComidaRapida.PedidoPago();
            this.pedidoProductos1 = new ComidaRapida.PedidoProductos();
            this.SuspendLayout();
            // 
            // login1
            // 
            this.login1.Location = new System.Drawing.Point(0, 0);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(750, 550);
            this.login1.TabIndex = 0;
            // 
            // menuPrincipal1
            // 
            this.menuPrincipal1.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal1.Name = "menuPrincipal1";
            this.menuPrincipal1.Size = new System.Drawing.Size(750, 550);
            this.menuPrincipal1.TabIndex = 1;
            // 
            // pedidoConfirmar1
            // 
            this.pedidoConfirmar1.Location = new System.Drawing.Point(0, 0);
            this.pedidoConfirmar1.Name = "pedidoConfirmar1";
            this.pedidoConfirmar1.Size = new System.Drawing.Size(750, 550);
            this.pedidoConfirmar1.TabIndex = 2;
            // 
            // pedidoPago1
            // 
            this.pedidoPago1.Location = new System.Drawing.Point(0, 0);
            this.pedidoPago1.Name = "pedidoPago1";
            this.pedidoPago1.Size = new System.Drawing.Size(750, 550);
            this.pedidoPago1.TabIndex = 3;
            // 
            // pedidoProductos1
            // 
            this.pedidoProductos1.Location = new System.Drawing.Point(0, 0);
            this.pedidoProductos1.Name = "pedidoProductos1";
            this.pedidoProductos1.Size = new System.Drawing.Size(750, 550);
            this.pedidoProductos1.TabIndex = 4;
            // 
            // Ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.login1);
            this.Controls.Add(this.pedidoProductos1);
            this.Controls.Add(this.pedidoPago1);
            this.Controls.Add(this.pedidoConfirmar1);
            this.Controls.Add(this.menuPrincipal1);
            this.Name = "Ventana";
            this.Text = "Ventana";
            this.ResumeLayout(false);

        }

        #endregion

        private Login login1;
        private MenuPrincipal menuPrincipal1;
        private PedidoConfirmar pedidoConfirmar1;
        private PedidoPago pedidoPago1;
        private PedidoProductos pedidoProductos1;
    }
}