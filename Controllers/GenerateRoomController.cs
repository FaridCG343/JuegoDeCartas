using JuegoDeCartas.Modelos;
using JuegoDeCartas.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeCartas.Controllers
{
    public class GenerateRoomController
    {
        private readonly Random random = new();
        private readonly List<string> roomTypes = new() { "Enemy", "Boss", "Shop", "Rest", "Chest"};
        private readonly List<Image> roomImg = new() { Resources.Stairs_1, Resources.Stairs_3, Resources.Stairs_7, Resources.Tunnel_10, Resources.Tunnel_29 };
        public void GenerateRoom()
        {
            string roomType = "Enemy";//roomTypes[random.Next(0, roomTypes.Count)]; 
            switch (roomType)
            {
                case "Enemy":
                    Program.enemyRoom = new EnemyRoom();
                    Program.enemyRoom.setBackGround(roomImg[random.Next(0, roomImg.Count)]);
                    int cantEnemigos = random.Next(2, 3);
                    List<Enemigo> enemigos = new();
                    
                    for (int i = 0; i < cantEnemigos; i++)
                    {
                        enemigos.Add(new Esqueleto());
                    }
                    Program.enemyRoom.SetEnemies(enemigos);
                    Program.enemyRoom.Show();
                    break;
                case "Boss":
                    break;
                case "Shop":
                    break;
                case "Rest":
                    break;
                case "Chest":
                    break;
            }
        }
    }
}
