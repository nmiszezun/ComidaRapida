
namespace ComidaRapida
{
    partial class Login
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
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.contraseniaTextBox = new System.Windows.Forms.TextBox();
            this.usuarioLabel = new System.Windows.Forms.Label();
            this.contraseniaLabel = new System.Windows.Forms.Label();
            this.ingresarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioTextBox.Location = new System.Drawing.Point(338, 127);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(241, 38);
            this.usuarioTextBox.TabIndex = 0;
            // 
            // contraseniaTextBox
            // 
            this.contraseniaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseniaTextBox.Location = new System.Drawing.Point(338, 197);
            this.contraseniaTextBox.Name = "contraseniaTextBox";
            this.contraseniaTextBox.Size = new System.Drawing.Size(241, 38);
            this.contraseniaTextBox.TabIndex = 1;
            this.contraseniaTextBox.UseSystemPasswordChar = true;
            // 
            // usuarioLabel
            // 
            this.usuarioLabel.AutoSize = true;
            this.usuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioLabel.Location = new System.Drawing.Point(195, 136);
            this.usuarioLabel.Name = "usuarioLabel";
            this.usuarioLabel.Size = new System.Drawing.Size(86, 25);
            this.usuarioLabel.TabIndex = 2;
            this.usuarioLabel.Text = "Usuario";
            // 
            // contraseniaLabel
            // 
            this.contraseniaLabel.AutoSize = true;
            this.contraseniaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseniaLabel.Location = new System.Drawing.Point(195, 206);
            this.contraseniaLabel.Name = "contraseniaLabel";
            this.contraseniaLabel.Size = new System.Drawing.Size(123, 25);
            this.contraseniaLabel.TabIndex = 3;
            this.contraseniaLabel.Text = "Contraseña";
            // 
            // ingresarButton
            // 
            this.ingresarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresarButton.Location = new System.Drawing.Point(388, 273);
            this.ingresarButton.Name = "ingresarButton";
            this.ingresarButton.Size = new System.Drawing.Size(147, 52);
            this.ingresarButton.TabIndex = 4;
            this.ingresarButton.Text = "Ingresar";
            this.ingresarButton.UseVisualStyleBackColor = true;
            this.ingresarButton.Click += new System.EventHandler(this.ingresarButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ingresarButton);
            this.Controls.Add(this.contraseniaLabel);
            this.Controls.Add(this.usuarioLabel);
            this.Controls.Add(this.contraseniaTextBox);
            this.Controls.Add(this.usuarioTextBox);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.TextBox contraseniaTextBox;
        private System.Windows.Forms.Label usuarioLabel;
        private System.Windows.Forms.Label contraseniaLabel;
        private System.Windows.Forms.Button ingresarButton;
    }
}

