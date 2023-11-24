
namespace ComidaRapida
{
    partial class PedidoProductos
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
            System.Windows.Forms.Button cancelarButton;
            this.pedidoGrid = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedidoLabel = new System.Windows.Forms.Label();
            this.agregarLabel = new System.Windows.Forms.Label();
            this.agregarComboBox = new System.Windows.Forms.ComboBox();
            this.cantidadInput = new System.Windows.Forms.NumericUpDown();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.agregarButton = new System.Windows.Forms.Button();
            this.confirmarButton = new System.Windows.Forms.Button();
            cancelarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadInput)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelarButton
            // 
            cancelarButton.BackColor = System.Drawing.Color.Red;
            cancelarButton.FlatAppearance.BorderSize = 0;
            cancelarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cancelarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cancelarButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            cancelarButton.Location = new System.Drawing.Point(12, 386);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new System.Drawing.Size(200, 52);
            cancelarButton.TabIndex = 8;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = false;
            // 
            // pedidoGrid
            // 
            this.pedidoGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pedidoGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pedidoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pedidoGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Producto,
            this.Precio});
            this.pedidoGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(157)))), ((int)(((byte)(194)))));
            this.pedidoGrid.Location = new System.Drawing.Point(109, 182);
            this.pedidoGrid.Name = "pedidoGrid";
            this.pedidoGrid.Size = new System.Drawing.Size(569, 150);
            this.pedidoGrid.TabIndex = 0;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cant";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Cantidad.Width = 50;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Producto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Producto.Width = 400;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Precio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Precio.Width = 75;
            // 
            // pedidoLabel
            // 
            this.pedidoLabel.AutoSize = true;
            this.pedidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pedidoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pedidoLabel.Location = new System.Drawing.Point(104, 145);
            this.pedidoLabel.Name = "pedidoLabel";
            this.pedidoLabel.Size = new System.Drawing.Size(191, 31);
            this.pedidoLabel.TabIndex = 1;
            this.pedidoLabel.Text = "Pedido actual";
            // 
            // agregarLabel
            // 
            this.agregarLabel.AutoSize = true;
            this.agregarLabel.BackColor = System.Drawing.Color.Transparent;
            this.agregarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.agregarLabel.Location = new System.Drawing.Point(104, 32);
            this.agregarLabel.Name = "agregarLabel";
            this.agregarLabel.Size = new System.Drawing.Size(239, 31);
            this.agregarLabel.TabIndex = 2;
            this.agregarLabel.Text = "Agregar producto";
            // 
            // agregarComboBox
            // 
            this.agregarComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(157)))), ((int)(((byte)(194)))));
            this.agregarComboBox.FormattingEnabled = true;
            this.agregarComboBox.Location = new System.Drawing.Point(235, 77);
            this.agregarComboBox.Name = "agregarComboBox";
            this.agregarComboBox.Size = new System.Drawing.Size(349, 28);
            this.agregarComboBox.TabIndex = 3;
            this.agregarComboBox.Text = "(seleccionar producto)";
            // 
            // cantidadInput
            // 
            this.cantidadInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(157)))), ((int)(((byte)(194)))));
            this.cantidadInput.Location = new System.Drawing.Point(109, 75);
            this.cantidadInput.Name = "cantidadInput";
            this.cantidadInput.Size = new System.Drawing.Size(120, 29);
            this.cantidadInput.TabIndex = 4;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(524, 344);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(48, 20);
            this.totalLabel.TabIndex = 5;
            this.totalLabel.Text = "Total:";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTextBox.Location = new System.Drawing.Point(578, 338);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(100, 26);
            this.totalTextBox.TabIndex = 6;
            this.totalTextBox.Text = "$ 0,00";
            this.totalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // agregarButton
            // 
            this.agregarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.agregarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(157)))), ((int)(((byte)(194)))));
            this.agregarButton.Location = new System.Drawing.Point(590, 78);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(97, 28);
            this.agregarButton.TabIndex = 7;
            this.agregarButton.Text = "Agregar";
            this.agregarButton.UseVisualStyleBackColor = false;
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // confirmarButton
            // 
            this.confirmarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(218)))), ((int)(((byte)(21)))));
            this.confirmarButton.FlatAppearance.BorderSize = 0;
            this.confirmarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmarButton.ForeColor = System.Drawing.Color.Black;
            this.confirmarButton.Location = new System.Drawing.Point(588, 386);
            this.confirmarButton.Name = "confirmarButton";
            this.confirmarButton.Size = new System.Drawing.Size(200, 52);
            this.confirmarButton.TabIndex = 9;
            this.confirmarButton.Text = "Confirmar pedido";
            this.confirmarButton.UseVisualStyleBackColor = false;
            // 
            // PedidoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(157)))), ((int)(((byte)(194)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confirmarButton);
            this.Controls.Add(cancelarButton);
            this.Controls.Add(this.agregarButton);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.cantidadInput);
            this.Controls.Add(this.agregarComboBox);
            this.Controls.Add(this.agregarLabel);
            this.Controls.Add(this.pedidoLabel);
            this.Controls.Add(this.pedidoGrid);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PedidoProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PedidoProductos";
            this.Load += new System.EventHandler(this.PedidoProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pedidoGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView pedidoGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Label pedidoLabel;
        private System.Windows.Forms.Label agregarLabel;
        private System.Windows.Forms.ComboBox agregarComboBox;
        private System.Windows.Forms.NumericUpDown cantidadInput;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Button agregarButton;
        private System.Windows.Forms.Button confirmarButton;
    }
}