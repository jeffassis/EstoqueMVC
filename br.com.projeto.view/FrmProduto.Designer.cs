
namespace ControleVendas.br.com.projeto.view
{
    partial class FrmProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TabProduto = new System.Windows.Forms.TabControl();
            this.TabDadosPessoais = new System.Windows.Forms.TabPage();
            this.CbFornecedor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TabConsulta = new System.Windows.Forms.TabPage();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.TxtBuscarNome = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.TabProduto.SuspendLayout();
            this.TabDadosPessoais.SuspendLayout();
            this.TabConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Produtos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 100);
            this.panel1.TabIndex = 3;
            // 
            // TabProduto
            // 
            this.TabProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabProduto.Controls.Add(this.TabDadosPessoais);
            this.TabProduto.Controls.Add(this.TabConsulta);
            this.TabProduto.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabProduto.Location = new System.Drawing.Point(12, 106);
            this.TabProduto.Name = "TabProduto";
            this.TabProduto.SelectedIndex = 0;
            this.TabProduto.Size = new System.Drawing.Size(644, 373);
            this.TabProduto.TabIndex = 4;
            // 
            // TabDadosPessoais
            // 
            this.TabDadosPessoais.Controls.Add(this.CbFornecedor);
            this.TabDadosPessoais.Controls.Add(this.label6);
            this.TabDadosPessoais.Controls.Add(this.txtPreco);
            this.TabDadosPessoais.Controls.Add(this.label5);
            this.TabDadosPessoais.Controls.Add(this.txtEstoque);
            this.TabDadosPessoais.Controls.Add(this.txtDescricao);
            this.TabDadosPessoais.Controls.Add(this.txtCodigo);
            this.TabDadosPessoais.Controls.Add(this.label4);
            this.TabDadosPessoais.Controls.Add(this.label3);
            this.TabDadosPessoais.Controls.Add(this.label2);
            this.TabDadosPessoais.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TabDadosPessoais.Location = new System.Drawing.Point(4, 33);
            this.TabDadosPessoais.Name = "TabDadosPessoais";
            this.TabDadosPessoais.Padding = new System.Windows.Forms.Padding(3);
            this.TabDadosPessoais.Size = new System.Drawing.Size(636, 336);
            this.TabDadosPessoais.TabIndex = 0;
            this.TabDadosPessoais.Text = "Dados Pessoais";
            this.TabDadosPessoais.UseVisualStyleBackColor = true;
            // 
            // CbFornecedor
            // 
            this.CbFornecedor.FormattingEnabled = true;
            this.CbFornecedor.Location = new System.Drawing.Point(162, 172);
            this.CbFornecedor.Name = "CbFornecedor";
            this.CbFornecedor.Size = new System.Drawing.Size(389, 32);
            this.CbFornecedor.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(12, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fornecedor:";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(417, 237);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(80, 33);
            this.txtPreco.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(282, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Preço (R$):";
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(162, 237);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(80, 33);
            this.txtEstoque.TabIndex = 2;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(162, 111);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(389, 33);
            this.txtDescricao.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(162, 44);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(80, 33);
            this.txtCodigo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(50, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Estoque:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(28, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descrição:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(55, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Código:";
            // 
            // TabConsulta
            // 
            this.TabConsulta.Controls.Add(this.Grid);
            this.TabConsulta.Controls.Add(this.TxtBuscarNome);
            this.TabConsulta.Controls.Add(this.label16);
            this.TabConsulta.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TabConsulta.Location = new System.Drawing.Point(4, 33);
            this.TabConsulta.Name = "TabConsulta";
            this.TabConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.TabConsulta.Size = new System.Drawing.Size(636, 336);
            this.TabConsulta.TabIndex = 1;
            this.TabConsulta.Text = "Consulta";
            this.TabConsulta.UseVisualStyleBackColor = true;
            // 
            // Grid
            // 
            this.Grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(8, 65);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(622, 265);
            this.Grid.TabIndex = 11;
            this.Grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellClick);
            // 
            // TxtBuscarNome
            // 
            this.TxtBuscarNome.Location = new System.Drawing.Point(104, 17);
            this.TxtBuscarNome.Name = "TxtBuscarNome";
            this.TxtBuscarNome.Size = new System.Drawing.Size(232, 33);
            this.TxtBuscarNome.TabIndex = 10;
            this.TxtBuscarNome.TextChanged += new System.EventHandler(this.TxtBuscarNome_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label16.Location = new System.Drawing.Point(18, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 24);
            this.label16.TabIndex = 6;
            this.label16.Text = "Nome:";
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnExcluir.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnExcluir.ForeColor = System.Drawing.Color.White;
            this.BtnExcluir.Location = new System.Drawing.Point(420, 485);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(109, 45);
            this.BtnExcluir.TabIndex = 13;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnEditar.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnEditar.ForeColor = System.Drawing.Color.White;
            this.BtnEditar.Location = new System.Drawing.Point(305, 485);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(109, 45);
            this.BtnEditar.TabIndex = 12;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnSalvar.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnSalvar.ForeColor = System.Drawing.Color.White;
            this.BtnSalvar.Location = new System.Drawing.Point(190, 485);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(109, 45);
            this.BtnSalvar.TabIndex = 11;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = false;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnNovo.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnNovo.ForeColor = System.Drawing.Color.White;
            this.BtnNovo.Location = new System.Drawing.Point(75, 485);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(109, 45);
            this.BtnNovo.TabIndex = 10;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = false;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 542);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.TabProduto);
            this.Controls.Add(this.panel1);
            this.Name = "FrmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProduto";
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TabProduto.ResumeLayout(false);
            this.TabDadosPessoais.ResumeLayout(false);
            this.TabDadosPessoais.PerformLayout();
            this.TabConsulta.ResumeLayout(false);
            this.TabConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl TabProduto;
        private System.Windows.Forms.TabPage TabDadosPessoais;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage TabConsulta;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.TextBox TxtBuscarNome;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CbFornecedor;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnNovo;
    }
}