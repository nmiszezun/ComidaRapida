
namespace ComidaRapida
{
    partial class PedidoPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidoPago));
            this.medioDePagoLabel = new System.Windows.Forms.Label();
            this.pagadoTextBox = new System.Windows.Forms.TextBox();
            this.efectivoRadioButton = new System.Windows.Forms.RadioButton();
            this.tarjetaRadioButton = new System.Windows.Forms.RadioButton();
            this.pagadoLabel = new System.Windows.Forms.Label();
            this.vueltoLabel = new System.Windows.Forms.Label();
            this.vueltoTextBox = new System.Windows.Forms.TextBox();
            this.numeroLabel = new System.Windows.Forms.Label();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.volverButton = new System.Windows.Forms.Button();
            this.confirmarButton = new System.Windows.Forms.Button();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.exitPic1 = new System.Windows.Forms.PictureBox();
            this.minPic1 = new System.Windows.Forms.PictureBox();
            this.importeTotalLabel = new System.Windows.Forms.Label();
            this.importeTotalTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.exitPic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minPic1)).BeginInit();
            this.SuspendLayout();
            // 
            // medioDePagoLabel
            // 
            this.medioDePagoLabel.AutoSize = true;
            this.medioDePagoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medioDePagoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.medioDePagoLabel.Location = new System.Drawing.Point(43, 29);
            this.medioDePagoLabel.Name = "medioDePagoLabel";
            this.medioDePagoLabel.Size = new System.Drawing.Size(204, 31);
            this.medioDePagoLabel.TabIndex = 0;
            this.medioDePagoLabel.Text = "Medio de pago";
            // 
            // pagadoTextBox
            // 
            this.pagadoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagadoTextBox.Location = new System.Drawing.Point(301, 151);
            this.pagadoTextBox.Name = "pagadoTextBox";
            this.pagadoTextBox.Size = new System.Drawing.Size(115, 26);
            this.pagadoTextBox.TabIndex = 3;
            this.pagadoTextBox.TextChanged += new System.EventHandler(this.pagadoTextBox_TextChanged);
            // 
            // efectivoRadioButton
            // 
            this.efectivoRadioButton.AutoSize = true;
            this.efectivoRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efectivoRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.efectivoRadioButton.Location = new System.Drawing.Point(49, 149);
            this.efectivoRadioButton.Name = "efectivoRadioButton";
            this.efectivoRadioButton.Size = new System.Drawing.Size(94, 28);
            this.efectivoRadioButton.TabIndex = 4;
            this.efectivoRadioButton.Text = "Efectivo";
            this.efectivoRadioButton.UseVisualStyleBackColor = true;
            this.efectivoRadioButton.CheckedChanged += new System.EventHandler(this.efectivoRadioButton_CheckedChanged);
            // 
            // tarjetaRadioButton
            // 
            this.tarjetaRadioButton.AutoSize = true;
            this.tarjetaRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarjetaRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.tarjetaRadioButton.Location = new System.Drawing.Point(49, 211);
            this.tarjetaRadioButton.Name = "tarjetaRadioButton";
            this.tarjetaRadioButton.Size = new System.Drawing.Size(85, 28);
            this.tarjetaRadioButton.TabIndex = 5;
            this.tarjetaRadioButton.Text = "Tarjeta";
            this.tarjetaRadioButton.UseVisualStyleBackColor = true;
            this.tarjetaRadioButton.CheckedChanged += new System.EventHandler(this.tarjetaRadioButton_CheckedChanged);
            // 
            // pagadoLabel
            // 
            this.pagadoLabel.AutoSize = true;
            this.pagadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagadoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pagadoLabel.Location = new System.Drawing.Point(210, 151);
            this.pagadoLabel.Name = "pagadoLabel";
            this.pagadoLabel.Size = new System.Drawing.Size(75, 24);
            this.pagadoLabel.TabIndex = 6;
            this.pagadoLabel.Text = "Pagado";
            // 
            // vueltoLabel
            // 
            this.vueltoLabel.AutoSize = true;
            this.vueltoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vueltoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.vueltoLabel.Location = new System.Drawing.Point(452, 152);
            this.vueltoLabel.Name = "vueltoLabel";
            this.vueltoLabel.Size = new System.Drawing.Size(64, 24);
            this.vueltoLabel.TabIndex = 8;
            this.vueltoLabel.Text = "Vuelto";
            // 
            // vueltoTextBox
            // 
            this.vueltoTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.vueltoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vueltoTextBox.Location = new System.Drawing.Point(522, 152);
            this.vueltoTextBox.Name = "vueltoTextBox";
            this.vueltoTextBox.ReadOnly = true;
            this.vueltoTextBox.Size = new System.Drawing.Size(124, 26);
            this.vueltoTextBox.TabIndex = 7;
            // 
            // numeroLabel
            // 
            this.numeroLabel.AutoSize = true;
            this.numeroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.numeroLabel.Location = new System.Drawing.Point(210, 219);
            this.numeroLabel.Name = "numeroLabel";
            this.numeroLabel.Size = new System.Drawing.Size(79, 24);
            this.numeroLabel.TabIndex = 10;
            this.numeroLabel.Text = "Número";
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.numeroTextBox.Location = new System.Drawing.Point(301, 219);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(345, 26);
            this.numeroTextBox.TabIndex = 9;
            // 
            // volverButton
            // 
            this.volverButton.BackColor = System.Drawing.Color.Red;
            this.volverButton.FlatAppearance.BorderSize = 0;
            this.volverButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volverButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volverButton.ForeColor = System.Drawing.Color.White;
            this.volverButton.Location = new System.Drawing.Point(31, 374);
            this.volverButton.Name = "volverButton";
            this.volverButton.Size = new System.Drawing.Size(200, 52);
            this.volverButton.TabIndex = 11;
            this.volverButton.Text = "Volver";
            this.volverButton.UseVisualStyleBackColor = false;
            this.volverButton.Click += new System.EventHandler(this.volverButton_Click);
            // 
            // confirmarButton
            // 
            this.confirmarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(218)))), ((int)(((byte)(21)))));
            this.confirmarButton.FlatAppearance.BorderSize = 0;
            this.confirmarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmarButton.ForeColor = System.Drawing.Color.Black;
            this.confirmarButton.Location = new System.Drawing.Point(486, 374);
            this.confirmarButton.Name = "confirmarButton";
            this.confirmarButton.Size = new System.Drawing.Size(200, 52);
            this.confirmarButton.TabIndex = 12;
            this.confirmarButton.Text = "Confirmar pago";
            this.confirmarButton.UseVisualStyleBackColor = false;
            this.confirmarButton.Click += new System.EventHandler(this.confirmarButton_Click);
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.nombreLabel.Location = new System.Drawing.Point(209, 278);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(79, 24);
            this.nombreLabel.TabIndex = 13;
            this.nombreLabel.Text = "Nombre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(301, 279);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 20);
            this.textBox1.TabIndex = 14;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.nombreTextBox.Location = new System.Drawing.Point(301, 278);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(345, 26);
            this.nombreTextBox.TabIndex = 15;
            // 
            // exitPic1
            // 
            this.exitPic1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(15)))), ((int)(((byte)(57)))));
            this.exitPic1.Image = ((System.Drawing.Image)(resources.GetObject("exitPic1.Image")));
            this.exitPic1.Location = new System.Drawing.Point(745, 12);
            this.exitPic1.Name = "exitPic1";
            this.exitPic1.Size = new System.Drawing.Size(19, 15);
            this.exitPic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitPic1.TabIndex = 20;
            this.exitPic1.TabStop = false;
            this.exitPic1.Click += new System.EventHandler(this.exitPic1_Click);
            // 
            // minPic1
            // 
            this.minPic1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.minPic1.Image = ((System.Drawing.Image)(resources.GetObject("minPic1.Image")));
            this.minPic1.Location = new System.Drawing.Point(712, 12);
            this.minPic1.Name = "minPic1";
            this.minPic1.Size = new System.Drawing.Size(19, 15);
            this.minPic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minPic1.TabIndex = 19;
            this.minPic1.TabStop = false;
            this.minPic1.Click += new System.EventHandler(this.minPic1_Click);
            // 
            // importeTotalLabel
            // 
            this.importeTotalLabel.AutoSize = true;
            this.importeTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importeTotalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.importeTotalLabel.Location = new System.Drawing.Point(45, 93);
            this.importeTotalLabel.Name = "importeTotalLabel";
            this.importeTotalLabel.Size = new System.Drawing.Size(111, 24);
            this.importeTotalLabel.TabIndex = 21;
            this.importeTotalLabel.Text = "Importe total";
            // 
            // importeTotalTextBox
            // 
            this.importeTotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importeTotalTextBox.Location = new System.Drawing.Point(162, 93);
            this.importeTotalTextBox.Name = "importeTotalTextBox";
            this.importeTotalTextBox.ReadOnly = true;
            this.importeTotalTextBox.Size = new System.Drawing.Size(115, 26);
            this.importeTotalTextBox.TabIndex = 22;
            // 
            // PedidoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(157)))), ((int)(((byte)(194)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.importeTotalTextBox);
            this.Controls.Add(this.importeTotalLabel);
            this.Controls.Add(this.exitPic1);
            this.Controls.Add(this.minPic1);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.confirmarButton);
            this.Controls.Add(this.volverButton);
            this.Controls.Add(this.numeroLabel);
            this.Controls.Add(this.numeroTextBox);
            this.Controls.Add(this.vueltoLabel);
            this.Controls.Add(this.vueltoTextBox);
            this.Controls.Add(this.pagadoLabel);
            this.Controls.Add(this.tarjetaRadioButton);
            this.Controls.Add(this.efectivoRadioButton);
            this.Controls.Add(this.pagadoTextBox);
            this.Controls.Add(this.medioDePagoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PedidoPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PedidoPago";
            this.Load += new System.EventHandler(this.PedidoPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exitPic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minPic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label medioDePagoLabel;
        private System.Windows.Forms.TextBox pagadoTextBox;
        private System.Windows.Forms.RadioButton efectivoRadioButton;
        private System.Windows.Forms.RadioButton tarjetaRadioButton;
        private System.Windows.Forms.Label pagadoLabel;
        private System.Windows.Forms.Label vueltoLabel;
        private System.Windows.Forms.TextBox vueltoTextBox;
        private System.Windows.Forms.Label numeroLabel;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.Button volverButton;
        private System.Windows.Forms.Button confirmarButton;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.PictureBox exitPic1;
        private System.Windows.Forms.PictureBox minPic1;
        private System.Windows.Forms.Label importeTotalLabel;
        private System.Windows.Forms.TextBox importeTotalTextBox;
    }
}