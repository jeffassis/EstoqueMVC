﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleVendas.br.com.projeto.model
{
    public class ItemVenda
    {
        public int Id { get; set; }
        public int Venda_id { get; set; }
        public int Produto_id { get; set; }
        public int qtd { get; set; }
        public decimal Subtotal { get; set; }
    }
}
