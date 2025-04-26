using ProjetoIntegrador.Model;
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
    public partial class MenuUser: Form
    {
        private DatabaseService databaseService = new DatabaseService();
        private UsuarioRepositorio usuarioRepositorio;
        private List<Usuario> listUsuarios;
        
        public MenuUser()
        {
            InitializeComponent();
            this.FormClosing += ApplicationClose;
            usuarioRepositorio = new UsuarioRepositorio(databaseService);
        }
        private void ApplicationClose(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
        }

        private void btnAlterarUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnAddUsuario_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MenuUser_Load(object sender, EventArgs e)
        {

            listUsuarios = usuarioRepositorio.GetAllUsers();
            dataGridView1.DataSource = listUsuarios;
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
           Usuario usuarioEncontrado = listUsuarios.Find(usuario => usuario.Nome == txtBuscarUsuario.Text);
            List<Usuario> listaFiltrada = new List<Usuario>();

            MessageBox.Show(usuarioEncontrado.Email);   

            listUsuarios.Clear();
            listaFiltrada.Add(usuarioEncontrado);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaFiltrada;
            dataGridView1.ClearSelection();
            
        }



        private void txtBuscarUsuario_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscarUsuario.Text))
            {
                dataGridView1.DataSource = listUsuarios; // Volta à lista original
            }
            else
            {
                // Filtra todos os usuários cujo nome contém o texto digitado
                var usuariosFiltrados = listUsuarios
                    .Where(usuario => usuario.Nome.Contains(txtBuscarUsuario.Text) || usuario.Matricula.ToString().Contains(txtBuscarUsuario.Text))
                    .ToList();

                dataGridView1.DataSource = usuariosFiltrados;
            }
            dataGridView1.ClearSelection();
        }
    }
}

