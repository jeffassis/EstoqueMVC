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
    public class ClienteDAO
    {
        private readonly MySqlConnection vcon;

        public ClienteDAO()
        {
            this.vcon = new ConnectionFactory().GetConnection();
        }

        public void CadastrarCliente(Cliente obj)
        {
            try
            {
                string sql = @"INSERT INTO tb_cliente(nome, rg, cpf, email, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado) 
                            VALUES(@nome, @rg, @cpf, @email, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@nome", obj.Nome);
                cmd.Parameters.AddWithValue("@rg", obj.Rg);
                cmd.Parameters.AddWithValue("@cpf", obj.Cpf);
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
                MessageBox.Show("Cliente cadastrado com sucesso", "Sucesso ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vcon.Close();
                vcon.Dispose();
                vcon.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar cliente: "+ ex);
            }
        }

        public void AlterarCliente(Cliente obj)
        {
            try
            {
                string sql = @"UPDATE tb_cliente SET nome=@nome, rg=@rg, cpf=@cpf, email=@email, telefone=@telefone, celular=@celular, cep=#cep, endereco=@endereco, 
                            numero=@numero, complemento=@complemento, bairro=@bairro, cidade=@cidade, estado=@estado WHERE id_cliente=@id";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@nome", obj.Nome);
                cmd.Parameters.AddWithValue("@rg", obj.Rg);
                cmd.Parameters.AddWithValue("@cpf", obj.Cpf);
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
                MessageBox.Show("Cliente atualizado com sucesso", "Sucesso ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vcon.Close();
                vcon.Dispose();
                vcon.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao cadastrar cliente: " + ex);
            }
        }

        public void ExcluirCliente(Cliente obj)
        {
            try
            {
                string sql = @"DELETE FROM tb_cliente WHERE id_cliente=@id";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@id", obj.Codigo);

                vcon.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente excluido com sucesso", "Sucesso ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vcon.Close();
                vcon.Dispose();
                vcon.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao cadastrar cliente: " + ex);
            }
        }

        public DataTable ListarClientes()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT * FROM tb_cliente";
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

        public DataTable BuscarClientePorNome(string nome)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT * FROM tb_cliente WHERE nome=@nome";
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

        public DataTable ListarClientesPorNome(string nome)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT * FROM tb_cliente WHERE nome like @nome";
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
    
        public Cliente RetornaClientePorCPF(string cpf)
        {
            try
            {
                Cliente obj = new Cliente();
                string sql = "SELECT * FROM tb_cliente WHERE cpf = @cpf";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                vcon.Open();
                MySqlDataReader read = cmd.ExecuteReader();

                if (read.Read())
                {
                    obj.Codigo = read.GetInt32("id_cliente");
                    obj.Nome = read.GetString("nome");

                    return obj;
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado","Erro ao consultar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aconteceu um erro"+ ex);
                return null;
            }
        }
    }
}
