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
    public class ItemVendaDAO
    {
        private readonly MySqlConnection vcon;

        public ItemVendaDAO()
        {
            this.vcon = new ConnectionFactory().GetConnection();
        }

        public void CadastrarItem(ItemVenda obj)
        {
            try
            {
                string sql = @"INSERT INTO tb_itemvenda(venda_id, produto_id, qtd, subtotal) VALUES (@venda_id, @produto_id, @qtd, @subtotal)";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@venda_id", obj.Venda_id);
                cmd.Parameters.AddWithValue("@produto_id", obj.Produto_id);
                cmd.Parameters.AddWithValue("@qtd", obj.qtd);
                cmd.Parameters.AddWithValue("@subtotal", obj.Subtotal);
                vcon.Open();
                cmd.ExecuteNonQuery();

                //MessageBox.Show("Item cadastrado com Sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vcon.Close();
                vcon.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Aconteceu o erro: " + ex);
            }

        }
    
        public DataTable ListarItensVenda(int venda_id)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = @"SELECT i.id_item, p.descricao, i.qtd, p.preco, i.subtotal
                                FROM tb_itemvenda as i 
                                INNER JOIN tb_produto as p ON p.id_produto=i.produto_id
                                WHERE venda_id=@id";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@id", venda_id);
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
