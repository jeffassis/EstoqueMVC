using ControleVendas.br.com.projeto.dao;
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
    public partial class FrmHistorico : Form
    {
        public FrmHistorico()
        {
            InitializeComponent();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            DateTime dataInicial, dataFinal;

            dataInicial = Convert.ToDateTime(DtInicial.Value.ToString("yyyy-MM-dd"));
            dataFinal = Convert.ToDateTime(DtFinal.Value.ToString("yyyy-MM-dd"));

            VendaDAO dao = new VendaDAO();
            Grid.DataSource = dao.ListarVendasPorPeriodo(dataInicial, dataFinal);
        }

        private void FrmHistorico_Load(object sender, EventArgs e)
        {
            VendaDAO dao = new VendaDAO();
            Grid.DataSource = dao.ListarVendas();

        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Passando o id da venda
            int venda_id = int.Parse(Grid.CurrentRow.Cells[0].Value.ToString());
            FrmDetalhes form = new FrmDetalhes(venda_id);

            // Formatando a data
            DateTime dataVenda = Convert.ToDateTime(Grid.CurrentRow.Cells[1].Value.ToString());
            form.txtData.Text = dataVenda.ToString("dd-MM-yyyy");

            form.txtCliente.Text = Grid.CurrentRow.Cells[2].Value.ToString();
            form.txtTotalVenda.Text = Grid.CurrentRow.Cells[3].Value.ToString();
            form.txtObs.Text = Grid.CurrentRow.Cells[4].Value.ToString();          

            form.ShowDialog();
        }
    }
}
