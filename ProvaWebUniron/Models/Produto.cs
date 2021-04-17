using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaWebUniron.Models
{
    public class Produto
    {
        public int CodigoId { get; set; }
        public string CodProduto { get; set; }
        public decimal Preco { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public string Observacao { get; set; }
        
    }
}
