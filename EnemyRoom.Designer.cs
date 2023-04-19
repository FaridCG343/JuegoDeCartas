namespace JuegoDeCartas
{
    partial class EnemyRoom
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
            pbPersonajeE = new PictureBox();
            pbCard1 = new PictureBox();
            pbCard2 = new PictureBox();
            pbCard3 = new PictureBox();
            pbCard4 = new PictureBox();
            pbCard5 = new PictureBox();
            pbCard6 = new PictureBox();
            pbEscudo = new PictureBox();
            lblEnergia = new Label();
            pBarEnergia = new ProgressBar();
            btnSiguienteTurno = new Button();
            ((System.ComponentModel.ISupportInitialize)pbPersonajeE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCard1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCard2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCard3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCard4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCard5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCard6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEscudo).BeginInit();
            SuspendLayout();
            // 
            // pbPersonajeE
            // 
            pbPersonajeE.BackColor = Color.Transparent;
            pbPersonajeE.Location = new Point(12, 12);
            pbPersonajeE.Name = "pbPersonajeE";
            pbPersonajeE.Size = new Size(100, 100);
            pbPersonajeE.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPersonajeE.TabIndex = 0;
            pbPersonajeE.TabStop = false;
            // 
            // pbCard1
            // 
            pbCard1.Enabled = false;
            pbCard1.Image = Properties.Resources.SkeletonIdle2;
            pbCard1.Location = new Point(130, 400);
            pbCard1.Name = "pbCard1";
            pbCard1.Size = new Size(100, 150);
            pbCard1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCard1.TabIndex = 15;
            pbCard1.TabStop = false;
            pbCard1.Tag = "0";
            // 
            // pbCard2
            // 
            pbCard2.Enabled = false;
            pbCard2.Location = new Point(236, 400);
            pbCard2.Name = "pbCard2";
            pbCard2.Size = new Size(100, 150);
            pbCard2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCard2.TabIndex = 16;
            pbCard2.TabStop = false;
            pbCard2.Tag = "1";
            // 
            // pbCard3
            // 
            pbCard3.Enabled = false;
            pbCard3.Location = new Point(342, 400);
            pbCard3.Name = "pbCard3";
            pbCard3.Size = new Size(100, 150);
            pbCard3.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCard3.TabIndex = 17;
            pbCard3.TabStop = false;
            pbCard3.Tag = "2";
            // 
            // pbCard4
            // 
            pbCard4.Enabled = false;
            pbCard4.Location = new Point(448, 400);
            pbCard4.Name = "pbCard4";
            pbCard4.Size = new Size(100, 150);
            pbCard4.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCard4.TabIndex = 18;
            pbCard4.TabStop = false;
            pbCard4.Tag = "3";
            // 
            // pbCard5
            // 
            pbCard5.Enabled = false;
            pbCard5.Location = new Point(554, 400);
            pbCard5.Name = "pbCard5";
            pbCard5.Size = new Size(100, 150);
            pbCard5.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCard5.TabIndex = 19;
            pbCard5.TabStop = false;
            pbCard5.Tag = "4";
            // 
            // pbCard6
            // 
            pbCard6.Enabled = false;
            pbCard6.Location = new Point(660, 400);
            pbCard6.Name = "pbCard6";
            pbCard6.Size = new Size(100, 150);
            pbCard6.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCard6.TabIndex = 20;
            pbCard6.TabStop = false;
            pbCard6.Tag = "5";
            // 
            // pbEscudo
            // 
            pbEscudo.BackColor = Color.Transparent;
            pbEscudo.Image = Properties.Resources.proteger;
            pbEscudo.Location = new Point(9, 361);
            pbEscudo.Name = "pbEscudo";
            pbEscudo.Size = new Size(25, 25);
            pbEscudo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEscudo.TabIndex = 21;
            pbEscudo.TabStop = false;
            // 
            // lblEnergia
            // 
            lblEnergia.AutoSize = true;
            lblEnergia.BackColor = Color.Transparent;
            lblEnergia.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEnergia.ForeColor = Color.White;
            lblEnergia.Location = new Point(130, 12);
            lblEnergia.Name = "lblEnergia";
            lblEnergia.Size = new Size(59, 17);
            lblEnergia.TabIndex = 22;
            lblEnergia.Text = "Energia: ";
            // 
            // pBarEnergia
            // 
            pBarEnergia.Location = new Point(130, 53);
            pBarEnergia.Name = "pBarEnergia";
            pBarEnergia.Size = new Size(100, 23);
            pBarEnergia.TabIndex = 23;
            // 
            // btnSiguienteTurno
            // 
            btnSiguienteTurno.FlatStyle = FlatStyle.Flat;
            btnSiguienteTurno.Location = new Point(1059, 12);
            btnSiguienteTurno.Name = "btnSiguienteTurno";
            btnSiguienteTurno.Size = new Size(113, 23);
            btnSiguienteTurno.TabIndex = 24;
            btnSiguienteTurno.Text = "SiguienteTurno";
            btnSiguienteTurno.UseVisualStyleBackColor = true;
            btnSiguienteTurno.Click += btnSiguienteTurno_Click;
            // 
            // EnemyRoom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Tunnel_29;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1184, 561);
            Controls.Add(btnSiguienteTurno);
            Controls.Add(pBarEnergia);
            Controls.Add(lblEnergia);
            Controls.Add(pbEscudo);
            Controls.Add(pbCard6);
            Controls.Add(pbCard5);
            Controls.Add(pbCard4);
            Controls.Add(pbCard3);
            Controls.Add(pbCard2);
            Controls.Add(pbCard1);
            Controls.Add(pbPersonajeE);
            Name = "EnemyRoom";
            Text = "WitchDungeons";
            FormClosed += WitchDungeons_FormClosed;
            MouseDown += form_MousDown;
            MouseMove += form_MouseMove;
            MouseUp += form_MouseUp;
            ((System.ComponentModel.ISupportInitialize)pbPersonajeE).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCard1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCard2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCard3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCard4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCard5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCard6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEscudo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbPersonajeE;
        private PictureBox pbCard3;
        private PictureBox pictureBox14;
        private PictureBox pbCard1;
        private PictureBox pbCard2;
        private PictureBox pbCard4;
        private PictureBox pbCard5;
        private PictureBox pbCard6;
        private PictureBox pbEscudo;
        private Label lblEnergia;
        private ProgressBar pBarEnergia;
        private Button btnSiguienteTurno;
    }
}