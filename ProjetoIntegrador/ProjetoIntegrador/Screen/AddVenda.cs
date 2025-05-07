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
        private List<ItemVenda> itensVenda = new List<ItemVenda>();
        private GerenciadorVendas _gerenciadorVendas;
        private System.Threading.Timer _searchTimer;

        public AddVenda()
        {
            InitializeComponent();
            this.FormClosing += ApplicationClose;
            _gerenciadorVendas = new GerenciadorVendas();
            DatabaseService dataBaseService = new DatabaseService();
            _vendaController = new VendaController(new VendaRepositorio(dataBaseService), new ProductRepositorio(dataBaseService));

            // Associa os eventos
            txtCodigoDeBarras.KeyPress += txtCodigoDeBarras_KeyPress;
            txtCodigoDeBarras.TextChanged += txtCodigoDeBarras_TextChanged;
            numericQuantidade.ValueChanged += NumericQuantidade_ValueChanged;
        }

        private void ApplicationClose(object sender, FormClosingEventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
        }

        private void txtCodigoDeBarras_TextChanged(object sender, EventArgs e)
        {
            // Cancela o timer anterior se existir
            _searchTimer?.Dispose();

            // Inicia um novo timer com 500ms de delay
            _searchTimer = new System.Threading.Timer(_ =>
            {
                this.Invoke((MethodInvoker)delegate
                {
                    if (txtCodigoDeBarras.Text.Length == 13)
                    {
                        BuscarProdutoAutomaticamente();
                    }
                });
            }, null, 500, System.Threading.Timeout.Infinite);
        }

        private void BuscarProdutoAutomaticamente()
        {
            string codigoBarras = txtCodigoDeBarras.Text.Trim();

            // Validações básicas
            if (string.IsNullOrEmpty(codigoBarras) || codigoBarras.Length != 13 || !codigoBarras.All(char.IsDigit))
            {
                return;
            }

            try
            {
                // Busca o produto no banco de dados
                Produto produtoEncontrado = _gerenciadorVendas.ProdutoPorCodigoBarras(codigoBarras);

                if (produtoEncontrado != null)
                {
                    // Preenche o preço unitário
                    txtValorUnitario.Text = produtoEncontrado.Preco.ToString("N2"); // Formata com 2 casas decimais
                    numericQuantidade.Focus(); // Manda o foco para o campo quantidade
                    // Calcula o preço total inicial
                    CalcularPrecoTotal();
                }
                else
                {
                    txtValorUnitario.Text = string.Empty;
                    txtPrecoTotal.Text = string.Empty;
                    MessageBox.Show("Produto não encontrado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar produto: {ex.Message}");
            }
        }

        private void NumericQuantidade_ValueChanged(object sender, EventArgs e)
        {
            // Calcula o preço total sempre que a quantidade for alterada
            CalcularPrecoTotal();
        }

        private void CalcularPrecoTotal()
        {
            if (!string.IsNullOrEmpty(txtValorUnitario.Text) && numericQuantidade.Value > 0)
            {
                if (decimal.TryParse(txtValorUnitario.Text, out decimal valorUnitario))
                {
                    decimal precoTotal = valorUnitario * numericQuantidade.Value;
                    txtPrecoTotal.Text = precoTotal.ToString("N2");
                }
            }
            else
            {
                txtPrecoTotal.Text = "0,00";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string codigoBarras = txtCodigoDeBarras.Text.Trim();

            // Validação do código de barras
            if (string.IsNullOrEmpty(codigoBarras))
            {
                MessageBox.Show("Digite um código de barras válido.");
                return;
            }

            if (codigoBarras.Length != 13)
            {
                MessageBox.Show("O código de barras deve conter exatamente 13 dígitos.");
                return;
            }

            if (!codigoBarras.All(char.IsDigit))
            {
                MessageBox.Show("O código de barras deve conter apenas números.");
                return;
            }

            int quantidade = (int)numericQuantidade.Value;

            // Verifica se já temos o produto (pode evitar uma nova consulta ao banco)
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

        private void txtCodigoDeBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números, backspace e delete
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            // Limita a 13 caracteres
            if (txtCodigoDeBarras.Text.Length >= 13 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CalcularTotal()
        {
            decimal total = (decimal)itensVenda.Sum(item => item.Preco * item.QuantidadeVendida);
            txtTotalVendas.Text = total.ToString("N2");
        }

        private void LimparCampos()
        {
            txtCodigoDeBarras.Text = string.Empty;
            txtValorUnitario.Text = string.Empty;
            txtPrecoTotal.Text = string.Empty;
            numericQuantidade.Value = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (itensVenda.Any())
            {
                _vendaController.RegistrarVenda(itensVenda);
                itensVenda.Clear();
                dataGridViewItens.DataSource = null;
                txtTotalVendas.Text = string.Empty;
                MessageBox.Show("Venda registrada com sucesso!");
            }
            else
            {
                MessageBox.Show("Sua lista de produtos está vazia");
            }
        }

        private void AddVenda_Load(object sender, EventArgs e)
        {
            FormatDataGridView();
            numericQuantidade.Value = 1; // Define valor inicial como 1
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