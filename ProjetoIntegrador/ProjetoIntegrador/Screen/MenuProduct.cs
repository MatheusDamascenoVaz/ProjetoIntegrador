using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProjetoIntegrador.Model.Product;
using ProjetoIntegrador.Services;

namespace ProjetoIntegrador.Screen

{
    public partial class MenuProduct : Form
    {
        private DatabaseService databaseService = new DatabaseService(); 
        private ProdutoController produtoController;

        public MenuProduct()
        {
            InitializeComponent();
            this.FormClosing += ApplicationClose;
            produtoController = new ProdutoController(new ProductRepositorio(databaseService));
        }


        private void ApplicationClose(object sender, FormClosingEventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            List<Produto> listaProdutos = new List<Produto>();
            listaProdutos = produtoController.GetAllProduct();


            dataGridView1.DataSource = listaProdutos;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teste");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teste");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.ShowDialog();
        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {

        }

        private void lblBuscarProduto_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarProduto_Click(object sender, EventArgs e)
        {

        }

        private void btnAttDataGridProduto_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoverProduto_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterarProduto_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscarProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pnlDataGridProduto_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
