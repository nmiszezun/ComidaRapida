
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidoConfirmar));
            this.chequearPedidoLabel = new System.Windows.Forms.Label();
            this.pedidoTextBox = new System.Windows.Forms.TextBox();
            this.chequearPagoLabel = new System.Windows.Forms.Label();
            this.pagoTextBox = new System.Windows.Forms.TextBox();
            this.emitirButton = new System.Windows.Forms.Button();
            this.cancelarPedidoButton = new System.Windows.Forms.Button();
            this.editarPedidoButton = new System.Windows.Forms.Button();
            this.editarPagoButton = new System.Windows.Forms.Button();
            this.exPic = new System.Windows.Forms.PictureBox();
            this.minimPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.exPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimPic)).BeginInit();
            this.SuspendLayout();
            // 
            // chequearPedidoLabel
            // 
            this.chequearPedidoLabel.AutoSize = true;
            this.chequearPedidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chequearPedidoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.chequearPedidoLabel.Location = new System.Drawing.Point(30, 29);
            this.chequearPedidoLabel.Name = "chequearPedidoLabel";
            this.chequearPedidoLabel.Size = new System.Drawing.Size(218, 31);
            this.chequearPedidoLabel.TabIndex = 0;
            this.chequearPedidoLabel.Text = "Verificar pedido";
            // 
            // pedidoTextBox
            // 
            this.pedidoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pedidoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.chequearPagoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chequearPagoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.chequearPagoLabel.Location = new System.Drawing.Point(30, 247);
            this.chequearPagoLabel.Name = "chequearPagoLabel";
            this.chequearPagoLabel.Size = new System.Drawing.Size(195, 31);
            this.chequearPagoLabel.TabIndex = 2;
            this.chequearPagoLabel.Text = "Verificar pago";
            // 
            // pagoTextBox
            // 
            this.pagoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pagoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagoTextBox.Location = new System.Drawing.Point(36, 294);
            this.pagoTextBox.Name = "pagoTextBox";
            this.pagoTextBox.ReadOnly = true;
            this.pagoTextBox.Size = new System.Drawing.Size(517, 22);
            this.pagoTextBox.TabIndex = 3;
            // 
            // emitirButton
            // 
            this.emitirButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(218)))), ((int)(((byte)(21)))));
            this.emitirButton.FlatAppearance.BorderSize = 0;
            this.emitirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emitirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emitirButton.ForeColor = System.Drawing.Color.Black;
            this.emitirButton.Location = new System.Drawing.Point(309, 386);
            this.emitirButton.Name = "emitirButton";
            this.emitirButton.Size = new System.Drawing.Size(200, 52);
            this.emitirButton.TabIndex = 14;
            this.emitirButton.Text = "Confirmar pedido";
            this.emitirButton.UseVisualStyleBackColor = false;
            this.emitirButton.Click += new System.EventHandler(this.emitirButton_Click);
            // 
            // cancelarPedidoButton
            // 
            this.cancelarPedidoButton.BackColor = System.Drawing.Color.Red;
            this.cancelarPedidoButton.FlatAppearance.BorderSize = 0;
            this.cancelarPedidoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarPedidoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarPedidoButton.ForeColor = System.Drawing.Color.White;
            this.cancelarPedidoButton.Location = new System.Drawing.Point(12, 386);
            this.cancelarPedidoButton.Name = "cancelarPedidoButton";
            this.cancelarPedidoButton.Size = new System.Drawing.Size(200, 52);
            this.cancelarPedidoButton.TabIndex = 13;
            this.cancelarPedidoButton.Text = "Cancelar pedido";
            this.cancelarPedidoButton.UseVisualStyleBackColor = false;
            this.cancelarPedidoButton.Click += new System.EventHandler(this.cancelarPedidoButton_Click);
            // 
            // editarPedidoButton
            // 
            this.editarPedidoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.editarPedidoButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.editarPedidoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarPedidoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarPedidoButton.ForeColor = System.Drawing.Color.Black;
            this.editarPedidoButton.Location = new System.Drawing.Point(580, 123);
            this.editarPedidoButton.Name = "editarPedidoButton";
            this.editarPedidoButton.Size = new System.Drawing.Size(191, 52);
            this.editarPedidoButton.TabIndex = 15;
            this.editarPedidoButton.Text = "Editar pedido";
            this.editarPedidoButton.UseVisualStyleBackColor = false;
            this.editarPedidoButton.Click += new System.EventHandler(this.editarPedidoButton_Click);
            // 
            // editarPagoButton
            // 
            this.editarPagoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.editarPagoButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.editarPagoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarPagoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarPagoButton.ForeColor = System.Drawing.Color.Black;
            this.editarPagoButton.Location = new System.Drawing.Point(580, 265);
            this.editarPagoButton.Name = "editarPagoButton";
            this.editarPagoButton.Size = new System.Drawing.Size(191, 52);
            this.editarPagoButton.TabIndex = 16;
            this.editarPagoButton.Text = "Editar pago";
            this.editarPagoButton.UseVisualStyleBackColor = false;
            this.editarPagoButton.Click += new System.EventHandler(this.editarPagoButton_Click);
            // 
            // exPic
            // 
            this.exPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(15)))), ((int)(((byte)(57)))));
            this.exPic.Image = ((System.Drawing.Image)(resources.GetObject("exPic.Image")));
            this.exPic.Location = new System.Drawing.Point(752, 12);
            this.exPic.Name = "exPic";
            this.exPic.Size = new System.Drawing.Size(19, 15);
            this.exPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exPic.TabIndex = 18;
            this.exPic.TabStop = false;
            this.exPic.Click += new System.EventHandler(this.exPic_Click);
            // 
            // minimPic
            // 
            this.minimPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.minimPic.Image = ((System.Drawing.Image)(resources.GetObject("minimPic.Image")));
            this.minimPic.Location = new System.Drawing.Point(719, 12);
            this.minimPic.Name = "minimPic";
            this.minimPic.Size = new System.Drawing.Size(19, 15);
            this.minimPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimPic.TabIndex = 17;
            this.minimPic.TabStop = false;
            this.minimPic.Click += new System.EventHandler(this.minimPic_Click);
            // 
            // PedidoConfirmar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(157)))), ((int)(((byte)(194)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exPic);
            this.Controls.Add(this.minimPic);
            this.Controls.Add(this.editarPagoButton);
            this.Controls.Add(this.editarPedidoButton);
            this.Controls.Add(this.emitirButton);
            this.Controls.Add(this.cancelarPedidoButton);
            this.Controls.Add(this.pagoTextBox);
            this.Controls.Add(this.chequearPagoLabel);
            this.Controls.Add(this.pedidoTextBox);
            this.Controls.Add(this.chequearPedidoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PedidoConfirmar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PedidoConfirmar";
            ((System.ComponentModel.ISupportInitialize)(this.exPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimPic)).EndInit();
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
        private System.Windows.Forms.PictureBox exPic;
        private System.Windows.Forms.PictureBox minimPic;
    }
}