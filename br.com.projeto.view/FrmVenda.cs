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
    public partial class FrmVenda : Form
    {
        Cliente cliente = new Cliente();
        ClienteDAO cdao = new ClienteDAO();

        Produto produto = new Produto();
        ProdutoDAO pdao = new ProdutoDAO();

        // Variaveis
        int qtd;
        decimal preco;
        decimal subtotal, total;

        // Carrinho
        DataTable carrinho = new DataTable();

        public FrmVenda()
        {
            InitializeComponent();

            carrinho.Columns.Add("Codigo", typeof(int));
            carrinho.Columns.Add("Produto", typeof(string));
            carrinho.Columns.Add("Qtd", typeof(int));
            carrinho.Columns.Add("Preço", typeof(decimal));
            carrinho.Columns.Add("SubTotal", typeof(decimal));

            Grid.DataSource = carrinho;
        }

        private void FrmVenda_Load(object sender, EventArgs e)
        {
            // Declarando data
            txtData.Text = DateTime.Now.ToShortDateString();
            txtCpf.Focus();
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cliente = cdao.RetornaClientePorCPF(txtCpf.Text);

                if (cliente != null)
                {
                    txtNome.Text = cliente.Nome;
                }
                else
                {
                    txtCpf.Clear();
                    txtCpf.Focus();
                }                
            }
        }        

        private void txtCodigoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                produto = pdao.RetornaProdutoPorId(int.Parse(txtCodigoProduto.Text));

                if (produto != null)
                {
                    txtDescricao.Text = produto.Descricao;
                    txtPreco.Text = produto.Preco.ToString();
                }
                else
                {
                    txtCodigoProduto.Clear();
                    txtDescricao.Clear();
                    txtPreco.Clear();
                    txtCodigoProduto.Focus();
                }                
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                qtd = int.Parse(txtQuantidade.Text);
                preco = decimal.Parse(txtPreco.Text);

                subtotal = qtd * preco;

                total += subtotal;

                // Adicionar o produto no carrinho
                carrinho.Rows.Add(int.Parse(txtCodigoProduto.Text), txtDescricao.Text, qtd, preco, subtotal);

                // Valor total
                txtTotalVenda.Text = total.ToString();

                // Limpar os campos
                txtCodigoProduto.Clear();
                txtDescricao.Clear();
                txtPreco.Clear();
                txtQuantidade.Clear();
                txtCodigoProduto.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Digite o código do Produto!: ");
            }
        }        

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            decimal subproduto = decimal.Parse(Grid.CurrentRow.Cells[4].Value.ToString());

            int indice = Grid.CurrentRow.Index;
            DataRow linha = carrinho.Rows[indice];

            carrinho.Rows.Remove(linha);
            carrinho.AcceptChanges();

            total -= subproduto;

            // Valor total
            txtTotalVenda.Text = total.ToString();

            MessageBox.Show("Item removido do carrinho com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnPagamento_Click(object sender, EventArgs e)
        {
            DateTime dataAtual = DateTime.Parse(txtData.Text);
            FrmPagamentos form = new FrmPagamentos(cliente, carrinho, dataAtual);

            form.txtTotal.Text = total.ToString();
            form.ShowDialog();
        }

    }
}
