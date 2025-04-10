using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoIntegrador.Controllers;

namespace ProjetoIntegrador.Screen
{
    public partial class StartScreen: Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {
            CloseSplashScreen();
        }
        private async void CloseSplashScreen()
        {
            await Task.Delay(4000);
            this.Close();
        }
    }
}
