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
    public partial class FrmDetalhes : Form
    {
        int venda_id;
        public FrmDetalhes(int idVenda)
        {
            venda_id = idVenda;
            InitializeComponent();
        }

        private void FrmDetalhes_Load(object sender, EventArgs e)
        {
            ItemVendaDAO dao = new ItemVendaDAO();
            Grid.DataSource = dao.ListarItensVenda(venda_id);
        }
    }
}
