using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoIntegrador.Model.Product;
using ProjetoIntegrador.Model.Venda;
using ProjetoIntegrador.Services;

namespace ProjetoIntegrador.Screen
{
    public partial class AddVenda : Form
    {
        private List<Produto> produtos;
        private VendaController _vendaController;
        //private List<ItemVenda> itensVenda = new List<ItemVenda>();
        private List<ItemVenda> itensVenda = new List<ItemVenda>();
        private GerenciadorVendas _gerenciadorVendas;


        public AddVenda()
        {
            InitializeComponent();
            this.FormClosing += ApplicationClose;
            _gerenciadorVendas = new GerenciadorVendas();
            DatabaseService dataBaseService = new DatabaseService();
            _vendaController = new VendaController(new VendaRepositorio(dataBaseService), new ProductRepositorio(dataBaseService));


        }
        private void ApplicationClose(object sender, FormClosingEventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string codigoBarras = txtCodigoDeBarras.Text;



            int quantidade = (int)numericQuantidade.Value;

            if (string.IsNullOrEmpty(codigoBarras))
            {
                MessageBox.Show("Digite um código de barras válido.");
                return;
            }

            if (!double.TryParse(codigoBarras, out double codigoBarrasDouble))
            {
                MessageBox.Show("Código de barras inválido.");
                return;
            }

            //Produto produto = produtos.FirstOrDefault(p => p.CodigoDeBarras == codigoBarrasDouble);

            Produto produtoEncontrado = _gerenciadorVendas.ProdutoPorCodigoBarras(codigoBarras);

            if (produtoEncontrado == null)
            {
                MessageBox.Show("Produto não encontrado!");
                return;
            }

            if (quantidade > produtoEncontrado.Quantidade)
            {
                MessageBox.Show("Quantidade indisponível em estoque.");
                return;
            }

            ItemVenda itemVenda = new ItemVenda();



            itensVenda.Add(itemVenda.itemFromProduto(produtoEncontrado, quantidade));


            dataGridViewItens.DataSource = null;
            dataGridViewItens.DataSource = itensVenda;

            CalcularTotal();
            LimparCampos();
        }

        private void CalcularTotal()
        {
            decimal total = (decimal)itensVenda.Sum(item => item.Preco * item.QuantidadeVendida);
            txtTotalVendas.Text = $" {total:C}";
        }

        private void LimparCampos()
        {
            txtCodigoDeBarras.Text = string.Empty;
            numericQuantidade.Value = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (itensVenda.Any())
            {
                _vendaController.RegistrarVenda(itensVenda);
            }
            else
            {

                MessageBox.Show("Sua lista de produtos está vazia");

            }
        }

        private void numericQuantidade_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddVenda_Load(object sender, EventArgs e)
        {
            FormatDataGridView();
        }
        private void FormatDataGridView()
        {
            // Formatação básica do grid
            DataGridFormatter.FormatGrid(
                grid: dataGridViewItens,
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
                grid: dataGridViewItens,
                columnName: "IdProduto",
                headerText: "Id de Produto",
                textAlign: DataGridViewContentAlignment.MiddleCenter
            );

            DataGridFormatter.FormatColumn(
                grid: dataGridViewItens,
                columnName: "NomeProduto",
                headerText: "Nome do Produto"

            );
            DataGridFormatter.FormatColumn(
                grid: dataGridViewItens,
                columnName: "Preco",
                headerText: "Preço R$",
                textAlign: DataGridViewContentAlignment.MiddleCenter,
                format: "N2"
            );

            DataGridFormatter.FormatColumn(
                grid: dataGridViewItens,
                columnName: "Quantidade",
                textAlign: DataGridViewContentAlignment.MiddleCenter
            );

            DataGridFormatter.FormatColumn(
                grid: dataGridViewItens,
                columnName: "QuantidadeVendida",
                headerText: "Quantidade Vendida",
                textAlign: DataGridViewContentAlignment.MiddleCenter
            );

            DataGridFormatter.FormatColumn(
                grid: dataGridViewItens,
                columnName: "PrecoTotal",
                headerText: "Preço Total R$",
                textAlign: DataGridViewContentAlignment.MiddleCenter,
                format: "N2"
            );

        }

        
    }
}