using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProjetoIntegrador.Controllers;
using ProjetoIntegrador.Model;
using ProjetoIntegrador.Models;
using ProjetoIntegrador.Services;

namespace ProjetoIntegrador.Screen
{
    public partial class AddUser : Form
    {
        private AuthController authController;

        public AddUser()
        {
            InitializeComponent();
            DatabaseService databaseService = new DatabaseService();
            AuthService authService = new AuthService(databaseService);
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio(databaseService);
            authController = new AuthController(authService, usuarioRepositorio);

            // Configuração do campo matrícula
            txtMatricula.KeyPress += NumericOnly_KeyPress;
            txtMatricula.MaxLength = 9; // Máximo de 9 dígitos para garantir que cabe em um int
        }

        // Evento para permitir apenas números
        private void NumericOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validação reforçada da matrícula
                if (string.IsNullOrWhiteSpace(txtMatricula.Text) ||
                    !int.TryParse(txtMatricula.Text, out int matricula) ||
                    matricula <= 0 ||
                    txtMatricula.Text.Length > 9)
                {
                    MessageBox.Show("Matrícula inválida. Deve conter até 9 dígitos numéricos positivos.",
                                  "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Resto das validações
                if (txtSenha.Text != txtSenhaConfirmacao.Text)
                {
                    MessageBox.Show("As senhas não coincidem.");
                    return;
                }

                Usuario usuario = new Usuario
                {
                    Nome = txtNomeUsuario.Text,
                    Matricula = matricula, // Já convertido e validado
                    Email = txtEmail.Text,
                    Telefone = txtTelefone.Text,
                    SenhaHash = txtSenha.Text,
                    IdRegra = (int)comboRegras.SelectedValue
                };

                bool result = authController.Register(usuario, txtSenha.Text);
                if (result)
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar usuário.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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