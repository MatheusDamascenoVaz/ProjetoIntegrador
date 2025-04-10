using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoIntegrador.Screen;
using ProjetoIntegrador.Services;

namespace ProjetoIntegrador
{
    public partial class LoginScreen: Form
    {
        public LoginScreen()
        {
            InitializeComponent();
            this.FormClosing += AppCloseWindow.CloseApp;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Por gentileza preencha todos os campos para efetuar o login");
            }
            if (txtUsuario.Text == "admin" && txtSenha.Text == "1234")
            {
                this.Hide();

                MenuPrincipal menuPrincipal = new MenuPrincipal();
                menuPrincipal.Show();

            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }
      
    }
}
