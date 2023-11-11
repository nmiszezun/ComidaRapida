
namespace ComidaRapida
{
    partial class PedidoConfirmar
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
            this.chequearPedidoLabel = new System.Windows.Forms.Label();
            this.pedidoTextBox = new System.Windows.Forms.TextBox();
            this.chequearPagoLabel = new System.Windows.Forms.Label();
            this.pagoTextBox = new System.Windows.Forms.TextBox();
            this.emitirButton = new System.Windows.Forms.Button();
            this.cancelarPedidoButton = new System.Windows.Forms.Button();
            this.editarPedidoButton = new System.Windows.Forms.Button();
            this.editarPagoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chequearPedidoLabel
            // 
            this.chequearPedidoLabel.AutoSize = true;
            this.chequearPedidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chequearPedidoLabel.Location = new System.Drawing.Point(30, 29);
            this.chequearPedidoLabel.Name = "chequearPedidoLabel";
            this.chequearPedidoLabel.Size = new System.Drawing.Size(221, 31);
            this.chequearPedidoLabel.TabIndex = 0;
            this.chequearPedidoLabel.Text = "Chequear pedido";
            // 
            // pedidoTextBox
            // 
            this.pedidoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pedidoTextBox.Location = new System.Drawing.Point(36, 85);
            this.pedidoTextBox.Multiline = true;
            this.pedidoTextBox.Name = "pedidoTextBox";
            this.pedidoTextBox.ReadOnly = true;
            this.pedidoTextBox.Size = new System.Drawing.Size(517, 129);
            this.pedidoTextBox.TabIndex = 1;
            // 
            // chequearPagoLabel
            // 
            this.chequearPagoLabel.AutoSize = true;
            this.chequearPagoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chequearPagoLabel.Location = new System.Drawing.Point(30, 247);
            this.chequearPagoLabel.Name = "chequearPagoLabel";
            this.chequearPagoLabel.Size = new System.Drawing.Size(200, 31);
            this.chequearPagoLabel.TabIndex = 2;
            this.chequearPagoLabel.Text = "Chequear pago";
            // 
            // pagoTextBox
            // 
            this.pagoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagoTextBox.Location = new System.Drawing.Point(36, 294);
            this.pagoTextBox.Name = "pagoTextBox";
            this.pagoTextBox.ReadOnly = true;
            this.pagoTextBox.Size = new System.Drawing.Size(517, 22);
            this.pagoTextBox.TabIndex = 3;
            // 
            // emitirButton
            // 
            this.emitirButton.BackColor = System.Drawing.Color.DarkGreen;
            this.emitirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emitirButton.ForeColor = System.Drawing.Color.White;
            this.emitirButton.Location = new System.Drawing.Point(494, 386);
            this.emitirButton.Name = "emitirButton";
            this.emitirButton.Size = new System.Drawing.Size(294, 52);
            this.emitirButton.TabIndex = 14;
            this.emitirButton.Text = "Confirmar y emitir factura";
            this.emitirButton.UseVisualStyleBackColor = false;
            // 
            // cancelarPedidoButton
            // 
            this.cancelarPedidoButton.BackColor = System.Drawing.Color.Red;
            this.cancelarPedidoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarPedidoButton.ForeColor = System.Drawing.Color.White;
            this.cancelarPedidoButton.Location = new System.Drawing.Point(12, 386);
            this.cancelarPedidoButton.Name = "cancelarPedidoButton";
            this.cancelarPedidoButton.Size = new System.Drawing.Size(200, 52);
            this.cancelarPedidoButton.TabIndex = 13;
            this.cancelarPedidoButton.Text = "Cancelar pedido";
            this.cancelarPedidoButton.UseVisualStyleBackColor = false;
            // 
            // editarPedidoButton
            // 
            this.editarPedidoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarPedidoButton.Location = new System.Drawing.Point(580, 120);
            this.editarPedidoButton.Name = "editarPedidoButton";
            this.editarPedidoButton.Size = new System.Drawing.Size(191, 52);
            this.editarPedidoButton.TabIndex = 15;
            this.editarPedidoButton.Text = "Editar pedido";
            this.editarPedidoButton.UseVisualStyleBackColor = true;
            // 
            // editarPagoButton
            // 
            this.editarPagoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarPagoButton.Location = new System.Drawing.Point(580, 276);
            this.editarPagoButton.Name = "editarPagoButton";
            this.editarPagoButton.Size = new System.Drawing.Size(191, 52);
            this.editarPagoButton.TabIndex = 16;
            this.editarPagoButton.Text = "Editar pago";
            this.editarPagoButton.UseVisualStyleBackColor = true;
            // 
            // PedidoConfirmar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editarPagoButton);
            this.Controls.Add(this.editarPedidoButton);
            this.Controls.Add(this.emitirButton);
            this.Controls.Add(this.cancelarPedidoButton);
            this.Controls.Add(this.pagoTextBox);
            this.Controls.Add(this.chequearPagoLabel);
            this.Controls.Add(this.pedidoTextBox);
            this.Controls.Add(this.chequearPedidoLabel);
            this.Name = "PedidoConfirmar";
            this.Text = "PedidoConfirmar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chequearPedidoLabel;
        private System.Windows.Forms.TextBox pedidoTextBox;
        private System.Windows.Forms.Label chequearPagoLabel;
        private System.Windows.Forms.TextBox pagoTextBox;
        private System.Windows.Forms.Button emitirButton;
        private System.Windows.Forms.Button cancelarPedidoButton;
        private System.Windows.Forms.Button editarPedidoButton;
        private System.Windows.Forms.Button editarPagoButton;
    }
}