using JuegoDeCartas.Controllers;
using System;

namespace JuegoDeCartas.Modelos
{
    public class Card
    {
        public string Name { get; set; }
        public string Action { get; set; }
        public int EnergyCost { get; set; }
        public int Value { get; set; }
        public string Descripcion { get; set; }
        public string AttackDes = "Ataca una vez \na un enemigo";
        public string HealDes = "Recupera una vez \n5 pts de vida";
        public string DefendDes = "Defiende una vez";
        public Image Image { get; set; }

        public Card(string name, string action, int energyCost, int value, Image image)
        {
            Name = name;
            Action = action;
            EnergyCost = energyCost;
            Value = value;
            switch (action)
            {
                case "Ataque":
                    Descripcion = AttackDes;
                    break;
                case "Curar":
                    Descripcion = HealDes;
                    break;
                case "Defensa":
                    Descripcion = DefendDes;
                    break;
                default:
                    Descripcion = AttackDes;
                    break;
            }
            Image = image;
        }

        public bool activarCarta(Personaje personaje, Enemigo enemigo)
        {
            switch (Action)
            {
                case "Ataque":
                    if (enemigo.Muerto)
                    {
                        return false;
                    }
                    personaje.atacar(enemigo, personaje.Ataque);
                    break;
                case "Curar":
                    personaje.curar(Value);
                    break;
                case "Defensa":
                    personaje.defenderse();
                    break;
            }
            return true;
        }
    }
}
