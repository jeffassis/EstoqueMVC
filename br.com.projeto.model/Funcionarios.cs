using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleVendas.br.com.projeto.model
{
    public class Funcionarios : Cliente
    {
        public string Senha { get; set; }
        public string Cargo { get; set; }
        public string Nivel { get; set; }
    }
}
