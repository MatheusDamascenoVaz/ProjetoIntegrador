using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoIntegrador.Services;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ProjetoIntegrador.Model.Product
{
    public class ProductRepositorio
    {
        DatabaseService _databaseService;

        public ProductRepositorio(DatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public bool Register(Produto produto)
        {
            try
            {
                string query = @"INSERT INTO produtos 
                                (nomeProduto, idCategoria, descricao, validade, codigoDeBarras, cor, quantidade, unidadeMedida, preco) 
                                VALUES 
                                (@nomeProduto, @idCategoria, @descricao, @validade, @codigoDeBarras, @cor, @quantidade, @unidadeMedida, @preco)";
                var parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@nomeProduto", produto.NomeProduto),
                    new MySqlParameter("@idCategoria", produto.idCategoria),
                    new MySqlParameter("@descricao", produto.Descricao),
                    new MySqlParameter("@validade", produto.Validade),
                    new MySqlParameter("@quantidade", produto.Quantidade),
                    new MySqlParameter("@cor", produto.Cor),
                    new MySqlParameter("@unidadeMedida", produto.UnidadeDeMedida),
                    new MySqlParameter("@preco", produto.Preco),
                    new MySqlParameter("@codigoDeBarras", produto.CodigoDeBarras)
                };
                int affectedRows = _databaseService.ExecuteNonQuery(query, parameters);
                return affectedRows > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao registrar produto: " + ex.Message);
            }
        }
        
        
        public List<Produto> GetAllProducts()
        {
            List<Produto> listaProdutos = new List<Produto>();
            MySqlDataReader dataReader = null;
            try
            {
                string query = @"SELECT * FROM produtos WHERE status = 1";
                                  
                dataReader = _databaseService.ExecuteQuery(query);

                while (dataReader.Read()) { 
                
                    Produto produto = new Produto();
                    produto = Produto.ProdutoFromDataReader(dataReader);

                    listaProdutos.Add(produto);
                               }
                return listaProdutos;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro buscar lista: " + ex.Message);
            }
            finally
            {
                dataReader?.Close();  // Fecha explicitamente o DataReader
                dataReader?.Dispose(); // Libera os recursos
            }
        }
        public List<Produto> BuscarProdutoCodigoDeBarras()

        {
            List<Produto> listaProdutos = new List<Produto>();

            try
            {
                string query = "SELECT NomeProduto, Preco FROM Produtos WHERE CodigoBarras = @CodigoBarras";

                MySqlDataReader dataReader = _databaseService.ExecuteQuery(query);

                while (dataReader.Read()) { 
                
                    Produto produto = new Produto();
                    produto = Produto.ProdutoFromDataReader(dataReader);

                    listaProdutos.Add(produto);
                               }
                return listaProdutos;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar produto: " + ex.Message);
            }
        }

        public bool AtualizaEstoque(ItemVenda item, int novoEstoque)
        {
            try
            {
                string query = $"UPDATE produtos SET quantidade = {novoEstoque} WHERE idProdutos = {item.IdProduto}";
                
                int affectedRows = _databaseService.ExecuteNonQuery(query);
                return affectedRows > 0;
            }
            catch (Exception ex)
            {
                return false;
            }

            
        } 
        
        
        public bool AtualizarProduto(Produto produto)
        {
            
                try
                {
                    string query = @"UPDATE produtos SET  
                                nomeProduto = @nomeProduto, idCategoria = @idCategoria, descricao = @descricao, 
                                validade = @validade, codigoDeBarras = @codigoDeBarras, cor = @cor, quantidade = @quantidade, unidadeMedida = @unidadeMedida, preco = @preco
                                WHERE idProdutos = @idProduto";


                    var parameters = new MySqlParameter[]
                    {
                    new MySqlParameter("@idProduto", produto.IdProduto),
                    new MySqlParameter("@nomeProduto", produto.NomeProduto),
                    new MySqlParameter("@idCategoria", produto.idCategoria),
                    new MySqlParameter("@descricao", produto.Descricao),
                    new MySqlParameter("@validade", produto.Validade),
                    new MySqlParameter("@quantidade", produto.Quantidade),
                    new MySqlParameter("@cor", produto.Cor),
                    new MySqlParameter("@unidadeMedida", produto.UnidadeDeMedida),
                    new MySqlParameter("@preco", produto.Preco),
                    new MySqlParameter("@codigoDeBarras", produto.CodigoDeBarras)
                    };
                    int affectedRows = _databaseService.ExecuteNonQuery(query, parameters);
                    return affectedRows > 0;
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
                string query = $"UPDATE produtos SET status = 0 WHERE idProdutos = {produto.IdProduto}";

                MessageBox.Show(query);

               

                int affectedRows = _databaseService.ExecuteNonQuery(query);
                return affectedRows > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao deletar produto: " + ex.Message);
            }


        }


    }
}
