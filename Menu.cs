using JuegoDeCartas.Controllers;
using JuegoDeCartas.Modelos;
using JuegoDeCartas.Properties;

namespace JuegoDeCartas
{
    public partial class Menu : Form
    {
        /*
         * Creditos de imagenes
         * <a href="https://www.flaticon.es/iconos-gratis/corazon" title="corazón iconos">Corazón iconos creados por Kiranshastry - Flaticon</a>
         * <a href="https://www.flaticon.es/iconos-gratis/espada" title="espada iconos">Espada iconos creados por Freepik - Flaticon</a>
         * 
         */
        public List<List<int>> atributos;
        Image idle, atacar, damaged;
        public int vidaExtra = 0, ataqueExtra = 0, energiaExtra = 0;
        public Menu()
        {
            InitializeComponent();
            atributos = new List<List<int>>()
            {
                new List<int>()
                {
                    80, 12, 6
                },
                new List<int>()
                {
                    100, 6, 10
                },
                new List<int>()
                {
                    90, 9, 9
                }
            };
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lbxcgfPersonajes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxcgfPersonajes.SelectedIndex != -1)
            {
                switch (lbxcgfPersonajes.SelectedIndex)
                {
                    case 0:
                        pbcgfImagenPersonaje.Image = Properties.Resources.R_witch_emj;
                        idle = Properties.Resources.R_witch_idle;
                        atacar = Properties.Resources.R_witch_attack;
                        damaged = Resources.R_witch_take_damage;
                        break;
                    case 1:
                        pbcgfImagenPersonaje.Image = Properties.Resources.B_witch;
                        idle = Properties.Resources.B_witch_idle;
                        atacar = Properties.Resources.B_witch_attack;
                        damaged = Resources.B_witch_take_damage;
                        break;
                    case 2:
                        pbcgfImagenPersonaje.Image = Properties.Resources.W_witch_emoji;
                        idle = Properties.Resources.W_witch_idle;
                        atacar = Properties.Resources.W_witch_attack;
                        damaged = Resources.W_witch_tacke_damage;
                        break;
                }
                lblcgfVida.Text = "Vida: " + atributos[lbxcgfPersonajes.SelectedIndex][0];
                lblcgfAtaque.Text = "Ataque: " + atributos[lbxcgfPersonajes.SelectedIndex][1];
                lblcgfDefensa.Text = "Defensa: " + atributos[lbxcgfPersonajes.SelectedIndex][2];
            }
        }

        private void btncgfAceptar_Click(object sender, EventArgs e)
        {
            if (lbxcgfPersonajes.SelectedIndex != -1)
            {
                Program.personaje = new Personaje(lbxcgfPersonajes.SelectedItem.ToString() ?? "",
                   atributos[lbxcgfPersonajes.SelectedIndex][0] + vidaExtra,
                   atributos[lbxcgfPersonajes.SelectedIndex][1] + ataqueExtra,
                   atributos[lbxcgfPersonajes.SelectedIndex][2],
                   3 + energiaExtra,
                   pbcgfImagenPersonaje.Image, 99, idle, atacar, damaged);
                Program.generateRoomController.GenerateRoom();

                this.Hide();
                //  Program.generateRoomController.GenerateRoom(this);
            }
            else
            {
                MessageBox.Show("Selecciona un personaje");
            }
        }

        private void rbOp1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOp1.Checked)
            {
                vidaExtra = 20;
                ataqueExtra = 0;
                energiaExtra = 0;
            }
        }

        private void rbOp2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOp2.Checked)
            {
                vidaExtra = 0;
                ataqueExtra = 3;
                energiaExtra = 0;
            }
        }

        private void rbOp3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOp3.Checked)
            {
                vidaExtra = 0;
                ataqueExtra = 0;
                energiaExtra = 1;
            }
        }
    }
}