using JuegoDeCartas.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeCartas.Modelos
{
    public class Enemigo: Persona
    {
        public string[] intenciones;
        public string Intencion { get; set; }
        public PictureBox pbIntencion { get; set; }
        public Enemigo(string nombre, int vida, int ataque, int defensa, Image idle, Image ataqueI, Image damaged):
            base(nombre, vida, ataque, defensa, idle, ataqueI, damaged)
        {
            intenciones = new string[] {
                "Atacar", "Curar", "Defenderse"
            };
            BarraVida = new()
            {
                Size = new(100, 20),
                Minimum = 0,
                Maximum = Vida,
                Value = Vida,
                ForeColor = Color.Green,
                Step = 1,            
            };
            pbPersona = new() { 
                Size = new(150, 200),
                Image = idle ,
                BackColor = Color.Transparent,
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
            pbIntencion = new()
            {
                Size = new(35, 35),
                BackColor = Color.Transparent,
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
            lblVida = new()
            {
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Text = Vida.ToString(),
            };
            lblArmadura = new()
            {
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Text = Armadura.ToString(),
            };
            generateIntencion();
        }
        public void activarIntencion()
        {
            switch(Intencion)
            {
                case "Atacar":
                    Program.personaje.TakeDamage(Ataque);
                    break;
                case "Curar":
                    curar(this.VidaMax / 4);
                    break;
                case "Defenderse":
                    defenderse();
                    break;
            }
        }

        public void generateIntencion()
        {
            Random rng = new();
            Intencion = intenciones[rng.Next(0, 3)];
            switch(Intencion)
            {
                case "Atacar":
                    pbIntencion.Image = Properties.Resources.espada1;
                    break;
                case "Curar":
                    pbIntencion.Image = Properties.Resources.vida;
                    break;
                case "Defenderse":
                    pbIntencion.Image = Properties.Resources.proteger;
                    break;
            }
        }

        public override void onDeath()
        {
            pbPersona.Image = null;
        }
    }
}
