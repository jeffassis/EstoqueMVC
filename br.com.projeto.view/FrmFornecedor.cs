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
    public partial class FrmFornecedor : Form
    {
        public FrmFornecedor()
        {
            InitializeComponent();
        }

        private void FrmFornecedor_Load(object sender, EventArgs e)
        {
            FornecedorDAO dao = new FornecedorDAO();
            Grid.DataSource = dao.ListarFornecedor();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Fornecedor obj = new Fornecedor
            {
                Nome = txtNome.Text,
                Cnpj = txtCnpj.Text,
                Email = txtEmail.Text,
                Telefone = txtTelefone.Text,
                Celular = txtCelular.Text,
                Cep = txtCep.Text,
                Endereco = txtEndereco.Text,
                Numero = int.Parse(txtNumero.Text),
                Complemento = txtComplemento.Text,
                Bairro = txtBairro.Text,
                Cidade = txtCidade.Text,
                Estado = cbUf.SelectedItem.ToString()
            };
            FornecedorDAO dao = new FornecedorDAO();
            dao.CadastrarFornecedor(obj);
            new Helpers().LimparTela(this);
            Grid.DataSource = dao.ListarFornecedor();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Fornecedor obj = new Fornecedor
            {
                Codigo = int.Parse(txtCodigo.Text),
                Nome = txtNome.Text,
                Cnpj = txtCnpj.Text,
                Email = txtEmail.Text,
                Telefone = txtTelefone.Text,
                Celular = txtCelular.Text,
                Cep = txtCep.Text,
                Endereco = txtEndereco.Text,
                Numero = int.Parse(txtNumero.Text),
                Complemento = txtComplemento.Text,
                Bairro = txtBairro.Text,
                Cidade = txtCidade.Text,
                Estado = cbUf.SelectedItem.ToString()
            };
            FornecedorDAO dao = new FornecedorDAO();
            dao.AlterarFornecedor(obj);
            new Helpers().LimparTela(this);
            Grid.DataSource = dao.ListarFornecedor();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Fornecedor obj = new Fornecedor
            {
                Codigo = int.Parse(txtCodigo.Text)
            };
            FornecedorDAO dao = new FornecedorDAO();
            dao.ExcluirFornecedor(obj);
            new Helpers().LimparTela(this);
            Grid.DataSource = dao.ListarFornecedor();
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = Grid.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = Grid.CurrentRow.Cells[1].Value.ToString();
            txtCnpj.Text = Grid.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = Grid.CurrentRow.Cells[3].Value.ToString();
            txtTelefone.Text = Grid.CurrentRow.Cells[4].Value.ToString();
            txtCelular.Text = Grid.CurrentRow.Cells[5].Value.ToString();
            txtCep.Text = Grid.CurrentRow.Cells[6].Value.ToString();
            txtEndereco.Text = Grid.CurrentRow.Cells[7].Value.ToString();
            txtNumero.Text = Grid.CurrentRow.Cells[8].Value.ToString();
            txtComplemento.Text = Grid.CurrentRow.Cells[9].Value.ToString();
            txtBairro.Text = Grid.CurrentRow.Cells[10].Value.ToString();
            txtCidade.Text = Grid.CurrentRow.Cells[11].Value.ToString();
            cbUf.Text = Grid.CurrentRow.Cells[12].Value.ToString();

            // Alterar para a guia de Dados Clientes
            TabFornecedor.SelectedTab = TabDadosPessoais;
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = TxtBuscarNome.Text;

            FornecedorDAO dao = new FornecedorDAO();
            Grid.DataSource = dao.BuscarPorNome(nome);

            if (Grid.Rows.Count == 0 || TxtBuscarNome.Text == string.Empty)
            {
                MessageBox.Show("Fornecedor nao encontrado!");
                Grid.DataSource = dao.ListarFornecedor();
            }
        }

        private void TxtBuscarNome_TextChanged(object sender, EventArgs e)
        {
            string nome = "%"+ TxtBuscarNome.Text + "%";

            FornecedorDAO dao = new FornecedorDAO();

            Grid.DataSource = dao.ListarFornecedorPorNome(nome);
        }

        private void BtnCep_Click(object sender, EventArgs e)
        {
            try
            {
                string cep = txtCep.Text;
                string xml = "https://viacep.com.br/ws/" + cep + "/xml/";

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
