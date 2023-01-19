
namespace ControleVendas.br.com.projeto.view
{
    partial class FrmFornecedor
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
            this.TabFornecedor = new System.Windows.Forms.TabControl();
            this.TabDadosPessoais = new System.Windows.Forms.TabPage();
            this.BtnCep = new System.Windows.Forms.Button();
            this.cbUf = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TabConsulta = new System.Windows.Forms.TabPage();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.TxtBuscarNome = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.TabFornecedor.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(263, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Fornecedor";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 100);
            this.panel1.TabIndex = 2;
            // 
            // TabFornecedor
            // 
            this.TabFornecedor.Controls.Add(this.TabDadosPessoais);
            this.TabFornecedor.Controls.Add(this.TabConsulta);
            this.TabFornecedor.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabFornecedor.Location = new System.Drawing.Point(17, 109);
            this.TabFornecedor.Name = "TabFornecedor";
            this.TabFornecedor.SelectedIndex = 0;
            this.TabFornecedor.Size = new System.Drawing.Size(801, 435);
            this.TabFornecedor.TabIndex = 3;
            // 
            // TabDadosPessoais
            // 
            this.TabDadosPessoais.Controls.Add(this.BtnCep);
            this.TabDadosPessoais.Controls.Add(this.cbUf);
            this.TabDadosPessoais.Controls.Add(this.label15);
            this.TabDadosPessoais.Controls.Add(this.txtCidade);
            this.TabDadosPessoais.Controls.Add(this.label14);
            this.TabDadosPessoais.Controls.Add(this.txtBairro);
            this.TabDadosPessoais.Controls.Add(this.label13);
            this.TabDadosPessoais.Controls.Add(this.txtComplemento);
            this.TabDadosPessoais.Controls.Add(this.label12);
            this.TabDadosPessoais.Controls.Add(this.txtNumero);
            this.TabDadosPessoais.Controls.Add(this.label11);
            this.TabDadosPessoais.Controls.Add(this.txtEndereco);
            this.TabDadosPessoais.Controls.Add(this.label10);
            this.TabDadosPessoais.Controls.Add(this.txtCep);
            this.TabDadosPessoais.Controls.Add(this.label9);
            this.TabDadosPessoais.Controls.Add(this.txtCelular);
            this.TabDadosPessoais.Controls.Add(this.label8);
            this.TabDadosPessoais.Controls.Add(this.txtTelefone);
            this.TabDadosPessoais.Controls.Add(this.label7);
            this.TabDadosPessoais.Controls.Add(this.txtCnpj);
            this.TabDadosPessoais.Controls.Add(this.txtEmail);
            this.TabDadosPessoais.Controls.Add(this.txtNome);
            this.TabDadosPessoais.Controls.Add(this.txtCodigo);
            this.TabDadosPessoais.Controls.Add(this.label5);
            this.TabDadosPessoais.Controls.Add(this.label4);
            this.TabDadosPessoais.Controls.Add(this.label3);
            this.TabDadosPessoais.Controls.Add(this.label2);
            this.TabDadosPessoais.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TabDadosPessoais.Location = new System.Drawing.Point(4, 33);
            this.TabDadosPessoais.Name = "TabDadosPessoais";
            this.TabDadosPessoais.Padding = new System.Windows.Forms.Padding(3);
            this.TabDadosPessoais.Size = new System.Drawing.Size(793, 398);
            this.TabDadosPessoais.TabIndex = 0;
            this.TabDadosPessoais.Text = "Dados Pessoais";
            this.TabDadosPessoais.UseVisualStyleBackColor = true;
            // 
            // BtnCep
            // 
            this.BtnCep.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnCep.ForeColor = System.Drawing.Color.White;
            this.BtnCep.Location = new System.Drawing.Point(526, 230);
            this.BtnCep.Name = "BtnCep";
            this.BtnCep.Size = new System.Drawing.Size(113, 40);
            this.BtnCep.TabIndex = 20;
            this.BtnCep.Text = "Pesquisar";
            this.BtnCep.UseVisualStyleBackColor = false;
            this.BtnCep.Click += new System.EventHandler(this.BtnCep_Click);
            // 
            // cbUf
            // 
            this.cbUf.FormattingEnabled = true;
            this.cbUf.Items.AddRange(new object[] {
            "ES",
            "MG",
            "RJ",
            "SP"});
            this.cbUf.Location = new System.Drawing.Point(703, 238);
            this.cbUf.Name = "cbUf";
            this.cbUf.Size = new System.Drawing.Size(66, 32);
            this.cbUf.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label15.Location = new System.Drawing.Point(659, 241);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 24);
            this.label15.TabIndex = 30;
            this.label15.Text = "UF:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(132, 237);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(160, 33);
            this.txtCidade.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label14.Location = new System.Drawing.Point(25, 241);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 24);
            this.label14.TabIndex = 28;
            this.label14.Text = "Cidade:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(132, 334);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(160, 33);
            this.txtBairro.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label13.Location = new System.Drawing.Point(46, 337);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 24);
            this.label13.TabIndex = 26;
            this.label13.Text = "Bairro:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(473, 334);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(296, 33);
            this.txtComplemento.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label12.Location = new System.Drawing.Point(298, 337);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 24);
            this.label12.TabIndex = 24;
            this.label12.Text = "Complemento:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(703, 284);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(66, 33);
            this.txtNumero.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label11.Location = new System.Drawing.Point(658, 287);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 24);
            this.label11.TabIndex = 22;
            this.label11.Text = "Nº:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(132, 284);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(520, 33);
            this.txtEndereco.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(1, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 24);
            this.label10.TabIndex = 20;
            this.label10.Text = "Endereço:";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(361, 237);
            this.txtCep.Mask = "00000-999";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(157, 33);
            this.txtCep.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(301, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 24);
            this.label9.TabIndex = 18;
            this.label9.Text = "CEP:";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(132, 190);
            this.txtCelular.Mask = "(99) 00000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(162, 33);
            this.txtCelular.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(27, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Celular:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(132, 144);
            this.txtTelefone.Mask = "(99) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(162, 33);
            this.txtTelefone.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(12, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Telefone:";
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(377, 147);
            this.txtCnpj.Mask = "##,###,###/####-##";
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(209, 33);
            this.txtCnpj.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(132, 104);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(454, 33);
            this.txtEmail.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(132, 62);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(454, 33);
            this.txtNome.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(132, 18);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(69, 33);
            this.txtCodigo.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(301, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "CNPJ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(47, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(36, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(25, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Código:";
            // 
            // TabConsulta
            // 
            this.TabConsulta.Controls.Add(this.Grid);
            this.TabConsulta.Controls.Add(this.BtnPesquisar);
            this.TabConsulta.Controls.Add(this.TxtBuscarNome);
            this.TabConsulta.Controls.Add(this.label16);
            this.TabConsulta.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TabConsulta.Location = new System.Drawing.Point(4, 33);
            this.TabConsulta.Name = "TabConsulta";
            this.TabConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.TabConsulta.Size = new System.Drawing.Size(793, 398);
            this.TabConsulta.TabIndex = 1;
            this.TabConsulta.Text = "Consulta";
            this.TabConsulta.UseVisualStyleBackColor = true;
            // 
            // Grid
            // 
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(8, 65);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(767, 312);
            this.Grid.TabIndex = 11;
            this.Grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellClick);
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnPesquisar.ForeColor = System.Drawing.Color.White;
            this.BtnPesquisar.Location = new System.Drawing.Point(342, 10);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(120, 45);
            this.BtnPesquisar.TabIndex = 6;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = false;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
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
            this.BtnExcluir.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnExcluir.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.ForeColor = System.Drawing.Color.White;
            this.BtnExcluir.Location = new System.Drawing.Point(498, 557);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(109, 45);
            this.BtnExcluir.TabIndex = 13;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnEditar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.Color.White;
            this.BtnEditar.Location = new System.Drawing.Point(383, 557);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(109, 45);
            this.BtnEditar.TabIndex = 12;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnSalvar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.ForeColor = System.Drawing.Color.White;
            this.BtnSalvar.Location = new System.Drawing.Point(268, 557);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(109, 45);
            this.BtnSalvar.TabIndex = 11;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = false;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnNovo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovo.ForeColor = System.Drawing.Color.White;
            this.BtnNovo.Location = new System.Drawing.Point(153, 557);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(109, 45);
            this.BtnNovo.TabIndex = 10;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = false;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // FrmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 624);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.TabFornecedor);
            this.Controls.Add(this.panel1);
            this.Name = "FrmFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Fornecedor";
            this.Load += new System.EventHandler(this.FrmFornecedor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TabFornecedor.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl TabFornecedor;
        private System.Windows.Forms.TabPage TabDadosPessoais;
        private System.Windows.Forms.Button BtnCep;
        private System.Windows.Forms.ComboBox cbUf;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtCnpj;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage TabConsulta;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.TextBox TxtBuscarNome;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnNovo;
    }
}