using System;
using System.Windows.Forms;
using XOGame_Model;

namespace XOGame_View
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Settings settings = new Settings();
            Menu menu = new Menu(settings);

            Application.Run(menu);
        }
    }
}
