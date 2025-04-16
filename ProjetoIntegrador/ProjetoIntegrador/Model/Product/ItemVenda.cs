using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrador.Model.Product
{
    public class ItemVenda
    {
               
            public string NomeProduto { get; set; }
            public decimal Preco { get; set; }
            public int Quantidade { get; set; }
            public decimal PrecoTotal { get { return Preco * Quantidade; } }
        
    }
}
