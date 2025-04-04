﻿using System;
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
    public partial class MenuPrincipal: Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            this.FormClosing += ApplicationClose;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void ApplicationClose(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult resultadoAcao = MessageBox.Show("Você realmente deseja fazer logout?", "Saindo da Aplicação", MessageBoxButtons.YesNo);
            if (resultadoAcao == DialogResult.Yes)
            {
                LoginScreen loginScreen = new LoginScreen();
                loginScreen.Show();
                this.Hide();
               
            }
            
        }

        private void btnMenuUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddUser addUser = new AddUser();
            addUser.Show();

        }

        private void btnMenuProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
        }
    }
}
