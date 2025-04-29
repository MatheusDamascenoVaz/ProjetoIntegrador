using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProjetoIntegrador.Model.Product;
using ProjetoIntegrador.Models;
using ProjetoIntegrador.Services;

namespace ProjetoIntegrador.Model.Venda
{
   public class VendaRepositorio
    {
        DatabaseService _databaseService;

        public VendaRepositorio(DatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

       public bool RegistrarVenda(ItemVenda itemVenda, int pedido) {


            try
            {
                string query = $"INSERT INTO vendas (idProdutos, quantidade, pedido) VALUES ({itemVenda.IdProduto}, {itemVenda.QuantidadeVendida}, @pedido)";

                var parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@pedido", pedido),
                };

                int affectedRows = _databaseService.ExecuteNonQuery(query, parameters);
                return affectedRows > 0;


            }
            catch (Exception ex) { 
            
                return false;
            
            }         
        
        
        }
        
       
    }
}
