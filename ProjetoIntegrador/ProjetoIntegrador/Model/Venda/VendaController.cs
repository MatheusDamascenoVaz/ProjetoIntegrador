using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Crypto;
using ProjetoIntegrador.Model.Product;

namespace ProjetoIntegrador.Model.Venda
{
   public class VendaController
    {
        private readonly VendaRepositorio _vendaRepositorio;
        private readonly ProductRepositorio _productRepositorio;

        public VendaController(VendaRepositorio vendaRepositorio, ProductRepositorio productRepositorio) {

            _vendaRepositorio = vendaRepositorio;
            _productRepositorio = productRepositorio;


        }

        public bool RegistrarVenda(List<ItemVenda> listaItens){

            Random random = new Random(DateTime.Now.Millisecond);
            int i = 0;



            int numeroPedido = random.Next(100000, 1000000);

            foreach (ItemVenda item in listaItens)
            {
               bool resultado = _vendaRepositorio.RegistrarVenda(item, numeroPedido);

                if (resultado)
                {
                    int novoEstoque = item.Quantidade - item.QuantidadeVendida;
                    _productRepositorio.AtualizaEstoque(item, novoEstoque);
                    i++;
                }

            }

            if (listaItens.Count() == i)
            {
                MessageBox.Show("Venda registrada com sucesso!");
                return true;
            }

            MessageBox.Show("Problemas com o registro da venda");
            return false;


            
        
        }

    }
}
