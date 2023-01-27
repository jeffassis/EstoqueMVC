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
    public partial class FrmLogin : Form
    {
        readonly FrmMenu form1;
        public FrmLogin(FrmMenu f)
        {
            InitializeComponent();
            form1 = f;
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string senha = txtSenha.Text;

            FuncionarioDAO dao = new FuncionarioDAO();
            if (dao.EfetuarLogin(email, senha))
            {
                this.Hide();
            }       
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
