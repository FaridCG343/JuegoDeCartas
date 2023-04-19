using JuegoDeCartas.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeCartas.Controllers
{
    public class Personaje: Persona
    {
        public int Energia { get; set; }
        public int EnergiaMax { get; set; }
        public int Dinero { get; set; }
        public List<int> Pociones { get; set; } 
        public Deck Mazo { get; set; }


        public Personaje(string nombre, int vida, int ataque, int defensa, int energia, Image imagen, int dinero, Image idle, Image atacar, Image damaged): 
            base(nombre, vida, ataque, defensa, idle, atacar, damaged)
        {
            Energia = energia;
            Imagen = imagen;
            Dinero = dinero;
            Pociones = new ();
            
            EnergiaMax = Energia;
            BarraVida = new()
            {
                Size = new(135, 23),
                Minimum = 0,
                Maximum = Vida,
                Value = Vida,
                ForeColor = Color.Green,
                Location = new(37,358),
                Step = 1,

            };
            pbPersona = new()
            {
                Size = new(415, 200),
                Image = idle,
                BackColor = Color.Transparent,
                Location = new(27, 181),
                SizeMode = PictureBoxSizeMode.StretchImage,

            };
            lblVida = new()
            {
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Text = Vida.ToString(),
                AutoSize = true,
                Location = new(37, 358 + 23)
            };
            lblArmadura = new()
            {
                ForeColor = Color.White,
                AutoSize = true,
                BackColor = Color.Transparent,
                Text = Armadura.ToString(),
                Location = new(15,365)
            };
            Mazo = new(Defensa, Ataque, Nombre);
        }

        public override void onDeath()
        {
            MessageBox.Show("Has sido derrotado u.u", "Game over", MessageBoxButtons.OK);
            Program.menu.Show();
            Program.enemyRoom.CloseAndDispose();
        }

        public void endCombat()
        {
            Armadura = 0;
            lblArmadura.Text = "0";
            Energia = EnergiaMax;
        }
    }
}
