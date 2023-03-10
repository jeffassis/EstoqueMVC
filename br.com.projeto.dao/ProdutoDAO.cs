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
    public class ProdutoDAO
    {
        private readonly MySqlConnection vcon;

        public ProdutoDAO()
        {
            this.vcon = new ConnectionFactory().GetConnection();
        }

        public void CadastrarProduto(Produto obj)
        {
            try
            {
                string sql = @"INSERT INTO tb_produto(descricao, preco, qtd_estoque, fornecedor_id) 
                            VALUES(@descricao, @preco, @qtd_estoque, @fornecedor_id)";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@descricao", obj.Descricao);
                cmd.Parameters.AddWithValue("@preco", obj.Preco);
                cmd.Parameters.AddWithValue("@qtd_estoque", obj.QtdEstoque);
                cmd.Parameters.AddWithValue("@fornecedor_id", obj.Fornecedor_id);

                vcon.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produto cadastrado com sucesso", "Sucesso ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vcon.Close();
                vcon.Dispose();
                vcon.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar cliente: " + ex);
            }
        }

        public void AlterarProduto(Produto obj)
        {
            try
            {
                string sql = @"UPDATE tb_produto SET descricao=@descricao, preco=@preco, qtd_estoque=@qtd_estoque, fornecedor_id=fornecedor_id 
                                WHERE id_produto=@id";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@descricao", obj.Descricao);
                cmd.Parameters.AddWithValue("@preco", obj.Preco);
                cmd.Parameters.AddWithValue("@qtd_estoque", obj.QtdEstoque);
                cmd.Parameters.AddWithValue("@fornecedor_id", obj.Fornecedor_id);
                cmd.Parameters.AddWithValue("@id", obj.Id_produto);
                vcon.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produto atualizado com sucesso", "Sucesso ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vcon.Close();
                vcon.Dispose();
                vcon.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao cadastrar cliente: " + ex);
            }
        }

        public void ExcluirProduto(Produto obj)
        {
            try
            {
                string sql = @"DELETE FROM tb_produto WHERE id_produto=@id";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@id", obj.Id_produto);

                vcon.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produto excluido com sucesso", "Sucesso ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vcon.Close();
                vcon.Dispose();
                vcon.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao cadastrar cliente: " + ex);
            }
        }

        public DataTable ListarProduto()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = @"SELECT 
                            p.id_produto as 'ID',
                            p.descricao as 'DESCRIÇÂO',
                            p.qtd_estoque as 'ESTOQUE',
                            p.preco as 'PREÇO',
                            f.nome as 'FORNECEDOR'
                        FROM
                            tb_produto p
                        INNER JOIN
                            tb_fornecedor f ON f.id_fornecedor=p.fornecedor_id";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                vcon.Open();
                cmd.ExecuteNonQuery();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                vcon.Close();

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + ex);
                return null;
            }
        }

        public DataTable ListarProdutoPorNome(string nome)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = @"SELECT
                            p.id_produto as 'ID',
                            p.descricao as 'DESCRIÇÂO',
                            p.qtd_estoque as 'ESTOQUE',
                            p.preco as 'PREÇO',
                            f.nome as 'FORNECEDOR'
                        FROM
                            tb_produto p
                        INNER JOIN
                            tb_fornecedor f ON f.id_fornecedor = p.fornecedor_id 
                        WHERE
                            descricao like @nome";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@nome", nome);
                vcon.Open();
                cmd.ExecuteNonQuery();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                vcon.Close();

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + ex);
                return null;
            }
        }

        public Produto RetornaProdutoPorId(int id)
        {
            try
            {
                Produto obj = new Produto();
                string sql = "SELECT * FROM tb_produto WHERE id_produto = @id";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@id", id);
                vcon.Open();
                MySqlDataReader read = cmd.ExecuteReader();
                if (read.Read())
                {
                    obj.Id_produto = read.GetInt32("id_produto");
                    obj.Descricao = read.GetString("descricao");
                    obj.Preco = read.GetDecimal("preco");
                    obj.QtdEstoque = read.GetInt32("qtd_estoque");
                    vcon.Close();
                    vcon.Dispose();
                    return obj;
                }
                else
                {
                    MessageBox.Show("Produto não encontrado", "Erro ao consultar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    vcon.Close();
                    vcon.Dispose();
                    return null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Aconteceu um erro" + ex);
                return null;
            }
        }


        public void BaixaEstoque(int idProduto, int qtdEstoque)
        {
            try
            {
                string sql = "UPDATE tb_produto SET qtd_estoque=@qtd WHERE id_produto=@id";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@qtd", qtdEstoque);
                cmd.Parameters.AddWithValue("@id", idProduto);
                vcon.Open();
                cmd.ExecuteNonQuery();
                vcon.Close();
                vcon.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aconteceu o erro: " + ex);
                vcon.Close();
                vcon.Dispose();
            }
        }

        public int RetornaEstoqueAtual(int idProduto)
        {
            try
            {
                int qtd_estoque = 0;
                string sql = "SELECT qtd_estoque FROM tb_produto WHERE id_produto=@id";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@id", idProduto);
                vcon.Open();

                MySqlDataReader read = cmd.ExecuteReader();
                if (read.Read())
                {
                    qtd_estoque = read.GetInt32("qtd_estoque");
                    vcon.Close();
                }
                return qtd_estoque;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aconteceu o erro: " + ex);
                return 0;
            }
        }
    }
}
