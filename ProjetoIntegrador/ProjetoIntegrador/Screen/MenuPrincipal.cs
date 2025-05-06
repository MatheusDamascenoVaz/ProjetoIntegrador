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
using ProjetoIntegrador.Services;

namespace ProjetoIntegrador.Screen
{
    public partial class MenuPrincipal: Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            this.FormClosing += AppCloseWindow.CloseApp;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            lblUserLogado.Text = SessionUser.userLogado.Nome;
        }

        private void imgLogout_Click(object sender, EventArgs e)
        {
            DialogResult resultadoAcao = MessageBox.Show("Você realmente deseja fazer logout?", "Saindo da Aplicação", MessageBoxButtons.YesNo);
            if (resultadoAcao == DialogResult.Yes)
            {
                LoginScreen loginScreen = new LoginScreen();
                loginScreen.Show();
                this.Hide();

            }
    
        }

        private void pnlUsuarios_Click(object sender, EventArgs e)
        {
            

            if (GerenciadorPermissoes.ValidarPermissao(SessionUser.userLogado, Funcionalidade.GerenciarUsuarios))
            {
                this.Hide();
                MenuUser menuUser = new MenuUser();
                menuUser.Show();
            }

           
        }

        private void pnlProdutos_Click(object sender, EventArgs e)
        {
            if (GerenciadorPermissoes.ValidarPermissao(SessionUser.userLogado, Funcionalidade.AdicionarProduto))
            {
                this.Hide();
                MenuProduct addProduct = new MenuProduct();
                addProduct.Show();
            }
        }
        private void pnlVendas_Click(object sender, EventArgs e)
        {
            if (GerenciadorPermissoes.ValidarPermissao(SessionUser.userLogado, Funcionalidade.GerenciarVendas))
            {
                this.Hide();
                AddVenda addVenda = new AddVenda();
                addVenda.Show();
            }
            
        }
        private void pnlRelatorios_Click(object sender, EventArgs e)
        {
            if (GerenciadorPermissoes.ValidarPermissao(SessionUser.userLogado, Funcionalidade.Relatorios))
            {
                this.Hide();
                AddRelatorio addRelatorio = new AddRelatorio();
                addRelatorio.Show();
            }
        }

        private void imgAjuda_Click(object sender, EventArgs e)
        {
            Ajuda ajuda = new Ajuda();
            ajuda.Show();
        }
    }
}
