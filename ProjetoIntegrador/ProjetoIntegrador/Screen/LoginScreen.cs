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
using ProjetoIntegrador.Models;
using ProjetoIntegrador.Screen;
using ProjetoIntegrador.Services;

namespace ProjetoIntegrador
{
    public partial class LoginScreen: Form
    {
       private AuthController authController;
        public LoginScreen()
        {
            InitializeComponent();
            this.FormClosing += AppCloseWindow.CloseApp;
            DatabaseService databaseService = new DatabaseService();
            authController = new AuthController(new AuthService(databaseService), new Model.UsuarioRepositorio(databaseService));

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Usuario user = authController.Login(txtEmail.Text, txtSenha.Text);

            if (user == null)
            {
                MessageBox.Show("Usuário não encontrado");
                return;
            }
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }
      
    }
}
