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
    public partial class FrmPagamentos : Form
    {
        Cliente cliente = new Cliente();
        DataTable carrinho = new DataTable();
        DateTime dataAtual;
        public FrmPagamentos(Cliente cliente, DataTable carrinho, DateTime dataAtual)
        {
            this.cliente = cliente;
            this.carrinho = carrinho;
            this.dataAtual = dataAtual;
            InitializeComponent();            
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal v_dinheiro, v_cartao, troco, totalpago, total;

                v_dinheiro = decimal.Parse(txtDinheiro.Text);
                v_cartao = decimal.Parse(txtCartao.Text);
                total = decimal.Parse(txtTotal.Text);

                // Calcular o total pago
                totalpago = v_dinheiro + v_cartao;                

                if (totalpago < total)
                {
                    MessageBox.Show("O total pago é menor que o valor Total da Venda!");
                }
                else
                {
                    // Calcular o troco 
                    troco = totalpago - total;

                    Venda venda = new Venda
                    {
                        Cliente_id = cliente.Codigo,
                        Data_venda = dataAtual,
                        Total_venda = total,
                        Obs = txtObs.Text
                    };

                    // Exibir o troco
                    txtTroco.Text = troco.ToString();

                    // Executa a venda
                    VendaDAO vdao = new VendaDAO();
                    vdao.CadastrarVenda(venda);


                    // Cadastrar os itens da venda
                    // Percorrendo os itens do carrinho
                    foreach (DataRow linha in carrinho.Rows)
                    {
                        ItemVenda item = new ItemVenda();
                        item.Venda_id = vdao.RetornaIdUltimaVenda();
                        item.Produto_id = int.Parse(linha["Codigo"].ToString());
                        item.qtd = int.Parse(linha["Qtd"].ToString());
                        item.Subtotal = decimal.Parse(linha["SubTotal"].ToString());

                        ItemVendaDAO itemDAO = new ItemVendaDAO();
                        itemDAO.CadastrarItem(item);
                    }
                    MessageBox.Show("Venda finalizada com sucesso!");
                    this.Dispose();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FrmPagamentos_Load(object sender, EventArgs e)
        {
            txtDinheiro.Text = "0,00";
            txtCartao.Text = "0,00";
            txtTroco.Text = "0,00";
        }
    }
}
