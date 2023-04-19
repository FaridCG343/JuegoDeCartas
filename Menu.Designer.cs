namespace JuegoDeCartas
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lbxcgfPersonajes = new ListBox();
            pbcgfImagenPersonaje = new PictureBox();
            lblcgfAtributos = new Label();
            lblcgfVida = new Label();
            lblcgfAtaque = new Label();
            lblcgfDefensa = new Label();
            pbVida = new PictureBox();
            pbDefensa = new PictureBox();
            pbAtaque = new PictureBox();
            btncgfAceptar = new Button();
            groupBox1 = new GroupBox();
            rbOp3 = new RadioButton();
            rbOp2 = new RadioButton();
            rbOp1 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pbcgfImagenPersonaje).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbVida).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDefensa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAtaque).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(25, 20);
            label1.Name = "label1";
            label1.Size = new Size(233, 58);
            label1.TabIndex = 0;
            label1.Text = "Selecciona un personaje";
            // 
            // lbxcgfPersonajes
            // 
            lbxcgfPersonajes.BackColor = Color.Black;
            lbxcgfPersonajes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbxcgfPersonajes.ForeColor = Color.White;
            lbxcgfPersonajes.FormattingEnabled = true;
            lbxcgfPersonajes.ItemHeight = 21;
            lbxcgfPersonajes.Items.AddRange(new object[] { "Morgana", "Elara", "Lavinia" });
            lbxcgfPersonajes.Location = new Point(25, 72);
            lbxcgfPersonajes.Name = "lbxcgfPersonajes";
            lbxcgfPersonajes.Size = new Size(120, 88);
            lbxcgfPersonajes.TabIndex = 1;
            lbxcgfPersonajes.SelectedIndexChanged += lbxcgfPersonajes_SelectedIndexChanged;
            // 
            // pbcgfImagenPersonaje
            // 
            pbcgfImagenPersonaje.Image = Properties.Resources.R_witch_emj;
            pbcgfImagenPersonaje.Location = new Point(588, 20);
            pbcgfImagenPersonaje.Name = "pbcgfImagenPersonaje";
            pbcgfImagenPersonaje.Size = new Size(200, 200);
            pbcgfImagenPersonaje.SizeMode = PictureBoxSizeMode.StretchImage;
            pbcgfImagenPersonaje.TabIndex = 2;
            pbcgfImagenPersonaje.TabStop = false;
            // 
            // lblcgfAtributos
            // 
            lblcgfAtributos.AutoSize = true;
            lblcgfAtributos.BackColor = Color.Transparent;
            lblcgfAtributos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblcgfAtributos.ForeColor = Color.White;
            lblcgfAtributos.Location = new Point(588, 235);
            lblcgfAtributos.Name = "lblcgfAtributos";
            lblcgfAtributos.Size = new Size(89, 25);
            lblcgfAtributos.TabIndex = 3;
            lblcgfAtributos.Text = "Atributos";
            // 
            // lblcgfVida
            // 
            lblcgfVida.AutoSize = true;
            lblcgfVida.BackColor = Color.Transparent;
            lblcgfVida.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblcgfVida.ForeColor = Color.White;
            lblcgfVida.Location = new Point(588, 268);
            lblcgfVida.Name = "lblcgfVida";
            lblcgfVida.Size = new Size(48, 21);
            lblcgfVida.TabIndex = 4;
            lblcgfVida.Text = "Vida: ";
            // 
            // lblcgfAtaque
            // 
            lblcgfAtaque.AutoSize = true;
            lblcgfAtaque.BackColor = Color.Transparent;
            lblcgfAtaque.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblcgfAtaque.ForeColor = Color.White;
            lblcgfAtaque.Location = new Point(588, 300);
            lblcgfAtaque.Name = "lblcgfAtaque";
            lblcgfAtaque.Size = new Size(66, 21);
            lblcgfAtaque.TabIndex = 5;
            lblcgfAtaque.Text = "Ataque: ";
            // 
            // lblcgfDefensa
            // 
            lblcgfDefensa.AutoSize = true;
            lblcgfDefensa.BackColor = Color.Transparent;
            lblcgfDefensa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblcgfDefensa.ForeColor = Color.White;
            lblcgfDefensa.Location = new Point(588, 331);
            lblcgfDefensa.Name = "lblcgfDefensa";
            lblcgfDefensa.Size = new Size(73, 21);
            lblcgfDefensa.TabIndex = 6;
            lblcgfDefensa.Text = "Defensa: ";
            // 
            // pbVida
            // 
            pbVida.BackColor = Color.Transparent;
            pbVida.Image = Properties.Resources.vida;
            pbVida.Location = new Point(562, 269);
            pbVida.Name = "pbVida";
            pbVida.Size = new Size(20, 20);
            pbVida.SizeMode = PictureBoxSizeMode.StretchImage;
            pbVida.TabIndex = 7;
            pbVida.TabStop = false;
            // 
            // pbDefensa
            // 
            pbDefensa.BackColor = Color.Transparent;
            pbDefensa.Image = Properties.Resources.proteger;
            pbDefensa.Location = new Point(562, 331);
            pbDefensa.Name = "pbDefensa";
            pbDefensa.Size = new Size(20, 20);
            pbDefensa.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDefensa.TabIndex = 8;
            pbDefensa.TabStop = false;
            // 
            // pbAtaque
            // 
            pbAtaque.BackColor = Color.Transparent;
            pbAtaque.Image = Properties.Resources.espada1;
            pbAtaque.Location = new Point(562, 301);
            pbAtaque.Name = "pbAtaque";
            pbAtaque.Size = new Size(20, 20);
            pbAtaque.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAtaque.TabIndex = 9;
            pbAtaque.TabStop = false;
            // 
            // btncgfAceptar
            // 
            btncgfAceptar.BackColor = Color.White;
            btncgfAceptar.FlatStyle = FlatStyle.Flat;
            btncgfAceptar.ForeColor = Color.Black;
            btncgfAceptar.Location = new Point(713, 397);
            btncgfAceptar.Name = "btncgfAceptar";
            btncgfAceptar.Size = new Size(75, 23);
            btncgfAceptar.TabIndex = 10;
            btncgfAceptar.Text = "Entrar";
            btncgfAceptar.UseVisualStyleBackColor = false;
            btncgfAceptar.Click += btncgfAceptar_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Black;
            groupBox1.Controls.Add(rbOp3);
            groupBox1.Controls.Add(rbOp2);
            groupBox1.Controls.Add(rbOp1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(25, 189);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(183, 113);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selecciona una mejora inicial";
            // 
            // rbOp3
            // 
            rbOp3.AutoSize = true;
            rbOp3.Location = new Point(6, 82);
            rbOp3.Name = "rbOp3";
            rbOp3.Size = new Size(89, 19);
            rbOp3.TabIndex = 2;
            rbOp3.TabStop = true;
            rbOp3.Text = "Más energia";
            rbOp3.UseVisualStyleBackColor = true;
            rbOp3.CheckedChanged += rbOp3_CheckedChanged;
            // 
            // rbOp2
            // 
            rbOp2.AutoSize = true;
            rbOp2.Location = new Point(6, 52);
            rbOp2.Name = "rbOp2";
            rbOp2.Size = new Size(86, 19);
            rbOp2.TabIndex = 1;
            rbOp2.TabStop = true;
            rbOp2.Text = "Más ataque";
            rbOp2.UseVisualStyleBackColor = true;
            rbOp2.CheckedChanged += rbOp2_CheckedChanged;
            // 
            // rbOp1
            // 
            rbOp1.AutoSize = true;
            rbOp1.Location = new Point(6, 22);
            rbOp1.Name = "rbOp1";
            rbOp1.Size = new Size(72, 19);
            rbOp1.TabIndex = 0;
            rbOp1.TabStop = true;
            rbOp1.Text = "Más vida";
            rbOp1.UseVisualStyleBackColor = true;
            rbOp1.CheckedChanged += rbOp1_CheckedChanged;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Doorway;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(btncgfAceptar);
            Controls.Add(pbAtaque);
            Controls.Add(pbDefensa);
            Controls.Add(pbVida);
            Controls.Add(lblcgfDefensa);
            Controls.Add(lblcgfAtaque);
            Controls.Add(lblcgfVida);
            Controls.Add(lblcgfAtributos);
            Controls.Add(pbcgfImagenPersonaje);
            Controls.Add(lbxcgfPersonajes);
            Controls.Add(label1);
            Name = "Menu";
            Text = "Menu";
            FormClosed += Menu_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pbcgfImagenPersonaje).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbVida).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDefensa).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAtaque).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lbxcgfPersonajes;
        private PictureBox pbcgfImagenPersonaje;
        private Label lblcgfAtributos;
        private Label lblcgfVida;
        private Label lblcgfAtaque;
        private Label lblcgfDefensa;
        private PictureBox pbVida;
        private PictureBox pbDefensa;
        private PictureBox pbAtaque;
        private Button btncgfAceptar;
        private GroupBox groupBox1;
        private RadioButton rbOp3;
        private RadioButton rbOp2;
        private RadioButton rbOp1;
    }
}