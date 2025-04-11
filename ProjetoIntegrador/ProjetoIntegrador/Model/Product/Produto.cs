using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrador.Model.Product
{
    class Produto
    {

        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public string Descricao { get; set; }
        public int idCategoria { get; set; }
        public DateTime Validade { get; set; }
        public int Quantidade { get; set; }
        public string UnidadeDeMedida { get; set; }
        public double Preco { get; set; }
        public double CodigoDeBarras { get; set; }
        public string Cor { get; set; }

    }
}
