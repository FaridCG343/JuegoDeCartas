using JuegoDeCartas.Controllers;
using JuegoDeCartas.Modelos;
using JuegoDeCartas.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoDeCartas
{
    public partial class EnemyRoom : Form
    {
        private PictureBox pbSeleccionado;
        private int posIx, posIy, posX, posY, enemigoSeleccionado = 0;
        private List<PictureBox> CardDesingList;
        private List<Enemigo> enemigos;
        public bool closeByCode = false;

        public EnemyRoom()
        {
            InitializeComponent();
            createList();
            IniciarCombate();
            DoubleBuffered = true;
            Controls.Add(Program.personaje.lblArmadura);
            Controls.Add((Program.personaje.lblVida));
            Controls.Add(Program.personaje.pbPersona);
            Controls.Add(Program.personaje.BarraVida);
            Program.personaje.BarraVida.BringToFront();
            Program.personaje.lblArmadura.BringToFront();
            pbPersonajeE.Image = Program.personaje.Imagen;
            pBarEnergia.Maximum = Program.personaje.EnergiaMax;
            pBarEnergia.Minimum = 0;
            updateEnergia();
        }

        public void setBackGround(Image img)
        {
            BackgroundImage = img;
        }

        private void updateEnergia()
        {
            pBarEnergia.Value = Program.personaje.Energia;
            lblEnergia.Text = "Energia: " + Program.personaje.Energia + "/" + Program.personaje.EnergiaMax;
        }

        public void SetEnemies(List<Enemigo> enemigos)
        {
            this.enemigos = enemigos;
            int i = 0;
            int x = 992, dx = 166;
            foreach (Enemigo enemigo in enemigos)
            {
                enemigo.pbPersona.Tag = i;
                enemigo.pbPersona.Click += pbEnemigo1_Click;
                i++;
                enemigo.pbPersona.Location = new(x, 175);
                enemigo.BarraVida.Location = new(x, 175 + enemigo.pbPersona.Height);
                enemigo.pbIntencion.Location = new(x, 175 - 35);
                enemigo.lblArmadura.Location = new(x, 175 + enemigo.pbPersona.Height + enemigo.BarraVida.Height);
                enemigo.lblVida.Location = new(x + enemigo.lblArmadura.Width, 175 + enemigo.pbPersona.Height + enemigo.BarraVida.Height);
                x -= dx;
                Controls.Add(enemigo.pbPersona);
                Controls.Add(enemigo.BarraVida);
                Controls.Add(enemigo.pbIntencion);
                Controls.Add(enemigo.lblArmadura);
                Controls.Add(enemigo.lblVida);

            }
        }

        private void createList()
        {
            CardDesingList = new()
            {
                pbCard1, pbCard2, pbCard3, pbCard4, pbCard5, pbCard6
            };
        }

        private void IniciarCombate()
        {
            Program.personaje.Mazo.Shuffle();
            drawCards();
        }

        private void form_MouseMove(object sender, MouseEventArgs e)
        {
            if (pbSeleccionado != null)
            {
                int pX = pbSeleccionado.Location.X, pY = pbSeleccionado.Location.Y;
                pbSeleccionado.Location = new Point(pX + (e.X - posX), pY + (e.Y - posY));
                posX = e.X; posY = e.Y;
            }
        }

        private void btnSiguienteTurno_Click(object sender, EventArgs e)
        {
            Program.personaje.Mazo.endTurn();
            drawCards();
            Program.personaje.Energia = Program.personaje.EnergiaMax;
            pBarEnergia.Value = Program.personaje.Energia;
            updateEnergia();
            foreach (Enemigo enemigo in enemigos)
            {
                if (!enemigo.Muerto)
                {
                    enemigo.activarIntencion();
                    enemigo.generateIntencion();
                }
            }
        }

        private void form_MouseUp(object sender, MouseEventArgs e)
        {
            if (pbSeleccionado != null)
            {
                if (e.Y < 400)
                {
                    if (Program.personaje.Mazo.Hand[int.Parse(pbSeleccionado.Tag.ToString())].EnergyCost > Program.personaje.Energia)
                    {
                        MessageBox.Show("Energía insuficiente");
                    }
                    else
                    {
                        if (Program.personaje.Mazo.Hand[int.Parse(pbSeleccionado.Tag.ToString())].activarCarta(Program.personaje, enemigos[enemigoSeleccionado]))
                        {
                            pbSeleccionado.Visible = false;
                            Program.personaje.Energia -= Program.personaje.Mazo.Hand[int.Parse(pbSeleccionado.Tag.ToString())].EnergyCost;
                            updateEnergia();
                            if (win())
                            {
                                MessageBox.Show("Has ganado esta ronda!!", "Felicidades", MessageBoxButtons.OK);
                                Program.currentRoom += 1;
                                Program.personaje.Mazo.CombatEnds();
                                Program.personaje.endCombat();
                                Program.generateRoomController.GenerateRoom();
                                CloseAndDispose();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Selecciona un enemigo vivo");
                        }
                        
                    }
                }
                pbSeleccionado.Location = new Point(posIx, posIy);
                pbSeleccionado = null;
            }
        }

        private void pbEnemigo1_Click(object sender, EventArgs e)
        {
            PictureBox temp = (PictureBox)sender;
            int numEnemigo = int.Parse(temp.Tag.ToString() ?? "0");
            if (enemigos[numEnemigo].Muerto)
            {
                MessageBox.Show("Enemigo muerto");
            }
            else
            {
                enemigoSeleccionado = numEnemigo;
            }
        }

        public bool win()
        {
            bool win = true;
            foreach (Enemigo enemigo in enemigos)
            {
                win &= enemigo.Muerto;
            }
            return win;
        }

        private void form_MousDown(object sender, MouseEventArgs e)
        {
            foreach (PictureBox pb in CardDesingList)
            {
                if (e.X >= pb.Location.X && e.X <= pb.Location.X + pb.Width
                    && e.Y >= pb.Location.Y && e.Y <= pb.Location.Y + pb.Height && pb.Visible)
                {
                    pbSeleccionado = pb;
                    posX = e.X;
                    posIx = pb.Location.X;
                    posIy = pb.Location.Y;
                    posY = e.Y;
                    return;
                }
            }


        }
        public void drawCards()
        {
            for (int i = 0; i < 6; i++)
            {
                Card card = Program.personaje.Mazo.DrawCard();
                CardDesingList[i].Image = card.Image;
                CardDesingList[i].Visible = true;
            }
        }

        public void CloseAndDispose()
        {
            closeByCode = true;
            Close();
            Dispose();
        }

        private void WitchDungeons_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!closeByCode)
            {
                Dispose();
                Program.menu.Show();
            }
        }

    }
}
