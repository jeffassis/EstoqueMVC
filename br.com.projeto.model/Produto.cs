using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleVendas.br.com.projeto.model
{
    public class Produto
    {
        public int Id_produto { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Qtd_estoque { get; set; }
        public int QtdEstoque { get; set; }
        public int Fornecedor_id { get; set; }
    }
}
