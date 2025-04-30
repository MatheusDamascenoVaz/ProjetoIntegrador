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
            //comboModifyUnidadeDeMedida.SelectedItem = _produto.UnidadeDeMedida.ToString();
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
            Produto produto = new Produto();

            // chamar o controller
        }
    }
}
