using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegrador.Services
{
    public static class AppCloseWindow
    {
        public static void CloseApp(object sender, FormClosingEventArgs e) {

              Application.ExitThread();
        
        }
    }
}
