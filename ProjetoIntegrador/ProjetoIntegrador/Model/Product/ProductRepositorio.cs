using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoIntegrador.Services;
using MySql.Data.MySqlClient;

namespace ProjetoIntegrador.Model.Product
{
    class ProductRepositorio
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

            try
            {
                string query = @"SELECT * FROM produtos";
                                  
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
                throw new Exception("Erro ao registrar produto: " + ex.Message);
            }
        }
    }
}
