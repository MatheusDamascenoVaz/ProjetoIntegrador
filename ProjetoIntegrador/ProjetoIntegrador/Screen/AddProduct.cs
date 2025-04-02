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
    public partial class AddProduct: Form
    {
        public AddProduct()
        {
            InitializeComponent();
            this.FormClosing += ApplicationClose;
        }
        private void ApplicationClose(object sender, FormClosingEventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teste");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teste");
        }
    }
}
