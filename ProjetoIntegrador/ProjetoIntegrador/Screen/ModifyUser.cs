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
        private readonly UsuarioRepositorio _usuarioRepositorio;

        private DatabaseService _dabaseService;
        private Usuario _usuario;
        public ModifyUser(Usuario usuario)
        {
            InitializeComponent();
            _usuarioRepositorio = new UsuarioRepositorio(new DatabaseService());
            _usuario = usuario;
            SetUserData();
        }


        private void SetUserData()
        {
            txtModifyMatricula.Text = _usuario.Matricula.ToString();
            txtModifyNomeUsuario.Text = _usuario.Nome;
            txtModifyEmail.Text = _usuario.Email;
            txtModifyTelefone.Text = _usuario.Telefone;
            txtModifySenha.Text = _usuario.SenhaHash;
            txtModifySenhaConfirmacao.Text = _usuario.SenhaHash;
            comboModifyRegras.SelectedItem = _usuario.IdRegra;

        }

        private void ModifyUser_Load(object sender, EventArgs e)
        {

            // SetUserData();
            List<dynamic> comboModifyRegrasItens = new List<dynamic>
    {

        new { NomeRegra = "Administrador", Valor = 1},
        new { NomeRegra = "Gerente", Valor = 2},
        new { NomeRegra = "Estoquista", Valor = 3},
        new { NomeRegra = "Auditor", Valor = 4},
    };

            comboModifyRegras.DataSource = comboModifyRegrasItens;
            comboModifyRegras.DisplayMember = "NomeRegra";
            comboModifyRegras.ValueMember = "Valor";
          

        }
    private void btnSaveModifyUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                // Montar o objeto Usuario com os dados atualizados
                Usuario usuarioAtualizado = new Usuario
                {
                    // Mantém o ID original para atualização
                    Id = _usuario.Id,

                    // Strings diretas (com trim para remover espaços extras)
                    Matricula = int.TryParse(txtModifyMatricula.Text.Trim(), out int matricula) ?
                       matricula :
                       throw new ArgumentException("Matrícula deve ser um número válido"),
                    Nome = txtModifyNomeUsuario.Text.Trim(),
                    Email = txtModifyEmail.Text.Trim(),
                    Telefone = txtModifyTelefone.Text.Trim(),

                    // Mantém a senha atual se os campos estiverem vazios
                    SenhaHash = string.IsNullOrEmpty(txtModifySenha.Text) ?
                               _usuario.SenhaHash :
                               txtModifySenha.Text,

                    // Combobox de Regras (usando ValueMember)
                    IdRegra = comboModifyRegras.SelectedValue != null ?
                             Convert.ToInt32(comboModifyRegras.SelectedValue) :
                             _usuario.IdRegra,

                    // Você pode adicionar outros campos específicos do usuário aqui
                    // Por exemplo:
                    // Ativo = checkModifyAtivo.Checked,
                    // DataCadastro = _usuario.DataCadastro // mantém a data original
                };

                // Validações adicionais
                if (string.IsNullOrWhiteSpace(usuarioAtualizado.Nome))
                {
                    MessageBox.Show("O nome do usuário é obrigatório!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtModifySenha.Text != txtModifySenhaConfirmacao.Text)
                {
                    MessageBox.Show("As senhas não coincidem!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Chamar o repositório para atualizar
                bool sucesso = _usuarioRepositorio.AtualizarUsuario(usuarioAtualizado);

                if (sucesso)
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

