using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        
        public List<Produto> GetAllProduct()
        {
            try
            {
                return _productRepositorio.GetAllProducts();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao registrar produto: " + ex.Message);
            }
        } 
        
        
        public bool AtualizarProduto(Produto produto)
        {
            try
            {
                return _productRepositorio.AtualizarProduto(produto);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao registrar produto: " + ex.Message);
            }
        }

        public bool UpdateStatusProduto(Produto produto)
        {

            try
            {
                bool result = _productRepositorio.UpdateStatusProduto(produto);
                if (result)
                {
                    MessageBox.Show("Produto deletado com sucesso");
                    return true;
                }
                MessageBox.Show("Erro ao deletar produto");
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao deletar produto: " + ex.Message);
            }


        }



    }
}
