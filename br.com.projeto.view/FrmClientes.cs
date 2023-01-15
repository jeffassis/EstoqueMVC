using ControleVendas.br.com.projeto.dao;
using ControleVendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleVendas.br.com.projeto.view
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            Grid.DefaultCellStyle.ForeColor = Color.Black;

            ClienteDAO dao = new ClienteDAO();
            Grid.DataSource = dao.ListarClientes();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente
            {
                //obj.Codigo = int.Parse(txtCodigo.Text);
                Nome = txtNome.Text,
                Rg = txtRg.Text,
                Cpf = txtCpf.Text,
                Email = txtEmail.Text,
                Telefone = txtTelefone.Text,
                Celular = txtCelular.Text,
                Cep = txtCep.Text,
                Endereco = txtEndereco.Text,
                Numero = int.Parse(txtNumero.Text),
                Complemento = txtComplemento.Text,
                Bairro = txtBairro.Text,
                Cidade = txtCidade.Text,
                Estado = cbUf.Text
            };

            ClienteDAO dao = new ClienteDAO();
            dao.CadastrarCliente(obj);
            new Helpers().LimparTela(this);
            Grid.DataSource = dao.ListarClientes();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente
            {
                //obj.Codigo = int.Parse(txtCodigo.Text);
                Nome = txtNome.Text,
                Rg = txtRg.Text,
                Cpf = txtCpf.Text,
                Email = txtEmail.Text,
                Telefone = txtTelefone.Text,
                Celular = txtCelular.Text,
                Cep = txtCep.Text,
                Endereco = txtEndereco.Text,
                Numero = int.Parse(txtNumero.Text),
                Complemento = txtComplemento.Text,
                Bairro = txtBairro.Text,
                Cidade = txtCidade.Text,
                Estado = cbUf.Text,
                Codigo = int.Parse(txtCodigo.Text)
            };

            ClienteDAO dao = new ClienteDAO();
            dao.AlterarCliente(obj);
            new Helpers().LimparTela(this);
            Grid.DataSource = dao.ListarClientes();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente
            {
                Codigo = int.Parse(txtCodigo.Text)
            };

            ClienteDAO dao = new ClienteDAO();
            dao.ExcluirCliente(obj);
            new Helpers().LimparTela(this);
            Grid.DataSource = dao.ListarClientes();
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = Grid.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = Grid.CurrentRow.Cells[1].Value.ToString();
            txtRg.Text = Grid.CurrentRow.Cells[2].Value.ToString();
            txtCpf.Text = Grid.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = Grid.CurrentRow.Cells[4].Value.ToString();
            txtTelefone.Text = Grid.CurrentRow.Cells[5].Value.ToString();
            txtCelular.Text = Grid.CurrentRow.Cells[6].Value.ToString();
            txtCep.Text = Grid.CurrentRow.Cells[7].Value.ToString();
            txtEndereco.Text = Grid.CurrentRow.Cells[8].Value.ToString();
            txtNumero.Text = Grid.CurrentRow.Cells[9].Value.ToString();
            txtComplemento.Text = Grid.CurrentRow.Cells[10].Value.ToString();
            txtBairro.Text = Grid.CurrentRow.Cells[11].Value.ToString();
            txtCidade.Text = Grid.CurrentRow.Cells[12].Value.ToString();
            cbUf.Text = Grid.CurrentRow.Cells[13].Value.ToString();

            // Alterar para a guia de Dados Clientes
            TabClientes.SelectedTab = TabDadosPessoais;
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = TxtBuscarNome.Text;

            ClienteDAO dao = new ClienteDAO();

            Grid.DataSource = dao.BuscarClientePorNome(nome);

            if (Grid.Rows.Count == 0)
            {
                Grid.DataSource = dao.ListarClientes();
            }
        }

        private void TxtBuscarNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + TxtBuscarNome + "%";

            ClienteDAO dao = new ClienteDAO();

            Grid.DataSource = dao.ListarClientesPorNome(nome);
        }

        private void BtnCep_Click(object sender, EventArgs e)
        {
            try
            {
                string cep = txtCep.Text;
                string xml = "https://viacep.com.br/ws/"+cep+"/xml/";

                DataSet dados = new DataSet();
                dados.ReadXml(xml);

                txtEndereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                txtBairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                txtComplemento.Text = dados.Tables[0].Rows[0]["complemento"].ToString();
                txtCidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                cbUf.Text = dados.Tables[0].Rows[0]["uf"].ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Endereço não encontrado, por favor digite manualmente.");
            }
        }
    }
}
