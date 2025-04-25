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
        public MenuUser()
        {
            InitializeComponent();
            this.FormClosing += ApplicationClose;
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
    }
}

