namespace JuegoDeCartas.Controllers
{
    partial class CardDesing
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombre = new Label();
            lblDescripcion = new Label();
            lblEnergia = new Label();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.ForeColor = Color.Black;
            lblNombre.Location = new Point(33, 6);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.BackColor = Color.Transparent;
            lblDescripcion.ForeColor = Color.Black;
            lblDescripcion.Location = new Point(3, 81);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(66, 15);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "Ataca 1 vez";
            // 
            // lblEnergia
            // 
            lblEnergia.AutoSize = true;
            lblEnergia.BackColor = Color.Black;
            lblEnergia.ForeColor = Color.White;
            lblEnergia.Location = new Point(7, 6);
            lblEnergia.Name = "lblEnergia";
            lblEnergia.Size = new Size(13, 15);
            lblEnergia.TabIndex = 2;
            lblEnergia.Text = "1";
            // 
            // CardDesing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.card1;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(lblEnergia);
            Controls.Add(lblDescripcion);
            Controls.Add(lblNombre);
            DoubleBuffered = true;
            Name = "CardDesing";
            Size = new Size(100, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblDescripcion;
        private Label lblEnergia;
    }
}
