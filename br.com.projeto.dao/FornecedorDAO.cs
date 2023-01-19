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
    public class FornecedorDAO
    {
        private readonly MySqlConnection vcon;

        public FornecedorDAO()
        {
            this.vcon = new ConnectionFactory().GetConnection();
        }

        public void CadastrarFornecedor(Fornecedor obj)
        {
            try
            {
                string sql = @"INSERT INTO tb_fornecedor(nome, cnpj, email, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado) 
                            VALUES(@nome, @cnpj, @email, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@nome", obj.Nome);
                cmd.Parameters.AddWithValue("@cnpj", obj.Cnpj);
                cmd.Parameters.AddWithValue("@email", obj.Email);
                cmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                cmd.Parameters.AddWithValue("@celular", obj.Celular);
                cmd.Parameters.AddWithValue("@cep", obj.Cep);
                cmd.Parameters.AddWithValue("@endereco", obj.Endereco);
                cmd.Parameters.AddWithValue("@numero", obj.Numero);
                cmd.Parameters.AddWithValue("@complemento", obj.Complemento);
                cmd.Parameters.AddWithValue("@bairro", obj.Bairro);
                cmd.Parameters.AddWithValue("@cidade", obj.Cidade);
                cmd.Parameters.AddWithValue("@estado", obj.Estado);

                vcon.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Fornecedor cadastrado com sucesso", "Sucesso ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vcon.Close();
                vcon.Dispose();
                vcon.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aconteceu o erro: " + ex);
            }
        }

        public void AlterarFornecedor(Fornecedor obj)
        {
            try
            {
                string sql = @"UPDATE tb_fornecedor SET nome=@nome, cnpj=@cnpj, email=@email, telefone=@telefone, celular=@celular, cep=@cep, endereco=@endereco, 
                                numero=@numero, complemento=@complemento, bairro=@bairro, cidade=@cidade, estado=@estado WHERE id_fornecedor=@id";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@nome", obj.Nome);
                cmd.Parameters.AddWithValue("@cnpj", obj.Cnpj);
                cmd.Parameters.AddWithValue("@email", obj.Email);
                cmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                cmd.Parameters.AddWithValue("@celular", obj.Celular);
                cmd.Parameters.AddWithValue("@cep", obj.Cep);
                cmd.Parameters.AddWithValue("@endereco", obj.Endereco);
                cmd.Parameters.AddWithValue("@numero", obj.Numero);
                cmd.Parameters.AddWithValue("@complemento", obj.Complemento);
                cmd.Parameters.AddWithValue("@bairro", obj.Bairro);
                cmd.Parameters.AddWithValue("@cidade", obj.Cidade);
                cmd.Parameters.AddWithValue("@estado", obj.Estado);
                cmd.Parameters.AddWithValue("@id", obj.Codigo);

                vcon.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Fornecedor atualizado com sucesso", "Sucesso ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vcon.Close();
                vcon.Dispose();
                vcon.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Aconteceu o erro: " + ex);
            }
        }

        public void ExcluirFornecedor(Fornecedor obj)
        {
            try
            {
                string sql = @"DELETE FROM tb_fornecedor WHERE id_fornecedor=@id";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@id", obj.Codigo);
                vcon.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Forncedor excluido com sucesso", "Sucesso ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vcon.Close();
                vcon.Dispose();
                vcon.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aconteceu o erro: " + ex);
            }
        }

        public DataTable ListarFornecedor()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT * FROM tb_fornecedor";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                vcon.Open();
                cmd.ExecuteNonQuery();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                vcon.Close();
                vcon.Dispose();
                vcon.ClearAllPoolsAsync();

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + ex);
                return null;
            }
        }

        public DataTable BuscarPorNome(string nome)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT * FROM tb_fornecedor WHERE nome=@nome";
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

        public DataTable ListarFornecedorPorNome(string nome)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT * FROM tb_fornecedor WHERE nome like @nome";
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
    }
}
