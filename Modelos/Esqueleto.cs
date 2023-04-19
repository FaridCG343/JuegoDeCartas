using JuegoDeCartas.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeCartas.Modelos
{
    internal class Esqueleto: Enemigo
    {
        public Esqueleto() : base("Esqueleto", 40, 10, 4, Resources.SkeletonIdle2, Resources.SkeletonAttack, Resources.SkeletonHit)
        {
        }
    }
}
