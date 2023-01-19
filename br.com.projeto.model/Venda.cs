using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleVendas.br.com.projeto.model
{
    public class Venda
    {
        public int Id { get; set; }
        public int Cliente_id { get; set; }
        public DateTime Data_venda { get; set; }
        public decimal Total_venda { get; set; }
        public string Obs { get; set; }
    }   
}
