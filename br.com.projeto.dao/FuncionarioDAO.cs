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
    public class FuncionarioDAO
    {
        private readonly MySqlConnection vcon;

        public FuncionarioDAO()
        {
            this.vcon = new ConnectionFactory().GetConnection();
        }

        public void CadastrarFuncionario(Funcionarios obj)
        {
            try
            {
                string sql = @"INSERT INTO tb_funcionario(nome, rg, cpf, email, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado, senha, cargo, nivel) 
                            VALUES(@nome, @rg, @cpf, @email, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado, @senha, @cargo, @nivel)";
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
                cmd.Parameters.AddWithValue("@senha", obj.Senha);
                cmd.Parameters.AddWithValue("@cargo", obj.Cargo);
                cmd.Parameters.AddWithValue("@nivel", obj.Nivel);

                vcon.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcionario cadastrado com sucesso", "Sucesso ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vcon.Close();
                vcon.Dispose();
                vcon.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aconteceu o erro: "+ ex);
            }
        }


        public void AlterarFuncionario(Funcionarios obj)
        {
            try
            {
                string sql = @"UPDATE tb_funcionario SET nome=@nome, rg=@rg, cpf=@cpf, email=@email, telefone=@telefone, celular=@celular, cep=@cep, endereco=@endereco, 
                                numero=@numero, complemento=@complemento, bairro=@bairro, cidade=@cidade, estado=@estado, senha=@senha, cargo=@cargo, nivel@nivel
                                WHERE id_funcionario=@id";
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
                cmd.Parameters.AddWithValue("@senha", obj.Senha);
                cmd.Parameters.AddWithValue("@cargo", obj.Cargo);
                cmd.Parameters.AddWithValue("@nivel", obj.Nivel);
                cmd.Parameters.AddWithValue("@id", obj.Codigo);

                vcon.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcionario atualizado com sucesso", "Sucesso ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vcon.Close();
                vcon.Dispose();
                vcon.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Aconteceu o erro: " + ex);
            }
        }

        public void ExcluirFuncionario(Funcionarios obj)
        {
            try
            {
                string sql = @"DELETE FROM tb_funcionario WHERE id_funcionario=@id";
                MySqlCommand cmd = new MySqlCommand(sql, vcon);
                cmd.Parameters.AddWithValue("@id", obj.Codigo);
                vcon.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcionario excluido com sucesso", "Sucesso ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vcon.Close();
                vcon.Dispose();
                vcon.ClearAllPoolsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aconteceu o erro: " + ex);
            }            
        }

        public DataTable ListarFuncionario()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT * FROM tb_funcionario";
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
                string sql = "SELECT * FROM tb_funcionario WHERE nome=@nome";
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

        public DataTable ListarFuncionarioPorNome(string nome)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT * FROM tb_funcionario WHERE nome like @nome";
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
