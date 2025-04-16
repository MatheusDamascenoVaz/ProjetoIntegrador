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

namespace ProjetoIntegrador.Screen
{
    public partial class AddVenda : Form
    {
        private List<Produto> produtos; 
        private List<ItemVenda> itensVenda = new List<ItemVenda>(); 

        public AddVenda()
        {
            InitializeComponent();
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

            Produto produto = produtos.FirstOrDefault(p => p.CodigoDeBarras == codigoBarrasDouble);

            if (produto == null)
            {
                MessageBox.Show("Produto não encontrado!");
                return;
            }

            if (quantidade > produto.Quantidade)
            {
                MessageBox.Show("Quantidade indisponível em estoque.");
                return;
            }
            itensVenda.Add(new ItemVenda
            {
                NomeProduto = produto.NomeProduto,
                Preco = (decimal)produto.Preco,
                Quantidade = quantidade
            });

            dataGridViewItens.DataSource = null;
            dataGridViewItens.DataSource = itensVenda;
                       
            CalcularTotal();
            LimparCampos();
        }

        private void CalcularTotal()
        {
            decimal total = itensVenda.Sum(item => item.Preco * item.Quantidade);
            lblTotal.Text = $"Total: {total:C}"; 
        }

        private void LimparCampos()
        {
            txtCodigoDeBarras.Text = string.Empty;
            numericQuantidade.Value = 1;
        }
    }
}