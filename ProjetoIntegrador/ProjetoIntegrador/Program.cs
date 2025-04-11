using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoIntegrador.Screen;

namespace ProjetoIntegrador
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            StartScreen startScreen = new StartScreen();
            LoginScreen loginScreen = new LoginScreen();
            //MenuProduct menuProduct = new MenuProduct();

            Application.Run(startScreen);

            if (startScreen.IsDisposed)
            {
            //    Application.Run(menuProduct);
                Application.Run(loginScreen);
            }

        }
    }
}
