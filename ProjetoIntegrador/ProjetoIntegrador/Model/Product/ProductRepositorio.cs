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
                                (idProduto, nomeProduto, idCategoria, descricao, validade, codigoDeBarras, cor, quantidade, unidadedeMedida, preco) 
                                VALUES 
                                (@idProduto, @nomeProduto, @idCategoria, @descricao, @validade, @codigoDeBarras, @cor, @quantidade, @unidadedeMedida, @preco)";
                var parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@idProduto", produto.IdProduto),
                    new MySqlParameter("@nomeProduto", produto.NomeProduto),
                    new MySqlParameter("@idCategoria", produto.idCategoria),
                    new MySqlParameter("@descricaoProduto", produto.Descricao),
                    new MySqlParameter("@validade", produto.Validade),
                    new MySqlParameter("@quantidade", produto.Quantidade),
                    new MySqlParameter("@cor", produto.Cor),
                    new MySqlParameter("@unidadeDeMedida", produto.UnidadeDeMedida),
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
    }
}
