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
    public partial class AddUser: Form
    {
        public AddUser()
        {
            InitializeComponent();
            this.FormClosing += ApplicationClose;
        }
        private void ApplicationClose(object sender, FormClosingEventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }
    }
}
