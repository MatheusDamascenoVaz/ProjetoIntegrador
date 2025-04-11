using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoIntegrador.Services;

namespace ProjetoIntegrador.Model.Product
{
    class ProdutoController
    {

        private readonly ProductRepositorio _productRepositorio;

        public ProdutoController(ProductRepositorio productRepositorio)
        {
            _productRepositorio = productRepositorio;
        }


        public bool RegisterProduct(Produto produto)
        {
            try
            {
                return _productRepositorio.Register(produto);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao registrar produto: " + ex.Message);
            }
        }



    }
}
