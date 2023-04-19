using JuegoDeCartas.Controllers;
using JuegoDeCartas.Modelos;
using System.Security.Cryptography.X509Certificates;

namespace JuegoDeCartas
{
    internal static class Program
    {
        public static Menu menu;
        public static Personaje personaje;
        public static EnemyRoom enemyRoom;
        public static GenerateRoomController generateRoomController = new();
        public static int currentRoom = 0;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            // ApplicationConfiguration.Initialize();
            global::System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            global::System.Windows.Forms.Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.Run(new LogIn());
        }
    }
}