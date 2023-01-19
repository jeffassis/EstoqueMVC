using ControleVendas.br.com.projeto.conexao;
using ControleVendas.br.com.projeto.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleVendas.br.com.projeto.dao
{
    public class VendaDAO
    {
        private readonly MySqlConnection vcon;

        public VendaDAO()
        {
            this.vcon = new ConnectionFactory().GetConnection();
        }

        public void CadastrarVenda(Venda obj)
        {
            try
            {
                string sql = @"INSERT INTO tb_venda(data_venda, total_venda, cliente_id, obs) VALUES (@data_venda, @total_venda, @cliente_id, @obs)";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@data_venda", obj.Data_venda);
                cmd.Parameters.AddWithValue("@total_venda", obj.Total_venda);
                cmd.Parameters.AddWithValue("@cliente_id", obj.Cliente_id);
                cmd.Parameters.AddWithValue("@obs", obj.Obs);
                vcon.Open();
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Venda concluida com Sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vcon.Close();
                vcon.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aconteceu o erro: " + ex);
            }
        }

        public int RetornaIdUltimaVenda()
        {
            try
            {
                int idVenda = 0;
                string sql = @"SELECT MAX(id_venda) id_venda from tb_venda";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                vcon.Open();

                MySqlDataReader read = cmd.ExecuteReader();
                if (read.Read())
                {
                    idVenda = read.GetInt32("id_venda");
                }
                vcon.Close();
                return idVenda;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aconteceu o erro: " + ex);
                return 0;
            }
        }
   
    
        public DataTable ListarVendasPorPeriodo(DateTime DtInicial, DateTime DtFinal)
        {
            try
            {
                DataTable dt = new DataTable();

                string sql = @"SELECT v.id_venda, v.data_venda, c.nome, v.total_venda, v.obs
                               FROM tb_venda as v
                               INNER JOIN tb_cliente as c ON c.id_cliente=v.cliente_id
                               WHERE v.data_venda
                               BETWEEN @data_inicial AND @data_final";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@data_inicial", DtInicial);
                cmd.Parameters.AddWithValue("@data_final", DtFinal);
                vcon.Open();
                cmd.ExecuteNonQuery();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar o comando: " + ex);
                return null;
            }
        }
    
    
        public DataTable ListarVendas()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = @"select v.id_venda, v.data_venda, c.nome, v.total_venda, v.obs from tb_venda as v
                             inner join tb_cliente as c ON v.cliente_id=c.id_cliente";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                vcon.Open();
                cmd.ExecuteNonQuery();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
    
    }
}
