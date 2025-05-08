using ProjetoIntegrador.Controllers;
using ProjetoIntegrador.Model;
using ProjetoIntegrador.Model.Product;
using ProjetoIntegrador.Models;
using ProjetoIntegrador.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegrador.Screen
{
    public partial class ModifyUser : Form
    {
        private readonly AuthController _authController;
        private readonly UsuarioRepositorio _usuarioRepositorio;
        private readonly Usuario _usuario;

        public ModifyUser(Usuario usuario)
        {
            InitializeComponent();
            //inicializei o authController

            var databaseService = new DatabaseService();
            _usuarioRepositorio = new UsuarioRepositorio(databaseService);
            _authController = new AuthController(new AuthService(databaseService), _usuarioRepositorio);
            _usuario = usuario;

            SetUserData();
        }

        private void SetUserData()
        {
            txtModifyMatricula.Text = _usuario.Matricula.ToString();
            txtModifyNomeUsuario.Text = _usuario.Nome;
            txtModifyEmail.Text = _usuario.Email;
            txtModifyTelefone.Text = _usuario.Telefone;
            comboModifyRegras.SelectedValue = _usuario.IdRegra;
        }

        private void ModifyUser_Load(object sender, EventArgs e)
        {
            var regras = new List<dynamic>
        {
            new { NomeRegra = "Administrador", Valor = 1 },
            new { NomeRegra = "Gerente", Valor = 2 },
            new { NomeRegra = "Estoquista", Valor = 3 },
            new { NomeRegra = "Auditor", Valor = 4 }
        };

            comboModifyRegras.DataSource = regras;
            comboModifyRegras.DisplayMember = "NomeRegra";
            comboModifyRegras.ValueMember = "Valor";
        }

        private void btnSaveModifyUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                bool senhaAlterada = !string.IsNullOrEmpty(txtModifySenha.Text) &&
                                    txtModifySenha.Text != _usuario.SenhaHash;

                if (senhaAlterada && txtModifySenha.Text != txtModifySenhaConfirmacao.Text)
                {
                    MessageBox.Show("As senhas não coincidem!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var usuarioAtualizado = new Usuario
                {
                    Id = _usuario.Id,
                    Matricula = int.Parse(txtModifyMatricula.Text.Trim()),
                    Nome = txtModifyNomeUsuario.Text.Trim(),
                    Email = txtModifyEmail.Text.Trim(),
                    Telefone = txtModifyTelefone.Text.Trim(),
                    //adicionei o GerarHashSenha aqui
                    SenhaHash = senhaAlterada ?
                              _authController.GerarHashSenha(txtModifySenha.Text) :
                              _usuario.SenhaHash,
                    IdRegra = (int)comboModifyRegras.SelectedValue
                };

                if (string.IsNullOrWhiteSpace(usuarioAtualizado.Nome))
                {
                    MessageBox.Show("O nome do usuário é obrigatório!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (_usuarioRepositorio.AtualizarUsuario(usuarioAtualizado))
                {
                    MessageBox.Show("Usuário atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Falha ao atualizar o usuário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar usuário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
