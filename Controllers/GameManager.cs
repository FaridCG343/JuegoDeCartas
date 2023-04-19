using JuegoDeCartas.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeCartas.Controllers
{
    public class GameManager
    {
        public Personaje Personaje { get; set; }
        public List<Enemigo> Enemigo { get; set; }
        public int turno;

        public GameManager(Personaje personaje, List<Enemigo> enemigo)
        {
            Personaje = personaje;
            Enemigo = enemigo;
            turno = 0;
        }

        public void NextTurn()
        {
            
            turno++;
        }
    }
}
