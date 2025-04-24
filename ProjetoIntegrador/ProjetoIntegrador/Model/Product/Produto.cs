using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ProjetoIntegrador.Models;

namespace ProjetoIntegrador.Model.Product
{
    public class Produto
    {

        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public string Descricao { get; set; }
        public int idCategoria { get; set; }
        public DateTime? Validade { get; set; }
        public int Quantidade { get; set; }
        public string UnidadeDeMedida { get; set; }
        public double Preco { get; set; }
        public double CodigoDeBarras { get; set; }
        public string Cor { get; set; }



        public static Produto ProdutoFromDataReader(MySqlDataReader dataReader) {

            return new Produto
            {

                IdProduto = dataReader.GetInt32("idProdutos"),
                NomeProduto = dataReader["nomeProduto"].ToString(),
                Descricao = dataReader["descricao"].ToString(),
                idCategoria = dataReader.GetInt32("idCategoria"),
                Validade = dataReader["validade"] == DBNull.Value ? null : (DateTime?)Convert.ToDateTime(dataReader["validade"]),
                Quantidade = dataReader.GetInt32("quantidade"),
                UnidadeDeMedida = dataReader["unidadeMedida"].ToString(),
                Preco = dataReader.GetDouble("preco"),
                CodigoDeBarras = dataReader.GetDouble("codigoDeBarras"),
                Cor = dataReader["cor"].ToString(),
             };
        

             
        
        }

       
       
    }


    


}
