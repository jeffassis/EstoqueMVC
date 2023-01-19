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
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            ProdutoDAO dao = new ProdutoDAO();
            Grid.DataSource = dao.ListarProduto();

            FornecedorDAO f_dao = new FornecedorDAO();
            CbFornecedor.DataSource = f_dao.ListarFornecedor();
            CbFornecedor.DisplayMember = "nome";
            CbFornecedor.ValueMember = "id_fornecedor";
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto
            {
                Descricao = txtDescricao.Text,
                QtdEstoque = int.Parse(txtEstoque.Text),
                Preco = decimal.Parse(txtPreco.Text),
                Fornecedor_id = int.Parse(CbFornecedor.SelectedValue.ToString())
            };
            ProdutoDAO dao = new ProdutoDAO();
            dao.CadastrarProduto(obj);
            new Helpers().LimparTela(this);
            Grid.DataSource = dao.ListarProduto();
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = Grid.CurrentRow.Cells[0].Value.ToString();
            txtDescricao.Text = Grid.CurrentRow.Cells[1].Value.ToString();
            txtEstoque.Text = Grid.CurrentRow.Cells[2].Value.ToString();
            txtPreco.Text = Grid.CurrentRow.Cells[3].Value.ToString();
            CbFornecedor.Text = Grid.CurrentRow.Cells[4].Value.ToString();

            TabProduto.SelectedTab = TabDadosPessoais;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto
            {
                Id_produto = int.Parse(txtCodigo.Text),
                Descricao = txtDescricao.Text,
                Preco = decimal.Parse(txtPreco.Text),
                QtdEstoque = int.Parse(txtEstoque.Text),
                Fornecedor_id = int.Parse(CbFornecedor.SelectedValue.ToString())
            };
            ProdutoDAO dao = new ProdutoDAO();
            dao.AlterarProduto(obj);
            new Helpers().LimparTela(this);
            Grid.DataSource = dao.ListarProduto();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto
            {
                Id_produto = int.Parse(txtCodigo.Text)
            };
            ProdutoDAO dao = new ProdutoDAO();
            dao.ExcluirProduto(obj);
            new Helpers().LimparTela(this);
            Grid.DataSource = dao.ListarProduto();
        }

        private void TxtBuscarNome_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + TxtBuscarNome.Text + "%";

            ProdutoDAO dao = new ProdutoDAO();

            Grid.DataSource = dao.ListarProdutoPorNome(nome);
        }
    }
}
