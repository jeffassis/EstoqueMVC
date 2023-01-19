using ControleVendas.br.com.projeto.conexao;
using ControleVendas.br.com.projeto.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
    }
}
