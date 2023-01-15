using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleVendas.br.com.projeto.conexao
{
    public class ConnectionFactory
    {
        // Metodo conecta banco de dados

        public MySqlConnection GetConnection()
        {
            string vcon = ConfigurationManager.ConnectionStrings["project_estoque"].ConnectionString;
            return new MySqlConnection(vcon);
        }
    }
}
