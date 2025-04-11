using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProjetoIntegrador.Controllers;
using ProjetoIntegrador.Model.Product;
using ProjetoIntegrador.Services;

namespace ProjetoIntegrador.Screen

{
    public partial class AddProduct: Form

    {
        private AuthController authController;
        public AddProduct()
        {
            InitializeComponent();
            DatabaseService databaseService = new DatabaseService();
           
           

        }

        private void AddProduct_Load(object sender, EventArgs e)
        

        {
            List<dynamic> comboCategoriaProdutos = new List<dynamic>
            {

                new { NomeRegra = "", Valor = 0 },
               new { NomeRegra = "Perecíveis", Valor = 1},
               new { NomeRegra = "Não Perecíveis", Valor = 2},

            };

            comboCategoria.DataSource = comboCategoriaProdutos;
            comboCategoria.DisplayMember = "NomeRegra";
            comboCategoria.ValueMember = "Valor";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.NomeProduto = txtNomeProduto.Text;
            produto.Descricao = txtDescricao.Text;
            produto.idCategoria = (int)comboCategoria.SelectedValue;
            produto.Validade = DateTime.Parse(DateValidade.Text);
            produto.Quantidade = int.Parse(txtQuantidade.Text);
            produto.UnidadeDeMedida = txtUnidadeDeMedida.Text;
            produto.Preco = double.Parse(txtPreco.Text);
            produto.CodigoDeBarras = double.Parse(txtCodigoDeBarras.Text);
            produto.Cor = txtCor.Text;

            
            
        }
    }
}
