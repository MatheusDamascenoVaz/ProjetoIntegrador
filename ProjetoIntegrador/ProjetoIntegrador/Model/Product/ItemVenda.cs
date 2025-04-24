using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrador.Model.Product
{
    public class ItemVenda
    {

        public string NomeProduto { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public int QuantidadeVendida { get; set; }

        public decimal PrecoTotal { get; set;}



        public ItemVenda itemFromProduto(Produto produto, int quantidade)
        {

            return new ItemVenda
            {
                NomeProduto = produto.NomeProduto,
                Preco = Convert.ToDecimal(produto.Preco),
                Quantidade = produto.Quantidade,
                QuantidadeVendida = quantidade,
                PrecoTotal = Convert.ToDecimal(produto.Preco) * quantidade,



            };

        }

    }
}
