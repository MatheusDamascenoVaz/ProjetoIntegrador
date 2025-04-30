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
using ProjetoIntegrador.Services;

namespace ProjetoIntegrador.Screen
{
    public partial class ModifyProduct: Form
    {
        private readonly ProdutoController _produtoController;
        private readonly ProductRepositorio _produtoRepositorio;
        private Produto _produto;

        public ModifyProduct(Produto produto)
        {
            InitializeComponent();
            _produtoController = new ProdutoController(new ProductRepositorio(new DatabaseService()));
            _produto = produto;

        }

        private void ModifyProduct_Load(object sender, EventArgs e)
        {
            txtModifyNomeProduto.Text = _produto.NomeProduto;
            txtModifyDescricao.Text = _produto.Descricao;
            //comboModifyCategoria.SelectedIndex = _produto.idCategoria;
            ModifyDateValidade.Text = _produto.Validade.ToString();
            txtModifyQuantidade.Text = _produto.Quantidade.ToString();
            comboModifyUnidadeDeMedida.SelectedItem = _produto.UnidadeDeMedida.ToString();
            txtModifyPreco.Text = _produto.Preco.ToString();
            txtModifyCodigoDeBarras.Text = _produto.CodigoDeBarras.ToString();
            txtModifyCor.Text = _produto.Cor;


            List<dynamic> comboModifyCategoriaProdutos = new List<dynamic>
               {

                   new { NomeRegra = "Perecíveis", Valor = 1 },
                   new { NomeRegra = "Não Perecíveis", Valor = 2 },
               };

            comboModifyCategoria.DataSource = comboModifyCategoriaProdutos;
            comboModifyCategoria.DisplayMember = "NomeRegra";
            comboModifyCategoria.ValueMember = "Valor";

            // Fix: Correct the variable name to avoid conflict and ensure proper assignment
            List<dynamic> unidadeDeMedidaOptions = new List<dynamic>
               {

                   new { NomeRegra = "Un", Valor = 1 },
                   new { NomeRegra = "L", Valor = 2 },
                   new { NomeRegra = "ml", Valor = 3 },
                   new { NomeRegra = "Kg", Valor = 4 },
                   new { NomeRegra = "g", Valor =  5 },

               };

            comboModifyUnidadeDeMedida.DataSource = unidadeDeMedidaOptions;
            comboModifyUnidadeDeMedida.DisplayMember = "NomeRegra";
            comboModifyUnidadeDeMedida.ValueMember = "Valor";
        }

        private void btnSaveModifyProduto_Click(object sender, EventArgs e)
        {
            //Montar o objeto aqui (Produto) com os dados dos textBox
            try
            {
                // Montar o objeto Produto com os dados atualizados
                Produto produtoAtualizado = new Produto
                {
                    // Mantém o ID original para atualização
                    IdProduto = _produto.IdProduto,

                    // Strings diretas (com trim para remover espaços extras)
                    NomeProduto = txtModifyNomeProduto.Text.Trim(),
                    Descricao = txtModifyDescricao.Text.Trim(),
                    Cor = txtModifyCor.Text.Trim(),
                    CodigoDeBarras = double.Parse(txtModifyCodigoDeBarras.Text),

                    // Combobox de Categoria (usando ValueMember)
                    idCategoria = comboModifyCategoria.SelectedValue != null ?
                                 Convert.ToInt32(comboModifyCategoria.SelectedValue) :
                                 _produto.idCategoria,

                    // Combobox de Unidade de Medida (usando o valor selecionado)
                    UnidadeDeMedida = comboModifyUnidadeDeMedida.SelectedValue != null ?
                                    comboModifyUnidadeDeMedida.SelectedValue.ToString() :
                                    _produto.UnidadeDeMedida,

                    // Conversões numéricas seguras
                    Quantidade = int.TryParse(txtModifyQuantidade.Text, out int qtd) ? qtd : _produto.Quantidade,

                    Preco = decimal.TryParse(txtModifyPreco.Text, out decimal precoDecimal)
    ? (double)precoDecimal
    : (double)_produto.Preco,

                    // Conversão segura de data
                    Validade = DateTime.TryParse(ModifyDateValidade.Text, out DateTime validade) ?
                              validade : _produto.Validade
                };

                // Chamar o controller para atualizar
                bool sucesso = _produtoRepositorio.AtualizarProduto(produtoAtualizado);

                if (sucesso)
                {
                    MessageBox.Show("Produto atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Falha ao atualizar o produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
    }

