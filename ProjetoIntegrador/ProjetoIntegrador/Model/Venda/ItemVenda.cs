using System;
using System.Data.SqlClient;
using System.Drawing;
using MySql.Data.MySqlClient;
using ProjetoIntegrador.Model.Product;
using ProjetoIntegrador.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

public class GerenciadorVendas
{
    private string conexaoBanco;
    DatabaseService _databaseService;

    public GerenciadorVendas(string stringConexao)
    {
        conexaoBanco = stringConexao;
        _databaseService = new DatabaseService();
    }

    public void RegistrarVenda(int idProduto, int quantidade)
    {
        // Verificar se há estoque suficiente
        if (!VerificarEstoque(idProduto, quantidade))
        {
            throw new Exception($"Estoque insuficiente para o produto ID {idProduto}. Quantidade disponível: {ObterQuantidadeEstoque(idProduto)}");
        }

        using (SqlConnection conexao = new SqlConnection(conexaoBanco))
        {
            conexao.Open();

            try
            {
                // Atualizar o estoque
                string sqlAtualizar = "UPDATE Produtos SET Quantidade = Quantidade - @qtd WHERE Id = @id";
                SqlCommand cmdAtualizar = new SqlCommand(sqlAtualizar, conexao);
                cmdAtualizar.Parameters.AddWithValue("@id", idProduto);
                cmdAtualizar.Parameters.AddWithValue("@qtd", quantidade);
                cmdAtualizar.ExecuteNonQuery();

                // Registrar a venda
                string sqlVenda = "INSERT INTO Vendas (ProdutoId, Quantidade, Data) VALUES (@id, @qtd, @data)";
                SqlCommand cmdVenda = new SqlCommand(sqlVenda, conexao);
                cmdVenda.Parameters.AddWithValue("@id", idProduto);
                cmdVenda.Parameters.AddWithValue("@qtd", quantidade);
                cmdVenda.Parameters.AddWithValue("@data", DateTime.Now);
                cmdVenda.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao registrar venda: " + ex.Message);
            }
        }
    }

    private bool VerificarEstoque(int idProduto, int quantidadeDesejada)
    {
        int estoqueAtual = ObterQuantidadeEstoque(idProduto);
        return estoqueAtual >= quantidadeDesejada;
    }

    private int ObterQuantidadeEstoque(int idProduto)
    {
        using (SqlConnection conexao = new SqlConnection(conexaoBanco))
        {
            string sql = "SELECT Quantidade FROM Produtos WHERE Id = @id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", idProduto);

            conexao.Open();
            object resultado = cmd.ExecuteScalar();

            if (resultado == null)
                throw new Exception($"Produto com ID {idProduto} não encontrado.");

            return Convert.ToInt32(resultado);
        }
    }
    
    private Produto ProdutoPorCodigoBarras(string barCode)
    {
        
       
             string sql = "SELECT * FROM produtos WHERE codigoDeBarras = @barCode";
             var parameters = new MySqlParameter[]
                {

                    new MySqlParameter("@barCode", barCode),

                };

        using (MySqlDataReader produtoBuscado = _databaseService.ExecuteQuery(sql, parameters))
        {



            if (produtoBuscado != null) { 
            
                Produto produto = Produto.ProdutoFromDataReader(produtoBuscado);
                return produto;
                            
            }
               
            Produto produto1 = new Produto();
            return produto1;
            

        }

       

    }
}