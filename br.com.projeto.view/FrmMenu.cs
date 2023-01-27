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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            FrmLogin login = new FrmLogin(this);
            login.ShowDialog();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            txtData.Text = DateTime.Now.ToShortDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Controle do Timer
            txtHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void cadastroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes form = new FrmClientes();
            form.ShowDialog();
        }

        private void consultaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes form = new FrmClientes();
            form.TabClientes.SelectedTab = form.TabConsulta;
            form.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja mesmo Sair?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes form = new FrmClientes();
            form.Show();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFornecedor form = new FrmFornecedor();
            form.Show();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFuncionarios form = new FrmFuncionarios();
            form.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProduto form = new FrmProduto();
            form.Show();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVenda form = new FrmVenda();
            form.Show();
        }

        private void detalhesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHistorico form = new FrmHistorico();
            form.Show();
        }
    }
}
