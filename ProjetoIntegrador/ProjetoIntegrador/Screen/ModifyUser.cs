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
    }
}