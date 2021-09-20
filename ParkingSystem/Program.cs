using System;
using System.Windows.Forms;

namespace ParkingSystem
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Manager manager = new Manager();
             Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMainPage(manager));
        }
    }
}
