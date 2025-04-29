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
        private List<Produto> listProdutos;


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
            listProdutos = produtoController.GetAllProduct();
            dataGridView2.DataSource = listProdutos;


            FormatDataGridView();
        }
        private void FormatDataGridView()
        {
            // Formatação básica do grid
            DataGridFormatter.FormatGrid(
                grid: dataGridView2,
                alternaCoresLinhas: true,
                headerBackgroundColor: Color.SteelBlue,
                headerForeColor: Color.White,
                font: new Font("Segoe UI", 9),
                allowUserToResizeRows: false,
                autoSizeColumnsMode: DataGridViewAutoSizeColumnsMode.Fill,
                readOnly: true,
                selectionMode: DataGridViewSelectionMode.FullRowSelect
            );

            // Formatação das colunas específicas
            DataGridFormatter.FormatColumn(
                grid: dataGridView2,
                columnName: "idProduto",
                headerText: "Id Produto",
                textAlign: DataGridViewContentAlignment.MiddleCenter
            );

            DataGridFormatter.FormatColumn(
                grid: dataGridView2,
                columnName: "NomeProduto",
                headerText: "Nome do Produto",
                width: 180
            );

            DataGridFormatter.FormatColumn(
                grid: dataGridView2,
                columnName: "Descricao",
                headerText: "Descrição",
                width: 180
            );
            DataGridFormatter.FormatColumn(
                grid: dataGridView2,
                columnName: "IdCategoria",
                headerText: "Id Categoria",
                textAlign: DataGridViewContentAlignment.MiddleCenter
            );

            DataGridFormatter.FormatColumn(
                grid: dataGridView2,
                columnName: "Validade",
                headerText: "Validade",
                textAlign: DataGridViewContentAlignment.MiddleCenter
            );

            DataGridFormatter.FormatColumn(
                grid: dataGridView2,
                columnName: "Quantidade",
                textAlign: DataGridViewContentAlignment.MiddleCenter
            );

            DataGridFormatter.FormatColumn(
                grid: dataGridView2,
                columnName: "UnidadeDeMedida",
                headerText: "Unidade de medida",
                textAlign: DataGridViewContentAlignment.MiddleCenter
            );

            DataGridFormatter.FormatColumn(
                grid: dataGridView2,
                columnName: "Preco",
                headerText: "Preço R$",
                textAlign: DataGridViewContentAlignment.MiddleCenter,
                format: "N2"
            );

            DataGridFormatter.FormatColumn(
                grid: dataGridView2,
                columnName: "CodigoDeBarras",
                headerText: "Código de Barras"
            );

            DataGridFormatter.FormatColumn(
                grid: dataGridView2,
                columnName: "Cor",
                headerText: "Cor"
            );

            // Ajustes adicionais
            dataGridView2.Columns["NomeProduto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns["Descricao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Formatação de data se a coluna existir
            if (dataGridView2.Columns.Contains("Validade"))
            {
                dataGridView2.Columns["Validade"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }




        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.ShowDialog();
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
            if (string.IsNullOrEmpty(txtBuscarProduto.Text))
            {
                dataGridView2.DataSource = listProdutos; // Volta à lista original
            }
            else
            {
                // Filtra todos os usuários cujo nome contém o texto digitado
                var produtosFiltrados = listProdutos
                    .Where(produto => produto.NomeProduto.Contains(txtBuscarProduto.Text) || produto.CodigoDeBarras.ToString().Contains(txtBuscarProduto.Text))
                    .ToList();

                dataGridView2.DataSource = produtosFiltrados;
            }
            dataGridView2.ClearSelection();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pnlDataGridProduto_Paint(object sender, PaintEventArgs e)
        {

        }
       
    }
}
