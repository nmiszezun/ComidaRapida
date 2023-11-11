
namespace ComidaRapida
{
    partial class MenuPrincipal
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
            this.nuevoPedidoButton = new System.Windows.Forms.Button();
            this.productosButton = new System.Windows.Forms.Button();
            this.salirButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nuevoPedidoButton
            // 
            this.nuevoPedidoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoPedidoButton.Location = new System.Drawing.Point(194, 78);
            this.nuevoPedidoButton.Name = "nuevoPedidoButton";
            this.nuevoPedidoButton.Size = new System.Drawing.Size(386, 52);
            this.nuevoPedidoButton.TabIndex = 0;
            this.nuevoPedidoButton.Text = "Nuevo pedido";
            this.nuevoPedidoButton.UseVisualStyleBackColor = true;
            this.nuevoPedidoButton.Click += new System.EventHandler(this.nuevoPedidoButton_Click);
            // 
            // productosButton
            // 
            this.productosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productosButton.Location = new System.Drawing.Point(194, 188);
            this.productosButton.Name = "productosButton";
            this.productosButton.Size = new System.Drawing.Size(386, 52);
            this.productosButton.TabIndex = 1;
            this.productosButton.Text = "Productos";
            this.productosButton.UseVisualStyleBackColor = true;
            // 
            // salirButton
            // 
            this.salirButton.BackColor = System.Drawing.Color.Red;
            this.salirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirButton.ForeColor = System.Drawing.Color.White;
            this.salirButton.Location = new System.Drawing.Point(12, 386);
            this.salirButton.Name = "salirButton";
            this.salirButton.Size = new System.Drawing.Size(200, 52);
            this.salirButton.TabIndex = 2;
            this.salirButton.Text = "Salir";
            this.salirButton.UseVisualStyleBackColor = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.salirButton);
            this.Controls.Add(this.productosButton);
            this.Controls.Add(this.nuevoPedidoButton);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button nuevoPedidoButton;
        private System.Windows.Forms.Button productosButton;
        private System.Windows.Forms.Button salirButton;
    }
}