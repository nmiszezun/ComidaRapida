
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.nuevoPedidoButton = new System.Windows.Forms.Button();
            this.productosButton = new System.Windows.Forms.Button();
            this.salirButton = new System.Windows.Forms.Button();
            this.minimizePic = new System.Windows.Forms.PictureBox();
            this.exitPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPic)).BeginInit();
            this.SuspendLayout();
            // 
            // nuevoPedidoButton
            // 
            this.nuevoPedidoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(157)))), ((int)(((byte)(194)))));
            this.nuevoPedidoButton.FlatAppearance.BorderSize = 0;
            this.nuevoPedidoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuevoPedidoButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoPedidoButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nuevoPedidoButton.Location = new System.Drawing.Point(194, 78);
            this.nuevoPedidoButton.Name = "nuevoPedidoButton";
            this.nuevoPedidoButton.Size = new System.Drawing.Size(386, 52);
            this.nuevoPedidoButton.TabIndex = 0;
            this.nuevoPedidoButton.Text = "Nuevo pedido";
            this.nuevoPedidoButton.UseVisualStyleBackColor = false;
            this.nuevoPedidoButton.Click += new System.EventHandler(this.nuevoPedidoButton_Click);
            // 
            // productosButton
            // 
            this.productosButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(157)))), ((int)(((byte)(194)))));
            this.productosButton.FlatAppearance.BorderSize = 0;
            this.productosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productosButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productosButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.productosButton.Location = new System.Drawing.Point(194, 188);
            this.productosButton.Name = "productosButton";
            this.productosButton.Size = new System.Drawing.Size(386, 52);
            this.productosButton.TabIndex = 1;
            this.productosButton.Text = "Productos";
            this.productosButton.UseVisualStyleBackColor = false;
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
            // minimizePic
            // 
            this.minimizePic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.minimizePic.Image = ((System.Drawing.Image)(resources.GetObject("minimizePic.Image")));
            this.minimizePic.Location = new System.Drawing.Point(710, 12);
            this.minimizePic.Name = "minimizePic";
            this.minimizePic.Size = new System.Drawing.Size(19, 15);
            this.minimizePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizePic.TabIndex = 3;
            this.minimizePic.TabStop = false;
            this.minimizePic.Click += new System.EventHandler(this.minimizePic_Click);
            // 
            // exitPic
            // 
            this.exitPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(15)))), ((int)(((byte)(57)))));
            this.exitPic.Image = ((System.Drawing.Image)(resources.GetObject("exitPic.Image")));
            this.exitPic.Location = new System.Drawing.Point(735, 13);
            this.exitPic.Name = "exitPic";
            this.exitPic.Size = new System.Drawing.Size(19, 15);
            this.exitPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitPic.TabIndex = 4;
            this.exitPic.TabStop = false;
            this.exitPic.Click += new System.EventHandler(this.exitPic_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitPic);
            this.Controls.Add(this.minimizePic);
            this.Controls.Add(this.salirButton);
            this.Controls.Add(this.productosButton);
            this.Controls.Add(this.nuevoPedidoButton);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.minimizePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button nuevoPedidoButton;
        private System.Windows.Forms.Button productosButton;
        private System.Windows.Forms.Button salirButton;
        private System.Windows.Forms.PictureBox minimizePic;
        private System.Windows.Forms.PictureBox exitPic;
    }
}