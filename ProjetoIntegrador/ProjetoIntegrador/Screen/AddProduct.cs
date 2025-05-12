using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ProjetoIntegrador.Controllers;
using ProjetoIntegrador.Model.Product;
using ProjetoIntegrador.Services;

namespace ProjetoIntegrador.Screen
{
    public partial class AddProduct : Form
    {
        private readonly ProdutoController _produtoController;

        public AddProduct()
        {
            InitializeComponent();
            _produtoController = new ProdutoController(new ProductRepositorio(new DatabaseService()));

            // Configura os tratamentos para os campos numéricos
            txtCodigoDeBarras.KeyPress += NumericOnly_KeyPress;
            txtCodigoDeBarras.MaxLength = 13;

            txtQuantidade.KeyPress += NumericOnly_KeyPress; // Aceita apenas números inteiros
            txtPreco.KeyPress += DecimalOnly_KeyPress; // Aceita números com decimal
        }

        // Evento para permitir apenas números inteiros
        private void NumericOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Evento para permitir números decimais
        private void DecimalOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            // Permite dígitos, teclas de controle e UM separador decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ',' && e.KeyChar != '.'))
            {
                e.Handled = true;
                return;
            }

            // Verifica se já existe um separador decimal
            if ((e.KeyChar == ',' || e.KeyChar == '.') &&
                (textBox.Text.Contains(',') || textBox.Text.Contains('.')))
            {
                e.Handled = true;
            }
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            List<dynamic> comboCategoriaProdutos = new List<dynamic>
            {
                new { NomeRegra = "Perecíveis", Valor = 1 },
                new { NomeRegra = "Não Perecíveis", Valor = 2 },
            };

            comboCategoria.DataSource = comboCategoriaProdutos;
            comboCategoria.DisplayMember = "NomeRegra";
            comboCategoria.ValueMember = "Valor";

            List<dynamic> unidadeDeMedidaOptions = new List<dynamic>
            {
                new { UnidadeMedida = "Un", Valor = "un" },
                   new { UnidadeMedida = "L", Valor = "L" },
                   new { UnidadeMedida = "ml", Valor = "ml" },
                   new { UnidadeMedida = "Kg", Valor = "kg" },
                   new { UnidadeMedida = "g", Valor =  "g" },
            };

            comboUnidadeDeMedida.DataSource = unidadeDeMedidaOptions;
            comboUnidadeDeMedida.DisplayMember = "NomeRegra";
            comboUnidadeDeMedida.ValueMember = "Valor";

            DateValidade.Value = DateTime.Now.AddMonths(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Validação do código de barras
                if (txtCodigoDeBarras.Text.Length != 13 || !long.TryParse(txtCodigoDeBarras.Text, out long codigoBarras))
                {
                    MessageBox.Show("O código de barras deve conter exatamente 13 dígitos numéricos.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validação da quantidade (inteiro)
                if (!int.TryParse(txtQuantidade.Text, out int quantidade) || quantidade <= 0)
                {
                    MessageBox.Show("Informe uma quantidade válida (número inteiro positivo).", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validação do preço (decimal)
                if (!decimal.TryParse(txtPreco.Text.Replace('.', ','), out decimal preco) || preco <= 0)
                {
                    MessageBox.Show("Informe um preço válido (número positivo).", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Produto produto = new Produto
                {
                    NomeProduto = txtNomeProduto.Text,
                    Descricao = txtDescricao.Text,
                    idCategoria = (int)comboCategoria.SelectedValue,
                    Validade = DateValidade.Value,
                    Quantidade = quantidade,
                    UnidadeDeMedida = comboUnidadeDeMedida.Text,
                    Preco = Convert.ToDouble(preco),
                    CodigoDeBarras = codigoBarras,
                    Cor = txtCor.Text
                };

                bool resultado = _produtoController.RegisterProduct(produto);

                if (resultado)
                {
                    MessageBox.Show("Produto inserido com sucesso");
                    LimparCampos();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Produto não inserido");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampos()
        {
            txtNomeProduto.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            comboCategoria.SelectedIndex = 0;
            DateValidade.Value = DateTime.Now.AddMonths(1);
            txtQuantidade.Text = string.Empty;
            comboUnidadeDeMedida.SelectedIndex = 0;
            txtPreco.Text = string.Empty;
            txtCodigoDeBarras.Text = string.Empty;
            txtCor.Text = string.Empty;

            txtNomeProduto.Focus();
        }
    }
}