namespace JuegoDeCartas
{
    partial class LogIn
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
            btnLogIn = new Button();
            txbcgfUsuario = new TextBox();
            txbcgfContrasena = new TextBox();
            SuspendLayout();
            // 
            // btnLogIn
            // 
            btnLogIn.Location = new Point(352, 276);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(75, 23);
            btnLogIn.TabIndex = 0;
            btnLogIn.Text = "Ingresar";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // txbcgfUsuario
            // 
            txbcgfUsuario.Location = new Point(342, 109);
            txbcgfUsuario.Name = "txbcgfUsuario";
            txbcgfUsuario.PlaceholderText = "Usuario";
            txbcgfUsuario.Size = new Size(100, 23);
            txbcgfUsuario.TabIndex = 1;
            // 
            // txbcgfContrasena
            // 
            txbcgfContrasena.Location = new Point(342, 168);
            txbcgfContrasena.Name = "txbcgfContrasena";
            txbcgfContrasena.PlaceholderText = "Contraseña";
            txbcgfContrasena.Size = new Size(100, 23);
            txbcgfContrasena.TabIndex = 2;
            txbcgfContrasena.UseSystemPasswordChar = true;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            BackgroundImage = Properties.Resources.Tower_2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(txbcgfContrasena);
            Controls.Add(txbcgfUsuario);
            Controls.Add(btnLogIn);
            DoubleBuffered = true;
            KeyPreview = true;
            Name = "LogIn";
            Text = "LogIn";
            KeyPress += LogIn_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogIn;
        private TextBox txbcgfUsuario;
        private TextBox txbcgfContrasena;
    }
}