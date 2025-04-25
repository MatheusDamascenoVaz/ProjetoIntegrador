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
using ProjetoIntegrador.Model;
using ProjetoIntegrador.Models;
using ProjetoIntegrador.Services;

namespace ProjetoIntegrador.Screen
{
    public partial class AddUser: Form
    {
        private AuthController authController;
        public AddUser()
        {
            InitializeComponent();
            DatabaseService databaseService = new DatabaseService();
            AuthService authService = new AuthService(databaseService);
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio(databaseService);
            authController = new AuthController(authService, usuarioRepositorio);
            

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Nome = txtNomeUsuario.Text;
            usuario.Matricula = int.Parse(txtMatricula.Text);
            usuario.Email = txtEmail.Text;
            usuario.Telefone = txtTelefone.Text;
            usuario.SenhaHash = txtSenha.Text;
            usuario.IdRegra = (int)comboRegras.SelectedValue;



            if (txtSenha.Text != txtSenhaConfirmacao.Text)
            {
                MessageBox.Show("As senhas não coincidem.");
                return;
            }
           
            bool result = authController.Register(usuario, txtSenha.Text);
            if (result)
            {
                MessageBox.Show("Usuário cadastrado com sucesso!");
            }
            else { 
                MessageBox.Show("Erro ao cadastrar usuário.");
            }

            
        }
        

        private void AddUser_Load(object sender, EventArgs e)
        {
            List<dynamic> comboRegrasItens = new List<dynamic> 
            {

                new { NomeRegra = "Administrador", Valor = 1},
                new { NomeRegra = "Gerente", Valor = 2},
                new { NomeRegra = "Estoquista", Valor = 3},
                new { NomeRegra = "Auditor", Valor = 4},
            };

            comboRegras.DataSource = comboRegrasItens;
            comboRegras.DisplayMember = "NomeRegra";
            comboRegras.ValueMember = "Valor";
        }
    }
}
